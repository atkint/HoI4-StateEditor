using HOI4_State_Editor.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOI4_State_Editor.Data
{
    public class BuildingsGroup
    {
        /// <summary>
        /// Types: infrastructure, industrial_complex, arms_factory, dockyard, synthetic_refinery, air_base, anti_air_building, radar_station, rocket_site, nuclear_reactor
        /// </summary>
        public Dictionary<string, int> StateBuildings;
        /// <summary>
        /// Types: bunker, coastal_bunker, naval_base
        /// </summary>
        public Dictionary<int, Dictionary<string, int>> ProvinceBuildings;

        public BuildingsGroup()
        {
            StateBuildings = new Dictionary<string, int>();
            ProvinceBuildings = new Dictionary<int, Dictionary<string, int>>();
        }

        public void ReadBuildingsContents(string buildingsText)
        {
            List<ProvinceBuilding> buildingList = new List<ProvinceBuilding>();

            string[] buildingLines = buildingsText.Split('\n');
            for (int i = 0; i < buildingLines.Length; i++)
            {
                string[] lineSplit = buildingLines[i].Split('=');

                if (lineSplit.Length < 2)
                {
                    continue;
                }

                string name = lineSplit[0].Trim();
                int provId;
                if (int.TryParse(name, out provId))
                {
                    if (!ProvinceBuildings.ContainsKey(provId))
                    {
                        ProvinceBuildings.Add(provId, new Dictionary<string, int>());
                    }

                    string provBuildings = TextParser.GetContentsOfAllGroupsWithName(buildingsText, provId.ToString());

                    foreach (string pLine in provBuildings.Split('\n'))
                    {
                        if (pLine.Contains("="))
                        {
                            ProvinceBuilding newBuild = TextParser.CreateProvinceBuilding(pLine);
                            string[] ls = pLine.Split('=');
                            if (ls.Length > 1)
                            {
                                string buildingType = ls[0].Trim();
                                int value = int.Parse(ls[1].Trim());

                                if (ProvinceBuildings[provId].ContainsKey(buildingType))
                                {
                                    //Console.WriteLine(provId.ToString() + "(" + Name + "): " + name + "Duplicate");
                                }
                                else
                                {
                                    ProvinceBuildings[provId].Add(buildingType, value);
                                }

                            }

                            buildingList.Add(newBuild);
                        }

                    }
                }
                else if (name != "naval_base" && name != "coastal_bunker" && name != "bunker")
                {
                    string buildingVal = lineSplit[1].Trim();
                    //Console.WriteLine(name + ": " + buildingVal);
                    StateBuildings.Add(name, int.Parse(buildingVal));
                }
            }
        }
    }
}
