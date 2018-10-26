using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOI4_State_Editor.Readers
{
    public class ModFileReader
    {
        public string Name;
        public static string FolderPath;
        public static string StatesPath;
        
        public string FlagFolder;
        public string CommonFolder;
        public string LocalisationFolder;
        public string RootFolder;

        public static ModFileReader ModFile;

        public ModFileReader(string filePath, string mainModFolder)
        {
            ModFile = this;

            StreamReader sr = new StreamReader(filePath);
            string[] fullText = sr.ReadToEnd().Split('\n');
            sr.Close();
            foreach(string line in fullText)
            {
                if (line.Trim().StartsWith("name"))
                {
                    Name = line.Split('=')[1].Trim();
                }
                else if (line.Trim().StartsWith("path"))
                {
                    FolderPath = mainModFolder+line.Split('=')[1].Trim().Replace("mod/","").Replace("\"","");
                }
            }
            FlagFolder = FolderPath + "gfx/flags/";
            StatesPath = FolderPath + "history/states/";
            CommonFolder = FolderPath + "common/";
            LocalisationFolder = FolderPath + "localisation/";
            RootFolder = FolderPath;


            CheckFolder(FlagFolder);
            CheckFolder(StatesPath);
            CheckFolder(CommonFolder);
            CheckFolder(LocalisationFolder);
            CheckFolder(FolderPath + "map/strategicregions");
            CheckFolder(CommonFolder + "country_tags/");
            CheckFolder(FolderPath + "history/countries/");

            foreach (string file in Directory.GetFiles(LocalisationFolder))
            {
                BaseGameReader.BaseGame.ReadLocalisationFile(file);
            }
        }

        void CheckFolder(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show(folderPath + "\nDoesn't exist. It's been created");
                Directory.CreateDirectory(folderPath);
            }
        }
    }
}
