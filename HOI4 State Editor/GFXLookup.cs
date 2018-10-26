using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOI4_State_Editor
{
    static class GFXLookup
    {
        static Dictionary<string, string> TraitsLookup = new Dictionary<string, string>();
        public static Dictionary<string, string> LeaderImageLookup = new Dictionary<string, string>();

        static string GFXPath;

        public static string GetTraitPath(string traitName)
        {
            if (TraitsLookup.ContainsKey(traitName))
            {
                return TraitsLookup[traitName];
            }
            else
            {
                return null;
            }
        }

        static void loadLeaderImages()
        {
            foreach (string dir in Directory.GetDirectories(GFXPath+"leaders/"))
            {
                ReadImageDirectory(dir,LeaderImageLookup);
            }
        }

        static void ReadImageDirectory(string dir,Dictionary<string,string> dictionaryValue)
        {
            foreach (string file in Directory.GetFiles(dir))
            {
                string cleanFileName = file.Replace("\\", "/").Trim();
                string[] filenameSplit = cleanFileName.Split('/');
                string justName = filenameSplit[filenameSplit.Length - 1].ToUpper();

                if (!dictionaryValue.ContainsKey(justName))
                {
                    dictionaryValue.Add(justName, cleanFileName);
                }
                else
                {
                    //Console.WriteLine("[" + justName + "] " + cleanFileName);
                }
            }
        }


        static void loadTraits()
        {
            foreach (string file in Directory.GetFiles(GFXPath+ "interface/traits/"))
            {
                Console.WriteLine(file);
                string[] fileSplit = file.Split('/');
                string lookupName = fileSplit[fileSplit.Length - 1].Replace(".dds", "");
                TraitsLookup.Add(lookupName,file);
            }
            foreach (string file in Directory.GetFiles(GFXPath+"interface/traits/personal/"))
            {
                Console.WriteLine(file);
                string[] fileSplit = file.Split('/');
                string lookupName = fileSplit[fileSplit.Length - 1].Replace(".dds","");
                TraitsLookup.Add(lookupName, file);
            }
        }

        public static void Initialise(string gfxPath)
        {
            string cleanFileName = gfxPath.Replace("\\", "/").Trim();
            GFXPath = gfxPath;

            loadTraits();
            loadLeaderImages();
        }
    }
}
