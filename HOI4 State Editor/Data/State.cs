using HOI4_State_Editor.Helpers;
using HOI4_State_Editor.Readers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOI4_State_Editor.Data
{
    public class State
    {
        public string NameOfFile;
        public int ID;
        public string PlaceholderName;
        public string Name;
        public string Owner { get { return StateHistory.Owner; } }
        public bool IsModProvince = false;
        public int[] Provinces;
        public List<string> Cores { get { return StateHistory.Cores; } }

        public StateCategory Category;

        /// <summary>
        /// Types: infrastructure, industrial_complex, arms_factory, dockyard, synthetic_refinery, air_base, anti_air_building, radar_station, rocket_site, nuclear_reactor
        /// </summary>
        public Dictionary<string, int> StateBuildings { get { return StateHistory.Buildings.StateBuildings; } }

        /// <summary>
        /// Types: bunker, coastal_bunker, naval_base
        /// </summary>
        public Dictionary<int, Dictionary<string, int>> ProvinceBuildings { get { return StateHistory.Buildings.ProvinceBuildings; } }

        /// <summary>
        /// Types: state_category, manpower
        /// </summary>
        public Dictionary<string, string> MainVariables;

        /// <summary>
        /// provinceID, victory_points
        /// </summary>
        public Dictionary<int, int> VictoryPoints { get { return StateHistory.VictoryPoints; } }

        /// <summary>
        /// steel, aluminium, tungsten, oil, rubber, chromium
        /// </summary>
        public Dictionary<string, int> Resources;

        public StateHistoryGroup StateHistory;

        public void SetOwner(string tag)
        {
            if (StateHistory.Owner != tag)
            {
                StateHistory.Owner = tag;
                IsModProvince = true;
            }
            
        }

        public void SetResource(string resourceName, int value)
        {
            if (Resources.ContainsKey(resourceName))
            {
                if (value > 0)
                {
                    Resources[resourceName] = value;
                    IsModProvince = true;
                }
                else
                {
                    Resources.Remove(resourceName);
                    IsModProvince = true;
                }
            }
            else if (value > 0)
            {
                Resources.Add(resourceName, value);
                IsModProvince = true;
            }
        }

        public void SetManpower(int manpower)
        {
            if (MainVariables["manpower"] != manpower.ToString())
            {
                Console.WriteLine(MainVariables["manpower"] + " | " + manpower.ToString());
                MainVariables["manpower"] = manpower.ToString();
                IsModProvince = true;
                
            }
        }

        public void SetCore(string tag, bool addCore)
        {
            if (addCore && !Cores.Contains(tag))
            {
                Cores.Add(tag);
                IsModProvince = true;
            }
            else if (!addCore && Cores.Contains(tag))
            {
                Cores.Remove(tag);
                IsModProvince = true;
            }
        }

        public State(string filename)
        {
            MainVariables = new Dictionary<string, string>();

            ReadStateFile(filename);
        }

        public override string ToString()
        {
            return ID.ToString("000")+": "+Name+" ("+Owner+")"+
                (IsModProvince ? "*" : "");
        }

        public Dictionary<int,Dictionary<string,int>> GetProvinceBuildings()
        {
            return StateHistory.Buildings.ProvinceBuildings;
        }

        public Dictionary<string, int> GetStateBuildings()
        {
            return StateHistory.Buildings.StateBuildings;
        }

        public void SetStateBuilding(string buildingType, int value)
        {
            if (StateHistory.Buildings.StateBuildings.ContainsKey(buildingType))
            {
                StateHistory.Buildings.StateBuildings[buildingType] = value;
            }
            else
            {
                StateHistory.Buildings.StateBuildings.Add(buildingType,value);
            }
            IsModProvince = true;
        }

        public void ReadStateFile(string filename)
        {
            
            string nameOfTextFile = filename.Split(new string[] { "/", "\\" }, StringSplitOptions.RemoveEmptyEntries)[filename.Split(new string[] { "/", "\\" }, StringSplitOptions.RemoveEmptyEntries).Length - 1];
            StreamReader sr = new StreamReader(filename);
            string fullText = sr.ReadToEnd();
            sr.Close();

            int stateId = Convert.ToInt16(TextParser.getVariable(fullText, "id"));
            string stateName = TextParser.getVariable(fullText, "name");
            string provinces = TextParser.GetContentsOfBrackets(fullText, "provinces").Trim();

            //State returnState = this;
            NameOfFile = nameOfTextFile;
            ID = stateId;
            Name = stateName;

            PlaceholderName = stateName;

            string[] provs = provinces.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> provIds = new List<int>();
            for (int i = 0; i < provs.Length; i++)
            {
                provIds.Add(int.Parse(provs[i]));
            }
            Provinces = provIds.ToArray();

            Resources = new Dictionary<string, int>();
            string resources = TextParser.GetContentsOfBracketsConcatenated(fullText, "resources", "; ").Trim();
            if (resources != "")
            {
                string[] resSplit = resources.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < resSplit.Length; i++)
                {
                    //Console.WriteLine(resSplit[i]);
                    string resName = resSplit[i].Split('=')[0].Trim();
                    int resValue = Convert.ToInt32(Convert.ToDecimal(resSplit[i].Split('=')[1].Trim()));
                    Resources.Add(resName,resValue);
                }
            }
            
            MainVariables.Add("manpower", TextParser.getVariable(fullText, "manpower").Replace("\"",""));
            MainVariables.Add("state_category", TextParser.getVariable(fullText, "state_category").Replace("\"",""));
            Category = BaseGameReader.StateCategoryLookup[MainVariables["state_category"]];

            StateHistory = new StateHistoryGroup();
            StateHistory.ReadStateHistory(fullText);
        }
    }
}
