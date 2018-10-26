using HOI4_State_Editor.Data;
using HOI4_State_Editor.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOI4_State_Editor.Readers
{
    public class CountryIndexer
    {
        public static Dictionary<string, Country> CountryTagLookup;

        static void ReadCountryHistory(Country country, string filename)
        {
            StreamReader sr = new StreamReader(filename);

            string[] pathSplit = filename.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            string CountryName = pathSplit[pathSplit.Length-1].Split('-')[1].Replace(".txt","").Trim();
            //Console.WriteLine(CountryName);
            country.Name = CountryName;

            string fullText = sr.ReadToEnd();
            int capitalId = Convert.ToInt16(TextParser.getVariable(fullText, "capital").Trim());
            country.Capital = capitalId;
            country.History = fullText;
            string politics = TextParser.GetContentsOfBrackets(fullText, "set_politics");
            country.Politics.ReadPolitics(country.Tag, politics);

            int leaderIndex = fullText.IndexOf("create_country_leader");
            while (leaderIndex != -1)
            {
                if (fullText[leaderIndex-1] != '#')
                {
                    Leader newLeader = new Leader();
                    newLeader.ReadLeaderText(TextParser.GetContentsOfBrackets(fullText.Substring(leaderIndex), "create_country_leader"));
                    country.Leaders.Add(newLeader);
                    //Console.WriteLine(country.Tag + ": " + newLeader.Name);
                }
                leaderIndex = fullText.IndexOf("create_country_leader", leaderIndex + 1);
            }

            leaderIndex = fullText.IndexOf("create_corps_commander");
            while (leaderIndex != -1)
            {
                if (fullText[leaderIndex - 1] != '#')
                {
                    Commander newLeader = new Commander();
                    newLeader.ReadCommanderText(TextParser.GetContentsOfBrackets(fullText.Substring(leaderIndex), "create_corps_commander"), COMMANDER_TYPE.CORPS_COMMANDER);
                    country.CorpsCommanders.Add(newLeader);
                    //Console.WriteLine(country.Tag + ": " + newLeader.Name);
                }
                leaderIndex = fullText.IndexOf("create_corps_commander", leaderIndex + 1);
            }

            leaderIndex = fullText.IndexOf("create_field_marshal");
            while (leaderIndex != -1)
            {
                if (fullText[leaderIndex - 1] != '#')
                {
                    Commander newLeader = new Commander();
                    newLeader.ReadCommanderText(TextParser.GetContentsOfBrackets(fullText.Substring(leaderIndex), "create_field_marshal"),COMMANDER_TYPE.FIELD_MARSHAL);
                    country.FieldMarshals.Add(newLeader);
                    //Console.WriteLine(country.Tag + ": " + newLeader.Name);
                }
                leaderIndex = fullText.IndexOf("create_field_marshal", leaderIndex + 1);
            }

            leaderIndex = fullText.IndexOf("create_navy_leader");
            while (leaderIndex != -1)
            {
                if (fullText[leaderIndex - 1] != '#')
                {
                    Commander newLeader = new Commander();
                    newLeader.ReadCommanderText(TextParser.GetContentsOfBrackets(fullText.Substring(leaderIndex), "create_navy_leader"),COMMANDER_TYPE.NAVAL_COMMANDER);
                    country.NavalCommanders.Add(newLeader);
                    //Console.WriteLine(country.Tag + ": " + newLeader.Name);
                }
                leaderIndex = fullText.IndexOf("create_navy_leader", leaderIndex + 1);
            }

            //Console.WriteLine(country.Tag + ": " + capitalId.ToString());
            sr.Close();
        }

        static void ReadCountryTagsFile(string filename, bool newCountry)
        {
            string flagFolder = BaseGameReader.BaseGame.BaseFolder + "gfx\\flags\\";
            
            string baseCountryHistoryFolder = BaseGameReader.BaseGame.BaseFolder + "/history/countries/";
            string modcountryHistoryFolder = ModFileReader.FolderPath + "/history/countries/";
            StreamReader sr = new StreamReader(filename);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] splitLine = line.Split('=');
                
                if (splitLine.Length > 1)
                {
                    //Console.WriteLine(line);
                    string tag = splitLine[0].Trim();
                    string file = splitLine[1].Trim();
                    Country country = new Country(tag, BaseGameReader.BaseGame.LocalisationLookup[tag + "_neutrality"], newCountry);
                    country.MainColour = Color.Black;
                    CountryTagLookup.Add(tag, country);

                    string[] modHistoryFilesFound = Directory.GetFiles(modcountryHistoryFolder, tag + " -*");
                    string[] baseHistoryFilesFound = Directory.GetFiles(baseCountryHistoryFolder, tag + " -*");
                    //Console.WriteLine(historyFile);
                    if (modHistoryFilesFound.Length > 0)
                    {
                        ReadCountryHistory(country, modHistoryFilesFound[0]);
                    }
                    else if (baseHistoryFilesFound.Length > 0)
                    {
                        ReadCountryHistory(country, baseHistoryFilesFound[0]);
                    }
                }
            }
            sr.Close();
        }

        public static void LoadCountries()
        {
            CountryTagLookup = new Dictionary<string, Country>();

            foreach (string filename in Directory.GetFiles(ModFileReader.ModFile.CommonFolder+"country_tags/"))
            {
                Console.WriteLine(filename);
                ReadCountryTagsFile(filename,true);
            }

            string countryTagsFile = BaseGameReader.BaseGame.CommonFolder + "country_tags\\00_countries.txt";
            ReadCountryTagsFile(countryTagsFile,false);

            StreamReader sr;
            if (File.Exists(ModFileReader.ModFile.CommonFolder+ "countries\\colors.txt"))
            {
                sr = new StreamReader(ModFileReader.ModFile.CommonFolder + "countries\\colors.txt");
            }
            else
            {
                sr = new StreamReader(BaseGameReader.BaseGame.CommonFolder + "countries\\colors.txt");
            }
            
            string fullText = sr.ReadToEnd();
            string[] lines = fullText.Split('\n');
            foreach(string line in lines)
            {
                string cleanLine = (line.IndexOf("#") >= 0 ? line.Remove(line.IndexOf("#")) : line).Trim();
                if (cleanLine.Contains("=") && !cleanLine.StartsWith("color"))
                {
                    string tag = cleanLine.Split('=')[0].Trim();
                    int locationOfTag = fullText.IndexOf(tag);
                    string contentsOfBrackets = TextParser.GetContentsOfBrackets(fullText,tag).Trim();
                    //Console.WriteLine(tag+": "+contentsOfBrackets);
                    string colorText = contentsOfBrackets.Split('\n')[0].Split('=')[1].Trim();
                    string colorVals = colorText.Remove(colorText.IndexOf('}'));
                    colorVals = colorVals.Substring(colorVals.IndexOf('{') + 1).Trim();
                    string[] splitVals = colorVals.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    //Console.WriteLine(tag+": "+ colorText);
                    if (colorText.ToUpper().Contains("RGB") && CountryTagLookup.ContainsKey(tag))
                    {
                        Color countryColour = Color.FromArgb(
                        int.Parse(splitVals[0].Trim()),
                        int.Parse(splitVals[1].Trim()),
                        int.Parse(splitVals[2].Trim()));
                        CountryIndexer.CountryTagLookup[tag].MainColour = countryColour;
                    }
                    else if (colorText.ToUpper().Contains("HSV") && CountryTagLookup.ContainsKey(tag))
                    {
                        Color countryColour = ColourHelper.ColorFromHSV(
                        Convert.ToDouble(splitVals[0].Trim()),
                        Convert.ToDouble(splitVals[1].Trim()),
                        Convert.ToDouble(splitVals[2].Trim()));
                        CountryIndexer.CountryTagLookup[tag].MainColour = countryColour;
                    }
                }
            }
            sr.Close();

            
        }
    }
}
