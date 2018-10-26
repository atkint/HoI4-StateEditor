using HOI4_State_Editor.Data;
using HOI4_State_Editor.Exporters;
using HOI4_State_Editor.Readers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace HOI4_State_Editor
{
    public partial class StateEditorForm : Form
    {
        ModFileReader modFile;
        BaseGameReader baseGame;
        StateIndexer stateIndexer;

        State selectedState;

        public StateEditorForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Properties.Settings.Default.HOI4Path))
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.FileName = "hoi4.exe";
                openFile.Filter = "Hearts of Iron 4 Executable|hoi4.exe";
                openFile.ShowDialog();

                if (!File.Exists(openFile.FileName))
                {
                    MessageBox.Show("You need to select a valid hoi4.exe before continuing.");
                    Application.Exit();
                }
                Properties.Settings.Default.HOI4Path = openFile.FileName;
                Properties.Settings.Default.Save();
            }
            
            baseGame = new BaseGameReader(Properties.Settings.Default.HOI4Path);
            lblHOI4Path.Text = baseGame.BaseFolder;
            lblHOI4Path.ForeColor = Color.Black;

            if (File.Exists(Properties.Settings.Default.ModFilePath) && Directory.Exists(Properties.Settings.Default.DefaultModFolder))
            {
                initialSetup();
                //showCountryForm();
            }
            else
            {
                getModFolder();
                //showCountryForm();
            }
        }

        void showCountryForm()
        {
            CountryEditorForm countriesForm = new CountryEditorForm();
            countriesForm.baseGame = baseGame;
            countriesForm.modFile = modFile;
            countriesForm.Show(this);
            //NewCountryForm newCountryForm = new NewCountryForm();
            //newCountryForm.Show(countriesForm);
            Hide();
        }

        void getModFolder()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "HOI4 Mod File|*.mod";
            //openFile.FileName = Properties.Settings.Default.ModFilePath;
            DialogResult result = openFile.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                MessageBox.Show("No mod has been selected. The program will now quit.");
                Application.Exit();
            }
            else if (File.Exists(openFile.FileName))
            {
                Properties.Settings.Default.ModFilePath = openFile.FileName;
                
                string fileNameToRemove = openFile.FileName.Split('\\')[openFile.FileName.Split('\\').Length - 1];
                string justDefaultFolder = openFile.FileName.Replace(fileNameToRemove,"");

                Properties.Settings.Default.DefaultModFolder = justDefaultFolder;
                Properties.Settings.Default.Save();
                
                initialSetup();
            }
        }

        void RebuildStateList(State selectedItem = null)
        {
            listStates.Items.Clear();
            foreach (State s in stateIndexer.stateIdLookup.Values)
            {
                listStates.Items.Add(s);
            }
            listStates.Sorted = true;
            if (selectedItem!=null)
            {
                listStates.SelectedItem = selectedItem;
            }
            else
            {
                listStates.SelectedIndex = 0;
            }
        }

        void initialSetup()
        {
            modFile = new ModFileReader(Properties.Settings.Default.ModFilePath, Properties.Settings.Default.DefaultModFolder);
            lblModName.Text = modFile.Name;
            lblHOI4Path.ForeColor = Color.Black;
            //comboRegion.Items.AddRange(baseGame.getContinents().ToArray());
            stateIndexer = new StateIndexer(baseGame, modFile, ModFileReader.StatesPath);
            StateDetailsPanel.Visible = false;

            RebuildStateList();

            StrategicRegionCombo.Items.AddRange(stateIndexer.loadStrategicRegions().ToArray());

            foreach (State s in stateIndexer.AllStates)
            {
                //StateExporter.ExportState(s);
            }
            CountryIndexer.LoadCountries();
        }

        private void btnSelectMod_Click(object sender, EventArgs e)
        {
            getModFolder();
        }

        private void StrategicRegionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            StateDetailsPanel.Visible = false;
            StateTagTextBox.Text = "";

            if (StrategicRegionCombo.SelectedIndex == 0)
            {
                listStates.Items.Clear();
                listStates.Items.AddRange(stateIndexer.AllStates);
            }
            else
            {
                listStates.Items.Clear();
                string selectedText = ((StrategicRegion)StrategicRegionCombo.SelectedItem).Name;
                //Console.WriteLine("Selected Text: " + selectedText);
                if (stateIndexer.strategicRegionNameLookup.ContainsKey(selectedText))
                {
                    StrategicRegion selectedRegion = stateIndexer.strategicRegionNameLookup[selectedText];
                    List<State> statesToShow = new List<State>();
                    foreach (int provId in stateIndexer.provincesInStrategicRegion[selectedRegion])
                    {
                        if (stateIndexer.stateProvinceIdLookup.ContainsKey(provId))
                        {
                            State provState = stateIndexer.stateProvinceIdLookup[provId];
                            if (!statesToShow.Contains(provState))
                            {
                                statesToShow.Add(provState);
                            }
                        }
                        else
                        {
                            //Console.WriteLine("Missing Province (probably sea): "+provId);
                            // Probably a sea province which means it won't have a state associate with it
                        }
                    }

                    listStates.Items.AddRange(statesToShow.ToArray());
                }
                
            }
        }

        private void StateTagTextBox_TextChanged(object sender, EventArgs e)
        {
            StateDetailsPanel.Visible = false;
            StrategicRegionCombo.SelectedIndex = 0;
            StateTagTextBox.Text = StateTagTextBox.Text.ToUpper();
            listStates.Items.Clear();
            foreach(string owner in stateIndexer.stateOwnerLookup.Keys)
            {
                if (owner.Contains(StateTagTextBox.Text))
                {
                    foreach(State s in stateIndexer.stateOwnerLookup[owner])
                    {
                        if (!listStates.Items.Contains(s))
                        {
                            listStates.Items.Add(s);
                        }
                    }
                }
            }
        }

        void UpdateFactoryCounts()
        {
            int buildingTotal = Convert.ToInt16(MilFacNumeric.Value + CivFacNumeric.Value + DockyardNumeric.Value);

            if (buildingTotal <= BuildingCountBar.Maximum)
            {
                BuildingCountBar.Value = buildingTotal;
                MaxBuildingLabel.Text = buildingTotal.ToString() + BuildingCountBar.Maximum.ToString("/0");
                MaxBuildingLabel.ForeColor = Color.Black;
            }
            else
            {
                BuildingCountBar.Value = BuildingCountBar.Maximum;
                MaxBuildingLabel.Text = buildingTotal.ToString() + BuildingCountBar.Maximum.ToString("/0 Overflow!");
                MaxBuildingLabel.ForeColor = Color.Red;
            }
        }

        void SetEditValuesForGroupSelect()
        {
            ResourcesListBox.Items.Clear();
            StateCoresListBox.Items.Clear();
            MilFacNumeric.Value = 0;
            MilFacNumeric.Enabled = false;
            CivFacNumeric.Value = 0;
            CivFacNumeric.Enabled = false;
            DockyardNumeric.Value = 0;
            DockyardNumeric.Enabled = false;
            BuildingCountBar.Value = 0;
            StateCategoryLabel.Text = "";
            //ResourceSetButton.Enabled = false;
            //ResourceTypeCombo.Enabled = false;
            ResourceValueNumeric.Value = 0;
            //ResourceValueNumeric.Enabled = false;
            ManpowerNumeric.Value = 0;
            ManpowerNumeric.Enabled = false;

            OwnerTextBox.Text = selectedState.Owner;
        }

        void SetEditValues()
        {
            ResourcesListBox.Items.Clear();
            StateCoresListBox.Items.Clear();
            if (selectedState!=null)
            {
                StateChangesTracker.SelectedState = selectedState;
                StateCategoryLabel.Text = "State Category: "+selectedState.Category.Tag+selectedState.Category.BuildingSlots.ToString(" (0)");
                ManpowerNumeric.Enabled = true;
                ManpowerNumeric.Value = Convert.ToInt64(selectedState.MainVariables["manpower"]);
                BuildingCountBar.Maximum = selectedState.Category.BuildingSlots;

                int milFac = selectedState.StateBuildings.ContainsKey("arms_factory") ?
                    Convert.ToInt16(selectedState.StateBuildings["arms_factory"]) : 0;
                int civFac = selectedState.StateBuildings.ContainsKey("industrial_complex") ?
                    Convert.ToInt16(selectedState.StateBuildings["industrial_complex"]) : 0;
                int docks = selectedState.StateBuildings.ContainsKey("dockyard") ?
                    Convert.ToInt16(selectedState.StateBuildings["dockyard"]) : 0;
                MilFacNumeric.Value = milFac;
                CivFacNumeric.Value = civFac;
                DockyardNumeric.Value = docks;
                MilFacNumeric.Enabled = true;
                CivFacNumeric.Enabled = true;
                DockyardNumeric.Enabled = true;
                UpdateFactoryCounts();

                RebuildCoreList();

                OwnerTextBox.Text = selectedState.Owner;

                ResourceSetButton.Enabled = true;
                ResourceTypeCombo.Enabled = true;
                ResourceValueNumeric.Enabled = true;
                
                foreach (string key in selectedState.Resources.Keys)
                {
                    ResourcesListBox.Items.Add(key + selectedState.Resources[key].ToString(" (0)"));
                }

                if (ResourcesListBox.Items.Count > 0)
                {
                    ResourcesListBox.SelectedIndex = 0;
                }
                else
                {
                    ResourceTypeCombo.SelectedIndex = 0;
                    ResourceValueNumeric.Value = 0;
                }
            }
        }

        private void listStates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listStates.SelectedIndices.Count >= 1)
            {
                selectedState = (State)listStates.SelectedItems[0];
                StateDetailsPanel.Visible = true;
                lblStateID.Text = "ID: "+selectedState.ID.ToString();
                lblStateName.Text = "Name: "+selectedState.Name;
                lblStateOwner.Text = "Owner: "+selectedState.Owner;

                StringBuilder sb = new StringBuilder("");

                foreach (string var in selectedState.MainVariables.Keys)
                {
                    sb.Append(var + ": " + selectedState.MainVariables[var] + "\n");
                }
                StateMainVariablesBox.Text = sb.ToString();

                sb.Clear();
                /*foreach (string var in selectedState.HistoryVariables.Keys)
                {
                    sb.Append(var + ": " + selectedState.HistoryVariables[var]+"\n");
                }
                StateHistoryVariablesBox.Text = sb.ToString();*/

                sb.Clear();
                foreach (string var in selectedState.GetStateBuildings().Keys)
                {
                    sb.Append(var + ": " + selectedState.GetStateBuildings()[var].ToString() + "\n");
                }
                foreach (string var in selectedState.Cores)
                {
                    sb.Append("Core: "+var+"\n");
                }
                sb.Append("\n=== PROVINCES ===\n");
                foreach (int prov in selectedState.GetProvinceBuildings().Keys)
                {
                    foreach(string building in selectedState.GetProvinceBuildings()[prov].Keys)
                    {
                        sb.Append(prov.ToString() + ": " + building+" " + selectedState.GetProvinceBuildings()[prov][building].ToString() + "\n");
                    }
                }
                sb.Append("\n=== VICTORY POINTS ===\n");
                foreach (int prov in selectedState.VictoryPoints.Keys)
                {
                    int value = selectedState.VictoryPoints[prov];
                    sb.Append(prov.ToString() + ": " + value + "\n");
                }
                BuildingsTextBox.Text = sb.ToString();

                if (listStates.SelectedItems.Count > 1)
                {
                    SetEditValuesForGroupSelect(); 
                }
                else
                {
                    SetEditValues();
                }
            }
            else
            {
                StateViewTab.Visible = false;
            }
        }

        private void ApplyChangesButton_Click(object sender, EventArgs e)
        {
            foreach(object item in listStates.SelectedItems)
            {
                State state = (State)item;
                /*switch (ActionTypeCombo.SelectedIndex)
                {
                    case 2:// "Set Infrastructure":
                        state.SetStateBuilding("infrastructure",Convert.ToInt16(ActionValueNumeric.Value));
                        break;
                    case 3:// "Set Civilian Factories":
                        state.SetStateBuilding("industrial_complex", Convert.ToInt16(ActionValueNumeric.Value));
                        break;
                    case 4:// "Set Military Factories":
                        state.SetStateBuilding("arms_factory", Convert.ToInt16(ActionValueNumeric.Value));
                        break;
                }*/
            }
        }

        private void CountryEditorButton_Click(object sender, EventArgs e)
        {
            CountryEditorForm countryForm = new CountryEditorForm();
            countryForm.baseGame = baseGame;
            countryForm.modFile = modFile;
            countryForm.Show(this);
        }

        private void CopyStatesButton_Click(object sender, EventArgs e)
        {
            foreach (State s in listStates.SelectedItems)
            {
                s.IsModProvince = true;
            }
            RebuildStateList(selectedState);
        }

        #region State Resources
        void UpdateResourceValues()
        {
            // Check if the use is changing the text to something that doesn't exist
            if (!ResourceTypeCombo.Items.Contains(ResourceTypeCombo.Text))
            {
                ResourceValueNumeric.Value = 0;
                ResourceValueNumeric.Enabled = false;
                ResourceSetButton.Enabled = false;
            }
            else
            {
                ResourceValueNumeric.Value = selectedState.Resources.ContainsKey(ResourceTypeCombo.Text) ?
                    selectedState.Resources[ResourceTypeCombo.Text] : 0;
                ResourceValueNumeric.Enabled = true;
                ResourceSetButton.Enabled = true;
            }
        }

        private void ResourceTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateResourceValues();
        }

        private void ResourceTypeCombo_TextUpdate(object sender, EventArgs e)
        {
            UpdateResourceValues();
        }

        private void ResourcesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ResourcesListBox.SelectedItem != null)
            {
                string selectedResource = ResourcesListBox.SelectedItem.ToString().Split('(')[0].Trim();
                ResourceTypeCombo.SelectedItem = selectedResource;
                UpdateResourceValues();
            }
            
        }
        #endregion

        #region State Factories
        private void CivFacNumeric_ValueChanged(object sender, EventArgs e)
        {
            UpdateFactoryCounts();
        }

        private void MilFacNumeric_ValueChanged(object sender, EventArgs e)
        {
            UpdateFactoryCounts();
        }

        private void DockyardNumeric_ValueChanged(object sender, EventArgs e)
        {
            UpdateFactoryCounts();
        }
        #endregion

        private void ResourceSetButton_Click(object sender, EventArgs e)
        {
            string resourceName = ResourceTypeCombo.Text;

            //selectedState.SetResource(ResourceTypeCombo.Text, Convert.ToInt32(ResourceValueNumeric.Value));
            foreach (State s in listStates.SelectedItems)
            {
                s.SetResource(ResourceTypeCombo.Text, Convert.ToInt32(ResourceValueNumeric.Value));
            }

            if (listStates.SelectedItems.Count == 1)
            {
                // Refresh the items
                ResourcesListBox.Items.Clear();
                foreach (string key in selectedState.Resources.Keys)
                {
                    ResourcesListBox.Items.Add(key + selectedState.Resources[key].ToString(" (0)"));
                }
            }
            RebuildStateList(selectedState);
        }

        private void StateCoresListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StateCoresListBox.SelectedItem != null)
            {
                StateCoreBox.Text = StateCoresListBox.SelectedItem.ToString();
            }
        }

        private void AddCoreButton_Click(object sender, EventArgs e)
        {
            foreach(State s in listStates.SelectedItems)
            {
                s.SetCore(StateCoreBox.Text, true);
            }
            RebuildCoreList();
            //RebuildStateList((State)listStates.SelectedItem);
        }

        private void RemoveCoreButton_Click(object sender, EventArgs e)
        {
            foreach (State s in listStates.SelectedItems)
            {
                selectedState.SetCore(StateCoreBox.Text, false);
            }
            RebuildCoreList();
            //RebuildStateList((State)listStates.SelectedItem);
        }

        void RebuildCoreList()
        {
            StateCoresListBox.Items.Clear();
            StateCoreBox.Text = "";
            AddCoreButton.Enabled = false;
            RemoveCoreButton.Enabled = false;
            for (int i = 0; i < selectedState.Cores.Count; i++)
            {
                StateCoresListBox.Items.Add(selectedState.Cores[i]);
            }
        }

        private void StateCoreBox_TextChanged(object sender, EventArgs e)
        {
            AddCoreButton.Enabled = StateCoreBox.Text.Length == 3;
            RemoveCoreButton.Enabled = StateCoreBox.Text.Length == 3;
        }


        private void MainVariablesApplyButton_Click(object sender, EventArgs e)
        {
            foreach (State s in listStates.SelectedItems)
            {
                s.SetOwner(OwnerTextBox.Text);
            }
            if (listStates.SelectedItems.Count==1)
            {
                selectedState.SetManpower(Convert.ToInt32(ManpowerNumeric.Value));
            }
            
            RebuildStateList(selectedState);
        }

        private void ApplyBuildingsButton_Click(object sender, EventArgs e)
        {
            selectedState.SetStateBuilding("arms_factory", Convert.ToInt16(MilFacNumeric.Value));
            selectedState.SetStateBuilding("industrial_complex", Convert.ToInt16(CivFacNumeric.Value));
            selectedState.SetStateBuilding("dockyard", Convert.ToInt16(DockyardNumeric.Value));
        }

        private void RefreshStateListButton_Click(object sender, EventArgs e)
        {
            RebuildStateList(selectedState);
        }

        private void SaveAllChangesButton_Click(object sender, EventArgs e)
        {
            foreach(State s in stateIndexer.AllStates)
            {
                if (s.IsModProvince)
                {
                    StateExporter.ExportState(s, outputFolderCheck.Checked);
                }
            }
        }
    }
}
