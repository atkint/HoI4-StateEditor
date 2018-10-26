using HOI4_State_Editor.Readers;
using Paloma;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOI4_State_Editor
{
    public partial class NewCountryForm : Form
    {
        Dictionary<string, string> PoliticalPartyNames = new Dictionary<string, string>();
        Dictionary<string, string> CountryIdeologyNames = new Dictionary<string, string>();
        Dictionary<string, string> LeaderImagePathLookup = new Dictionary<string, string>();

        BaseGameReader baseGame;
        ModFileReader modFile;

        string NewCountryTag = "";

        public NewCountryForm()
        {
            InitializeComponent();
            baseGame = BaseGameReader.BaseGame;
            modFile = ModFileReader.ModFile;
            


            UpdateNewCountryTag(NewCountryTagBox.Text);
        }
        
        private void btnNeutralityFlag_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Targa File (*.tga)|*.tga";
            fd.ShowDialog(this);
            if (fd.FileName == "")
            {
                btnNeutralityFlag.BackColor = Color.LightPink;
                NewCountryFlagPicture.Image = null;
            }
            else
            {
                Bitmap newFlag = TargaImage.LoadTargaImage(fd.FileName);
                NewCountryFlagPicture.Image = newFlag;
                btnNeutralityFlag.BackColor = Color.LightGreen;
            }

            CreateNewCountryButton.Enabled = NewCountryFieldsCheck();
        }

        string getLocalisationOrDefault(string stringName)
        {
            if (baseGame.LocalisationLookup.ContainsKey(stringName))
                return baseGame.LocalisationLookup[stringName];
            else
                return stringName;
        }

        void SetFlagPicture(PictureBox pictureBox, string flagFilename)
        {
            // If there's a flag in the mod folder, use that first.
            if (File.Exists(baseGame.FlagFolder + flagFilename) || File.Exists(modFile.FlagFolder + flagFilename))
            {
                string fullFilePath = File.Exists(modFile.FlagFolder + flagFilename) ?
                    modFile.FlagFolder + flagFilename : baseGame.FlagFolder + flagFilename;
                pictureBox.Image = Paloma.TargaImage.LoadTargaImage(fullFilePath);
            }
            else
            {
                // If a specific ideological flag is not found then default to the base tag flag
                //Console.WriteLine(flagFilename+" NOT FOUND!");
                string newFileName = flagFilename.Substring(0, 3) + ".tga";
                //Console.WriteLine("New Path: "+newPath);
                if (File.Exists(baseGame.FlagFolder + newFileName) || File.Exists(modFile.FlagFolder + newFileName))
                {
                    string fullFilePath = File.Exists(modFile.FlagFolder + newFileName) ?
                        modFile.FlagFolder + newFileName : baseGame.FlagFolder + newFileName;

                    pictureBox.Image = Paloma.TargaImage.LoadTargaImage(fullFilePath);
                }
                else
                {
                    pictureBox.Image = null;
                }

            }
        }

        void SetEditFields()
        {

        }

        void UpdateNewCountryTag(string tag)
        {
            Console.WriteLine(baseGame + "/gfx/leaders/");
            foreach (string f in Directory.GetFiles(baseGame + "/gfx/"))
            {
                Console.WriteLine(f);
            }


            NewCountryTag = NewCountryTagBox.Text;

            PoliticalPartyNames = new Dictionary<string, string>();
            CountryIdeologyNames = new Dictionary<string, string>();

            SetFlagPicture(NewCountryFlagPicture,NewCountryTag+"_"+ CountryIdeologyLocalCombo.SelectedItem.ToString()+".tga");

            PoliticalPartyNames.Add("neutrality", getLocalisationOrDefault(tag + "_neutrality_party"));
            PoliticalPartyNames.Add("fascism", getLocalisationOrDefault(tag + "_fascism_party"));
            PoliticalPartyNames.Add("communism", getLocalisationOrDefault(tag + "_communism_party"));
            PoliticalPartyNames.Add("democratic", getLocalisationOrDefault(tag + "_democratic_party"));
            PartyNameTextBox.Text = PoliticalPartyNames[PartyIdeologyCombo.SelectedItem.ToString()];

            CountryIdeologyNames.Add("neutrality", getLocalisationOrDefault(tag + "_neutrality"));
            CountryIdeologyNames.Add("fascism", getLocalisationOrDefault(tag + "_fascism"));
            CountryIdeologyNames.Add("communism", getLocalisationOrDefault(tag + "_communism"));
            CountryIdeologyNames.Add("democratic", getLocalisationOrDefault(tag + "_democratic"));
            CountryIdeologyNames.Add("neutrality_ADJ", getLocalisationOrDefault(tag + "_neutrality_ADJ"));
            CountryIdeologyNames.Add("fascism_ADJ", getLocalisationOrDefault(tag + "_fascism_ADJ"));
            CountryIdeologyNames.Add("communism_ADJ", getLocalisationOrDefault(tag + "_communism_ADJ"));
            CountryIdeologyNames.Add("democratic_ADJ", getLocalisationOrDefault(tag + "_democratic_ADJ"));
            CountryIdeologyNames.Add("neutrality_DEF", getLocalisationOrDefault(tag + "_neutrality_DEF"));
            CountryIdeologyNames.Add("fascism_DEF", getLocalisationOrDefault(tag + "_fascism_DEF"));
            CountryIdeologyNames.Add("communism_DEF", getLocalisationOrDefault(tag + "_communism_DEF"));
            CountryIdeologyNames.Add("democratic_DEF", getLocalisationOrDefault(tag + "_democratic_DEF"));
            CountryLocalNameBox.Text = CountryIdeologyNames[CountryIdeologyLocalCombo.SelectedItem.ToString()];
            CountryLocalAdjectiveBox.Text = CountryIdeologyNames[CountryIdeologyLocalCombo.SelectedItem.ToString()+"_ADJ"];
            CountryLocalDefinitiveBox.Text = CountryIdeologyNames[CountryIdeologyLocalCombo.SelectedItem.ToString()+"_DEF"];

            CountryNameGroupBox.Enabled = (NewCountryTagBox.Text.Length == 3);
            PoliticsGroupBox.Enabled = (NewCountryTagBox.Text.Length == 3);
        }

        bool NewCountryFieldsCheck()
        {
            if (NewCountryTagBox.Text.Length != 3)
            {
                return false;
            }
            if (NewCountryFlagPicture.Image == null)
            {
                return false;
            }
            if (false)//NewCountryNeutralityNameBox.Text.Trim() == "" ||
                //NewCountryDemocraticNameBox.Text.Trim() == "" ||
                //NewCountryFascistNameBox.Text.Trim() == "" ||
                //NewCountryCommunistNameBox.Text.Trim() == "")
            {
                //return false;
            }
            return true;
        }

        private void NewCountryTagBox_TextChanged(object sender, EventArgs e)
        {
            UpdateNewCountryTag(NewCountryTagBox.Text);

            CreateNewCountryButton.Enabled = NewCountryFieldsCheck();
        }

        private void CreateNewCountryButton_Click(object sender, EventArgs e)
        {
            CreateNewCountryButton.Enabled = NewCountryFieldsCheck();
        }

        private void NewCountryNeutralityNameBox_TextChanged(object sender, EventArgs e)
        {
            CreateNewCountryButton.Enabled = NewCountryFieldsCheck();
        }

        private void NewCountryDemocraticNameBox_TextChanged(object sender, EventArgs e)
        {
            CreateNewCountryButton.Enabled = NewCountryFieldsCheck();
        }

        private void NewCountryFascistNameBox_TextChanged(object sender, EventArgs e)
        {
            CreateNewCountryButton.Enabled = NewCountryFieldsCheck();
        }

        private void NewCountryCommunistNameBox_TextChanged(object sender, EventArgs e)
        {
            CreateNewCountryButton.Enabled = NewCountryFieldsCheck();
        }

        private void PartyNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PartyIdeologyCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            PartyNameTextBox.Text = PoliticalPartyNames[PartyIdeologyCombo.SelectedItem.ToString()];
            
        }

        private void CountryIdeologyLocalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CountryLocalNameBox.Text = CountryIdeologyNames[CountryIdeologyLocalCombo.SelectedItem.ToString()];
            CountryLocalAdjectiveBox.Text = CountryIdeologyNames[CountryIdeologyLocalCombo.SelectedItem.ToString() + "_ADJ"];
            CountryLocalDefinitiveBox.Text = CountryIdeologyNames[CountryIdeologyLocalCombo.SelectedItem.ToString() + "_DEF"];
            SetFlagPicture(NewCountryFlagPicture, NewCountryTag + "_" + CountryIdeologyLocalCombo.SelectedItem.ToString() + ".tga");
        }
    }
}
