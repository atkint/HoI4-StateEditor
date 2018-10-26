using HOI4_State_Editor.Data;
using HOI4_State_Editor.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOI4_State_Editor.Readers
{
    class StateIndexer
    {
        public BaseGameReader baseGame;
        public ModFileReader modFile;

        // Should be a Continent with a List<State>
        public Dictionary<StrategicRegion, int[]> provincesInStrategicRegion;
        public Dictionary<SupplyArea, List<State>> statesInSupplyArea;

        public Dictionary<int, State> stateIdLookup;
        public Dictionary<int, State> stateProvinceIdLookup;
        public Dictionary<string, List<State>> stateOwnerLookup;
        
        public Dictionary<string, StrategicRegion> strategicRegionNameLookup;

        public State[] AllStates;

        string StatesPath;

        public List<StrategicRegion> loadStrategicRegions()
        {
            strategicRegionNameLookup = new Dictionary<string, StrategicRegion>();
            List<StrategicRegion> returnList = new List<StrategicRegion>();
            provincesInStrategicRegion = new Dictionary<StrategicRegion, int[]>();

            string strategicRegionsFolder = ModFileReader.FolderPath + "/map/strategicregions";
            foreach(string file in Directory.GetFiles(strategicRegionsFolder))
            {
                StreamReader sr = new StreamReader(file);
                string totalText = sr.ReadToEnd();
                int idVal = int.Parse(TextParser.getVariable(totalText, "id"));
                string regionName = TextParser.getVariable(totalText, "name").Replace("\"", "").Trim();
                //Console.WriteLine(regionName);
                regionName = baseGame.LocalisationLookup.ContainsKey(regionName) ? baseGame.LocalisationLookup[regionName] : regionName;
                
                string provinceText = TextParser.GetContentsOfBrackets(totalText, "provinces");
                string[] provs = provinceText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                List<int> provIds = new List<int>();
                bool isOnlyWater = true;
                for (int i = 0; i < provs.Length; i++)
                {
                    // If i can parse the value then add it to the list of ids
                    int provId;
                    if (int.TryParse(provs[i], out provId))
                    {
                        if (!baseGame.ProvinceLookup[provId].IsWater)
                        {
                            isOnlyWater = false;
                        }
                        provIds.Add(provId);
                    }
                }
                
                StrategicRegion newRegion = new StrategicRegion(idVal, regionName);
                newRegion.IsOnlyWater = isOnlyWater;

                // Don't bother with regions that are only ocean
                if (!newRegion.IsOnlyWater)
                {
                    strategicRegionNameLookup.Add(newRegion.Name, newRegion);
                    returnList.Add(newRegion);
                    provincesInStrategicRegion.Add(newRegion, provIds.ToArray());
                }
                
                //Console.WriteLine(idVal+": "+provinceText);
                sr.Close();
            }
            return returnList;
        }

        string cleanLine(string inputLine)
        {
            int indexOfComment = inputLine.IndexOf('#');
            if (indexOfComment >= 0)
            {
                inputLine = inputLine.Remove(indexOfComment);
            }

            return inputLine.Trim();
        }

        void LoadBaseGameStates(string statesPath)
        {
            stateIdLookup = new Dictionary<int, State>();
            stateProvinceIdLookup = new Dictionary<int, State>();

            string[] statesToRead = Directory.GetFiles(statesPath, "*.txt");
            foreach (string file in statesToRead)
            {
                State newState = new State(file);
                newState.Name = baseGame.LocalisationLookup[newState.Name.Replace("\"", "")];
                newState.IsModProvince = false;
                stateIdLookup.Add(newState.ID, newState);

                foreach (int provId in newState.Provinces)
                {
                    stateProvinceIdLookup.Add(provId, newState);
                }
            }
        }

        void LoadModStates(string statesPath)
        {
            string[] statesToRead = Directory.GetFiles(statesPath, "*.txt");
            foreach (string file in statesToRead)
            {
                State newState = new State(file);
                newState.Name = baseGame.LocalisationLookup[newState.Name.Replace("\"", "")];
                newState.IsModProvince = true;
                if (stateIdLookup.ContainsKey(newState.ID))
                {
                    stateIdLookup[newState.ID] = newState;
                }
                else
                {
                    stateIdLookup.Add(newState.ID, newState);
                }

                foreach (int provId in newState.Provinces)
                {
                    if (stateProvinceIdLookup.ContainsKey(provId))
                    {
                        stateProvinceIdLookup[provId] = newState;
                    }
                    else
                    {
                        stateProvinceIdLookup.Add(provId, newState);
                    }
                }
            }
        }

        public StateIndexer(BaseGameReader gameReader, ModFileReader modReader, string statesPath)
        {
            StatesPath = statesPath;
            baseGame = gameReader;
            modFile = modReader;
            string baseGameStatesPath = baseGame.BaseFolder + "history/states/";
            LoadBaseGameStates(baseGameStatesPath);
            LoadModStates(modFile.RootFolder + "history/states/");

            // Iterate through all states with this
            List<State> allStatesList = new List<State>();
            stateOwnerLookup = new Dictionary<string, List<State>>();
            foreach (int stateID in stateIdLookup.Keys)
            {
                State newState = stateIdLookup[stateID];
                allStatesList.Add(newState);
                if (stateOwnerLookup.ContainsKey(newState.Owner))
                {
                    stateOwnerLookup[newState.Owner].Add(newState);
                }
                else
                {
                    stateOwnerLookup.Add(newState.Owner, new List<State>() { newState });
                }
            }

            AllStates = allStatesList.ToArray();

        }
    }
}
