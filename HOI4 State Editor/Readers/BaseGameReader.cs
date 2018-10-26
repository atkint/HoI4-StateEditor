using HOI4_State_Editor.Data;
using HOI4_State_Editor.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOI4_State_Editor.Readers
{
    public class BaseGameReader
    {
        public string BaseFolder;
        public string MapFolder;
        public string CommonFolder;
        public string FlagFolder;

        public static BaseGameReader BaseGame;

        public Dictionary<string, Continent> ContinentLookup;
        public Dictionary<string, string> LocalisationLookup;
        public Dictionary<int, Province> ProvinceLookup;
        public static Dictionary<string, StateCategory> StateCategoryLookup;

        public Dictionary<string, Country> CountryTagLookup;

        public BaseGameReader(string exePath)
        {
            BaseFolder = exePath.Replace("hoi4.exe", "");
            MapFolder = BaseFolder + "map\\";
            CommonFolder = BaseFolder + "common\\";
            FlagFolder = BaseFolder + "gfx\\flags\\";

            BaseGame = this;

            LocalisationLookup = new Dictionary<string, string>();
            string localisationFolder = BaseFolder + "localisation\\";
            ReadLocalisationFile(localisationFolder + "strategic_region_names_l_english.yml");
            ReadLocalisationFile(localisationFolder + "state_names_l_english.yml");
            ReadLocalisationFile(localisationFolder + "countries_l_english.yml");
            ReadLocalisationFile(localisationFolder + "parties_l_english.yml");

            StateCategoryLookup = new Dictionary<string, StateCategory>();
            foreach(string file in Directory.GetFiles(BaseFolder+"common/state_category/"))
            {
                StateCategory newStateCategory = TextParser.CreateStateCategory(file);
                StateCategoryLookup.Add(newStateCategory.Tag, newStateCategory);
                Console.WriteLine(newStateCategory.Tag + ": " + newStateCategory.BuildingSlots.ToString());
            }

            ReadProvinceFile();
        }

        void ReadProvinceFile()
        {
            string filename = MapFolder + "definition.csv";
            ProvinceLookup = new Dictionary<int, Province>();

            StreamReader sr = new StreamReader(filename);
            while (!sr.EndOfStream)
            {
                string[] splitLine = sr.ReadLine().Split(';');
                if (splitLine.Length > 6)
                {
                    int id = int.Parse(splitLine[0]);
                    bool isWater = splitLine[4] != "land"; // If it is not land, then it is lake or sea
                    Province newProv = new Province(id,isWater);
                    ProvinceLookup.Add(id, newProv);
                }
            }
            sr.Close();
        }

        public void ReadLocalisationFile(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] lineSplit = line.Split(':');
                if (lineSplit.Length > 1)
                {
                    string placeholder = lineSplit[0].Trim();
                    int startSpeechPos = line.IndexOf('"');
                    int lastSpeechPos = line.LastIndexOf('"');
                    string fullName = line.Substring(startSpeechPos, lastSpeechPos - startSpeechPos).Replace("\"", "");
                    //Console.WriteLine(placeholder);
                    if (!LocalisationLookup.ContainsKey(placeholder))
                    {
                        LocalisationLookup.Add(placeholder, fullName);
                    }
                    
                }
                
            }
            sr.Close();
        }
    }
}
