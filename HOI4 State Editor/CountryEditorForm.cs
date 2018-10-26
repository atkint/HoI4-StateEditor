using HOI4_State_Editor.Data;
using HOI4_State_Editor.Readers;
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
using KUtility;
using System.Drawing.Imaging;


namespace HOI4_State_Editor
{
    public partial class CountryEditorForm : Form
    {
        public ModFileReader modFile;
        public BaseGameReader baseGame;
        
        Country selectedCountry;

        public CountryEditorForm()
        {
            InitializeComponent();
        }

        private void CountryEditorForm_Load(object sender, EventArgs e)
        {
            foreach (string tag in CountryIndexer.CountryTagLookup.Keys)
            {
                CountryList.Items.Add(CountryIndexer.CountryTagLookup[tag]);
            }

            CountryList.SelectedIndex = 0;
            GFXLookup.Initialise(baseGame.BaseFolder+"gfx/");
            LeaderTypeDropdown.SelectedIndex = 0;
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
                string newFileName = flagFilename.Substring(0, 3)+".tga";
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

        void UpdateCountryNameFields(string tag)
        {
            string prefix = tag + "_" + CountryIdeologyLocalCombo.SelectedItem.ToString();
            CountryLocalAdjectiveBox.Text = baseGame.LocalisationLookup.ContainsKey(prefix + "_ADJ") ? baseGame.LocalisationLookup[prefix + "_ADJ"] : "";
            CountryLocalDefinitiveBox.Text = baseGame.LocalisationLookup.ContainsKey(prefix + "_DEF") ? baseGame.LocalisationLookup[prefix + "_DEF"] : "";
            CountryLocalNameBox.Text = baseGame.LocalisationLookup.ContainsKey(prefix) ? baseGame.LocalisationLookup[prefix] : "";
        }

        private void CountryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCountry = (Country)CountryList.SelectedItem;
            
            if (selectedCountry != null)
            {
                string tag = selectedCountry.Tag;

                UpdateFieldEditability(selectedCountry);

                UpdateCountryNameFields(tag);

                lblCountryTag.Text = tag + ": " + selectedCountry.Name;

                SetFlagPicture(NeutralFlagPicture, tag + "_neutrality.tga");
                SetFlagPicture(DemocracyFlagPicture, tag + "_democratic.tga");
                SetFlagPicture(FascistFlagPicture, tag + "_fascism.tga");
                SetFlagPicture(CommunistFlagPicture, tag + "_communism.tga");
                CountryColourBox.BackColor = selectedCountry.MainColour;

                DemocracyNameLabel.Text = baseGame.LocalisationLookup[tag + "_democratic"];
                NeutralNameLabel.Text = baseGame.LocalisationLookup[tag + "_neutrality"];
                FascistNameLabel.Text = baseGame.LocalisationLookup[tag + "_fascism"];
                CommunistNameLabel.Text = baseGame.LocalisationLookup[tag+ "_communism"];

                foreach (string key in selectedCountry.Politics.IdeologyPopularity.Keys)
                {
                    //Console.WriteLine(key +": "+selectedCountry.Politics.IdeologyPopularity[key]);
                }

                CountryPoliticsBox.Text = selectedCountry.Politics.ToString();
                CountryPoliticsBox.Text += "\n\nCountry Leaders:\n";
                foreach(Leader l in selectedCountry.Leaders)
                {
                    CountryPoliticsBox.Text += l.Name + " (" + l.Ideology + ")\n";
                }
                

                CountryPoliticsBox.Text += "\n\nField Marshals:\n";
                foreach (Commander c in selectedCountry.FieldMarshals)
                {
                    CountryPoliticsBox.Text += c.Name + " (" + c.Skill.ToString() + ")\n";
                }

                CountryPoliticsBox.Text += "\n\nCorps Commanders:\n";
                foreach (Commander c in selectedCountry.CorpsCommanders)
                {
                    CountryPoliticsBox.Text += c.Name + " (" + c.Skill.ToString() + ")\n";
                }

                CountryPoliticsBox.Text += "\n\nNaval Commanders:\n";
                foreach (Commander c in selectedCountry.NavalCommanders)
                {
                    CountryPoliticsBox.Text += c.Name + " (" + c.Skill.ToString() + ")\n";
                }

                // Set politics
                Politics p = selectedCountry.Politics;
                string selectedIdeology = EditPartyIdeologyCombo.SelectedItem.ToString();
                EditPartyNameTextBox.Text = baseGame.LocalisationLookup.ContainsKey(selectedCountry.Tag + "_" + selectedIdeology + "_party") ?
                    baseGame.LocalisationLookup[selectedCountry.Tag + "_" + selectedIdeology + "_party"] : "UNNAMED";
                EditPartyPopularityNumeric.Value = p.IdeologyPopularity.ContainsKey(selectedIdeology) ? p.IdeologyPopularity[selectedIdeology] : 0;
                lblNeutralityPopularity.Text = p.IdeologyPopularity.ContainsKey("neutrality") ? "neutrality: " + p.IdeologyPopularity["neutrality"].ToString() : "neutrality: 0";
                lblDemocraticPopularity.Text = p.IdeologyPopularity.ContainsKey("democratic") ? "democratic: " + p.IdeologyPopularity["democratic"].ToString() : "democratic: 0";
                lblFascismPopularity.Text = p.IdeologyPopularity.ContainsKey("fascism") ? "fascism: " + p.IdeologyPopularity["fascism"].ToString() : "fascism: 0";
                lblCommunismPopularity.Text = p.IdeologyPopularity.ContainsKey("communism") ? "communism: " + p.IdeologyPopularity["communism"].ToString() : "communism: 0";

                EditCountryRulingPartyCombo.SelectedIndex = selectedCountry.Politics.GetRulingPartyIndex();
                EditCountryElectionDatePicker.Value = selectedCountry.Politics.GetLastElectionDate();
                EditCountryElectionFrequencyNumeric.Value = selectedCountry.Politics.ElectionFrequency > 0 ? selectedCountry.Politics.ElectionFrequency : 48;
                EditCountryElectionsBannedCheck.Checked = selectedCountry.Politics.GetElectionsAllowed();

                if (LeaderTypeDropdown.SelectedIndex == 0)
                {
                    UpdateCountryLeadersListBox(selectedCountry);
                }
                else
                {
                    UpdateCountryCommandersListBox(selectedCountry);
                }
            }
            else
            {
                UpdateCountryNameFields("");
            }
        }

        void ResetLeaderValues()
        {
            LeaderNameLabel.Text = "[None Selected]";
            LeaderTypeLabel.Text = "-----";
            LeaderPicture.Image = null;
            LeaderPicturePathLabel.Text = "";
            LeaderSkillLabel.Visible = false;
            attackPicture.Visible = false;
            LeaderAttackLabel.Visible = false;
            defencePicture.Visible = false;
            LeaderDefenceLabel.Visible = false;
            planningPicture.Visible = false;
            LeaderPlanningLabel.Visible = false;
            supplyPicture.Visible = false;
            LeaderSupplyLabel.Visible = false;

            LeaderTraitListBox.Items.Clear();
        }

        void UpdateCountryCommandersListBox(Country selectedCountry)
        {
            CountryLeaderListBox.Items.Clear();

            if (LeaderTypeDropdown.SelectedIndex == 1)
            {
                for (int i = 0; i < selectedCountry.FieldMarshals.Count; i++)
                {
                    Commander commander = selectedCountry.FieldMarshals[i];
                    CountryLeaderListBox.Items.Add(commander);
                }

                for (int i = 0; i < selectedCountry.CorpsCommanders.Count; i++)
                {
                    Commander commander = selectedCountry.CorpsCommanders[i];
                    CountryLeaderListBox.Items.Add(commander);
                }
            }
            else if (LeaderTypeDropdown.SelectedIndex == 2)
            {
                for (int i = 0; i < selectedCountry.NavalCommanders.Count; i++)
                {
                    Commander commander = selectedCountry.NavalCommanders[i];
                    CountryLeaderListBox.Items.Add(commander);
                }
            }
            

            ResetLeaderValues();

            if (CountryLeaderListBox.Items.Count > 0)
            {
                CountryLeaderListBox.SelectedIndex = 0;
            }
        }

        void UpdateCountryLeadersListBox(Country selectedCountry)
        {
            CountryLeaderListBox.Items.Clear();

            for (int i = 0; i < selectedCountry.Leaders.Count; i++)
            {
                Leader leader = selectedCountry.Leaders[i];
                CountryLeaderListBox.Items.Add(leader);
            }

            ResetLeaderValues();

            if (CountryLeaderListBox.Items.Count > 0)
            {
                CountryLeaderListBox.SelectedIndex = 0;
            }
        }

        private void CountrySeachBox_TextChanged(object sender, EventArgs e)
        {
            CountryList.Items.Clear();
            foreach(string tag in CountryIndexer.CountryTagLookup.Keys)
            {
                if (tag.Contains(CountrySeachBox.Text))
                {
                    CountryList.Items.Add(CountryIndexer.CountryTagLookup[tag]);
                }
            }
        }

        private void CountryIdeologyLocalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Country selectedCountry = (Country)CountryList.SelectedItem;

            if (selectedCountry != null)
                UpdateCountryNameFields(selectedCountry.Tag);
            else
                UpdateCountryNameFields("");
        }

        private void EditPartyIdeologyCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Country selectedCountry = (Country)CountryList.SelectedItem;
            Politics p = selectedCountry.Politics;
            string selectedIdeology = EditPartyIdeologyCombo.SelectedItem.ToString();

            EditPartyNameTextBox.Text = baseGame.LocalisationLookup.ContainsKey(selectedCountry.Tag + "_" + selectedIdeology + "_party") ?
                        baseGame.LocalisationLookup[selectedCountry.Tag + "_" + selectedIdeology + "_party"] : "UNNAMED";
            if (p.IdeologyPopularity.ContainsKey(selectedIdeology))
            {
                //Console.WriteLine("Pop: "+ p.IdeologyPopularity[selectedIdeology].ToString());

            }
            EditPartyPopularityNumeric.Value = p.IdeologyPopularity.ContainsKey(selectedIdeology) ? p.IdeologyPopularity[selectedIdeology] : 0;
        }

        void UpdateFieldEditability(Country selectedCountry)
        {
            bool checkBoxValue = EditFieldsCheckBox.Checked;

            CountryLocalAdjectiveBox.Enabled = checkBoxValue;
            CountryLocalDefinitiveBox.Enabled = checkBoxValue;
            CountryLocalNameBox.Enabled = checkBoxValue;

            EditCountryElectionDatePicker.Enabled = checkBoxValue;
            EditCountryElectionFrequencyNumeric.Enabled = checkBoxValue;
            EditCountryElectionsBannedCheck.Enabled = checkBoxValue;
            EditCountryRulingPartyCombo.Enabled = checkBoxValue;
            EditPartyPopularityNumeric.Enabled = checkBoxValue;
            EditPartyNameTextBox.Enabled = checkBoxValue;
        }

        private void EditFieldsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFieldEditability((Country)CountryList.SelectedItem);
        }

        void AttemptToSetCommanderPortrait(Commander selectedCommander)
        {
            string picturePath = selectedCommander.Picture;
            picturePath = picturePath.Replace("\\", "/");
            picturePath = picturePath.Replace("//", "/");
            picturePath = picturePath.ToUpper();
            if (!picturePath.Contains(".DDS"))
            {
                picturePath += ".DDS";
            }
            string[] pathSplit = picturePath.Split('/');
            //Console.WriteLine(selectedCommander.Picture);
            //Console.WriteLine(picturePath);

            if (GFXLookup.LeaderImageLookup.ContainsKey(pathSplit[pathSplit.Length - 1]))
            {
                string finalPictureName = GFXLookup.LeaderImageLookup[pathSplit[pathSplit.Length - 1]];
                //Console.WriteLine(finalPictureName);

                if (File.Exists(finalPictureName))
                {
                    try
                    {
                        DDSImage img = new DDSImage(File.ReadAllBytes(finalPictureName));

                        //img.images[0].Save(Application.ExecutablePath+"/test.png", ImageFormat.Png);
                        //Console.WriteLine("Count: " + img.images.Length.ToString());
                        LeaderPicture.Image = img.images[0];

                    }
                    catch
                    {
                        LeaderPicture.Image = null;
                    }
                }
            }
            else
            {
                LeaderPicture.Image = null;
            }
        }

        void AttemptToSetLeaderPortrait(Leader selectedLeader)
        {
            string picturePath = selectedLeader.Picture;
            picturePath = picturePath.Replace("\\", "/");
            picturePath = picturePath.Replace("//", "/");
            picturePath = picturePath.ToUpper();
            if (!picturePath.Contains(".DDS"))
            {
                picturePath += ".DDS";
            }
            string[] pathSplit = picturePath.Split('/');
            Console.WriteLine(selectedLeader.Picture);
            Console.WriteLine(picturePath);

            if (GFXLookup.LeaderImageLookup.ContainsKey(pathSplit[pathSplit.Length - 1]))
            {
                string finalPictureName = GFXLookup.LeaderImageLookup[pathSplit[pathSplit.Length - 1]];
                Console.WriteLine(finalPictureName);

                if (File.Exists(finalPictureName))
                {
                    try
                    {
                        DDSImage img = new DDSImage(File.ReadAllBytes(finalPictureName));

                        //img.images[0].Save(Application.ExecutablePath+"/test.png", ImageFormat.Png);
                        //Console.WriteLine("Count: " + img.images.Length.ToString());
                        LeaderPicture.Image = img.images[0];

                    }
                    catch
                    {
                        LeaderPicture.Image = null;
                    }
                }
            }
            else
            {
                LeaderPicture.Image = null;
            }
        }

        private void CountryLeaderListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetLeaderValues();
            if (LeaderTypeDropdown.SelectedIndex == 0)
            {
                Leader selectedLeader = (Leader)CountryLeaderListBox.SelectedItem;

                if (selectedLeader != null)
                {
                    LeaderNameLabel.Text = selectedLeader.Name;
                    LeaderTypeLabel.Text = "Leader";
                    LeaderPicturePathLabel.Text = selectedLeader.Picture;
                    LeaderSkillLabel.Visible = false;
                    for (int i = 0; i < selectedLeader.Traits.Count; i++)
                    {
                        LeaderTraitListBox.Items.Add(selectedLeader.Traits[i]);
                    }

                    AttemptToSetLeaderPortrait(selectedLeader);
                }
            }
            else if(LeaderTypeDropdown.SelectedIndex == 1)
            {
                Commander selectedCommander = (Commander)CountryLeaderListBox.SelectedItem;

                if (selectedCommander != null)
                {
                    LeaderNameLabel.Text = selectedCommander.Name;
                    LeaderTypeLabel.Text = selectedCommander.CommanderType == COMMANDER_TYPE.CORPS_COMMANDER? "Corps Commander" : "Field Marshal";
                    LeaderPicturePathLabel.Text = selectedCommander.Picture;
                    LeaderSkillLabel.Visible = true;
                    LeaderSkillLabel.Text = "Skill: "+selectedCommander.Skill.ToString();

                    attackPicture.Visible = true;
                    LeaderAttackLabel.Visible = true;
                    LeaderAttackLabel.Text = selectedCommander.AttackSkill.ToString();
                    defencePicture.Visible = true;
                    LeaderDefenceLabel.Visible = true;
                    LeaderDefenceLabel.Text = selectedCommander.DefendSkill.ToString();
                    planningPicture.Visible = true;
                    LeaderPlanningLabel.Visible = true;
                    LeaderPlanningLabel.Text = selectedCommander.PlanningSkill.ToString();
                    supplyPicture.Visible = true;
                    LeaderSupplyLabel.Visible = true;
                    LeaderSupplyLabel.Text = selectedCommander.SupplySkill.ToString();

                    for (int i = 0; i < selectedCommander.Traits.Count; i++)
                    {
                        LeaderTraitListBox.Items.Add(selectedCommander.Traits[i]);
                    }

                    AttemptToSetCommanderPortrait(selectedCommander);
                }
            }
        }

        private void LeaderTypeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LeaderTypeDropdown.SelectedIndex == 0)
            {
                UpdateCountryLeadersListBox(selectedCountry);
            }
            else
            {
                UpdateCountryCommandersListBox(selectedCountry);
            }
        }
    }
}
