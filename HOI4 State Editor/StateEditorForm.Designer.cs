namespace HOI4_State_Editor
{
    partial class StateEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectMod = new System.Windows.Forms.Button();
            this.lblModName = new System.Windows.Forms.Label();
            this.lblHOI4Path = new System.Windows.Forms.Label();
            this.StrategicRegionCombo = new System.Windows.Forms.ComboBox();
            this.groupStateDetails = new System.Windows.Forms.GroupBox();
            this.RefreshStateListButton = new System.Windows.Forms.Button();
            this.CopyStatesButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.StateViewTab = new System.Windows.Forms.TabPage();
            this.StateDetailsPanel = new System.Windows.Forms.Panel();
            this.BuildingsTextBox = new System.Windows.Forms.RichTextBox();
            this.lblStateID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StateMainVariablesBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StateHistoryVariablesBox = new System.Windows.Forms.RichTextBox();
            this.lblStateName = new System.Windows.Forms.Label();
            this.lblStateOwner = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ResourcesListBox = new System.Windows.Forms.ListBox();
            this.ResourceValueNumeric = new System.Windows.Forms.NumericUpDown();
            this.ResourceSetButton = new System.Windows.Forms.Button();
            this.ResourceTypeCombo = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RemoveCoreButton = new System.Windows.Forms.Button();
            this.AddCoreButton = new System.Windows.Forms.Button();
            this.StateCoreBox = new System.Windows.Forms.TextBox();
            this.StateCoresListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MainVariablesApplyButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.OwnerTextBox = new System.Windows.Forms.TextBox();
            this.StateCategoryLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ManpowerNumeric = new System.Windows.Forms.NumericUpDown();
            this.ApplyChangesButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ApplyBuildingsButton = new System.Windows.Forms.Button();
            this.MaxBuildingLabel = new System.Windows.Forms.Label();
            this.BuildingCountBar = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DockyardNumeric = new System.Windows.Forms.NumericUpDown();
            this.MilFacNumeric = new System.Windows.Forms.NumericUpDown();
            this.CivFacNumeric = new System.Windows.Forms.NumericUpDown();
            this.ActionDetailsGroup = new System.Windows.Forms.GroupBox();
            this.StateTagTextBox = new System.Windows.Forms.TextBox();
            this.listStates = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CountryEditorButton = new System.Windows.Forms.Button();
            this.SaveAllChangesButton = new System.Windows.Forms.Button();
            this.outputFolderCheck = new System.Windows.Forms.CheckBox();
            this.groupStateDetails.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.StateViewTab.SuspendLayout();
            this.StateDetailsPanel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResourceValueNumeric)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManpowerNumeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DockyardNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MilFacNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CivFacNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectMod
            // 
            this.btnSelectMod.Location = new System.Drawing.Point(12, 43);
            this.btnSelectMod.Name = "btnSelectMod";
            this.btnSelectMod.Size = new System.Drawing.Size(107, 25);
            this.btnSelectMod.TabIndex = 0;
            this.btnSelectMod.Text = "Select Mod";
            this.btnSelectMod.UseVisualStyleBackColor = true;
            this.btnSelectMod.Click += new System.EventHandler(this.btnSelectMod_Click);
            // 
            // lblModName
            // 
            this.lblModName.AutoSize = true;
            this.lblModName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModName.ForeColor = System.Drawing.Color.Red;
            this.lblModName.Location = new System.Drawing.Point(125, 43);
            this.lblModName.Name = "lblModName";
            this.lblModName.Size = new System.Drawing.Size(201, 25);
            this.lblModName.TabIndex = 1;
            this.lblModName.Text = "<No Mod Selected>";
            this.lblModName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHOI4Path
            // 
            this.lblHOI4Path.AutoSize = true;
            this.lblHOI4Path.ForeColor = System.Drawing.Color.Red;
            this.lblHOI4Path.Location = new System.Drawing.Point(12, 9);
            this.lblHOI4Path.Name = "lblHOI4Path";
            this.lblHOI4Path.Size = new System.Drawing.Size(107, 13);
            this.lblHOI4Path.TabIndex = 2;
            this.lblHOI4Path.Text = "<hoi4.exe not found>";
            // 
            // StrategicRegionCombo
            // 
            this.StrategicRegionCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.StrategicRegionCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.StrategicRegionCombo.FormattingEnabled = true;
            this.StrategicRegionCombo.Items.AddRange(new object[] {
            "<All>"});
            this.StrategicRegionCombo.Location = new System.Drawing.Point(94, 19);
            this.StrategicRegionCombo.Name = "StrategicRegionCombo";
            this.StrategicRegionCombo.Size = new System.Drawing.Size(220, 21);
            this.StrategicRegionCombo.TabIndex = 3;
            this.StrategicRegionCombo.SelectedIndexChanged += new System.EventHandler(this.StrategicRegionCombo_SelectedIndexChanged);
            // 
            // groupStateDetails
            // 
            this.groupStateDetails.Controls.Add(this.RefreshStateListButton);
            this.groupStateDetails.Controls.Add(this.CopyStatesButton);
            this.groupStateDetails.Controls.Add(this.tabControl1);
            this.groupStateDetails.Controls.Add(this.StateTagTextBox);
            this.groupStateDetails.Controls.Add(this.listStates);
            this.groupStateDetails.Controls.Add(this.label1);
            this.groupStateDetails.Controls.Add(this.StrategicRegionCombo);
            this.groupStateDetails.Location = new System.Drawing.Point(12, 74);
            this.groupStateDetails.Name = "groupStateDetails";
            this.groupStateDetails.Size = new System.Drawing.Size(984, 643);
            this.groupStateDetails.TabIndex = 4;
            this.groupStateDetails.TabStop = false;
            this.groupStateDetails.Text = "States";
            // 
            // RefreshStateListButton
            // 
            this.RefreshStateListButton.Location = new System.Drawing.Point(118, 64);
            this.RefreshStateListButton.Name = "RefreshStateListButton";
            this.RefreshStateListButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshStateListButton.TabIndex = 12;
            this.RefreshStateListButton.Text = "Refresh List";
            this.RefreshStateListButton.UseVisualStyleBackColor = true;
            this.RefreshStateListButton.Click += new System.EventHandler(this.RefreshStateListButton_Click);
            // 
            // CopyStatesButton
            // 
            this.CopyStatesButton.Location = new System.Drawing.Point(198, 64);
            this.CopyStatesButton.Name = "CopyStatesButton";
            this.CopyStatesButton.Size = new System.Drawing.Size(116, 23);
            this.CopyStatesButton.TabIndex = 11;
            this.CopyStatesButton.Text = "Copy States To Mod";
            this.CopyStatesButton.UseVisualStyleBackColor = true;
            this.CopyStatesButton.Click += new System.EventHandler(this.CopyStatesButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.StateViewTab);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(320, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(658, 618);
            this.tabControl1.TabIndex = 10;
            // 
            // StateViewTab
            // 
            this.StateViewTab.Controls.Add(this.StateDetailsPanel);
            this.StateViewTab.Location = new System.Drawing.Point(4, 22);
            this.StateViewTab.Name = "StateViewTab";
            this.StateViewTab.Padding = new System.Windows.Forms.Padding(3);
            this.StateViewTab.Size = new System.Drawing.Size(650, 592);
            this.StateViewTab.TabIndex = 0;
            this.StateViewTab.Text = "View Details";
            this.StateViewTab.UseVisualStyleBackColor = true;
            // 
            // StateDetailsPanel
            // 
            this.StateDetailsPanel.Controls.Add(this.BuildingsTextBox);
            this.StateDetailsPanel.Controls.Add(this.lblStateID);
            this.StateDetailsPanel.Controls.Add(this.label3);
            this.StateDetailsPanel.Controls.Add(this.StateMainVariablesBox);
            this.StateDetailsPanel.Controls.Add(this.label2);
            this.StateDetailsPanel.Controls.Add(this.StateHistoryVariablesBox);
            this.StateDetailsPanel.Controls.Add(this.lblStateName);
            this.StateDetailsPanel.Controls.Add(this.lblStateOwner);
            this.StateDetailsPanel.Location = new System.Drawing.Point(3, 6);
            this.StateDetailsPanel.Name = "StateDetailsPanel";
            this.StateDetailsPanel.Size = new System.Drawing.Size(505, 580);
            this.StateDetailsPanel.TabIndex = 11;
            // 
            // BuildingsTextBox
            // 
            this.BuildingsTextBox.Location = new System.Drawing.Point(274, 3);
            this.BuildingsTextBox.Name = "BuildingsTextBox";
            this.BuildingsTextBox.Size = new System.Drawing.Size(173, 314);
            this.BuildingsTextBox.TabIndex = 7;
            this.BuildingsTextBox.Text = "";
            // 
            // lblStateID
            // 
            this.lblStateID.AutoSize = true;
            this.lblStateID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateID.Location = new System.Drawing.Point(3, 0);
            this.lblStateID.Name = "lblStateID";
            this.lblStateID.Size = new System.Drawing.Size(32, 24);
            this.lblStateID.TabIndex = 8;
            this.lblStateID.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Main Variables:";
            // 
            // StateMainVariablesBox
            // 
            this.StateMainVariablesBox.Location = new System.Drawing.Point(3, 219);
            this.StateMainVariablesBox.Name = "StateMainVariablesBox";
            this.StateMainVariablesBox.Size = new System.Drawing.Size(265, 85);
            this.StateMainVariablesBox.TabIndex = 7;
            this.StateMainVariablesBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "History Variables:";
            // 
            // StateHistoryVariablesBox
            // 
            this.StateHistoryVariablesBox.Location = new System.Drawing.Point(3, 323);
            this.StateHistoryVariablesBox.Name = "StateHistoryVariablesBox";
            this.StateHistoryVariablesBox.Size = new System.Drawing.Size(444, 235);
            this.StateHistoryVariablesBox.TabIndex = 7;
            this.StateHistoryVariablesBox.Text = "";
            // 
            // lblStateName
            // 
            this.lblStateName.AutoSize = true;
            this.lblStateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateName.Location = new System.Drawing.Point(3, 24);
            this.lblStateName.Name = "lblStateName";
            this.lblStateName.Size = new System.Drawing.Size(66, 24);
            this.lblStateName.TabIndex = 8;
            this.lblStateName.Text = "Name:";
            // 
            // lblStateOwner
            // 
            this.lblStateOwner.AutoSize = true;
            this.lblStateOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateOwner.Location = new System.Drawing.Point(3, 48);
            this.lblStateOwner.Name = "lblStateOwner";
            this.lblStateOwner.Size = new System.Drawing.Size(72, 24);
            this.lblStateOwner.TabIndex = 8;
            this.lblStateOwner.Text = "Owner:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.ApplyChangesButton);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.ActionDetailsGroup);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(650, 592);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ResourcesListBox);
            this.groupBox4.Controls.Add(this.ResourceValueNumeric);
            this.groupBox4.Controls.Add(this.ResourceSetButton);
            this.groupBox4.Controls.Add(this.ResourceTypeCombo);
            this.groupBox4.Location = new System.Drawing.Point(264, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 139);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resources";
            // 
            // ResourcesListBox
            // 
            this.ResourcesListBox.FormattingEnabled = true;
            this.ResourcesListBox.Location = new System.Drawing.Point(6, 19);
            this.ResourcesListBox.Name = "ResourcesListBox";
            this.ResourcesListBox.Size = new System.Drawing.Size(90, 95);
            this.ResourcesListBox.TabIndex = 5;
            this.ResourcesListBox.SelectedIndexChanged += new System.EventHandler(this.ResourcesListBox_SelectedIndexChanged);
            // 
            // ResourceValueNumeric
            // 
            this.ResourceValueNumeric.Location = new System.Drawing.Point(102, 44);
            this.ResourceValueNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ResourceValueNumeric.Name = "ResourceValueNumeric";
            this.ResourceValueNumeric.Size = new System.Drawing.Size(65, 20);
            this.ResourceValueNumeric.TabIndex = 0;
            // 
            // ResourceSetButton
            // 
            this.ResourceSetButton.Location = new System.Drawing.Point(102, 91);
            this.ResourceSetButton.Name = "ResourceSetButton";
            this.ResourceSetButton.Size = new System.Drawing.Size(93, 23);
            this.ResourceSetButton.TabIndex = 6;
            this.ResourceSetButton.Text = "Set Resource";
            this.ResourceSetButton.UseVisualStyleBackColor = true;
            this.ResourceSetButton.Click += new System.EventHandler(this.ResourceSetButton_Click);
            // 
            // ResourceTypeCombo
            // 
            this.ResourceTypeCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ResourceTypeCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ResourceTypeCombo.FormattingEnabled = true;
            this.ResourceTypeCombo.Items.AddRange(new object[] {
            "steel",
            "aluminium",
            "tungsten",
            "oil",
            "rubber",
            "chromium"});
            this.ResourceTypeCombo.Location = new System.Drawing.Point(102, 19);
            this.ResourceTypeCombo.Name = "ResourceTypeCombo";
            this.ResourceTypeCombo.Size = new System.Drawing.Size(93, 21);
            this.ResourceTypeCombo.TabIndex = 6;
            this.ResourceTypeCombo.Text = "steel";
            this.ResourceTypeCombo.SelectedIndexChanged += new System.EventHandler(this.ResourceTypeCombo_SelectedIndexChanged);
            this.ResourceTypeCombo.TextUpdate += new System.EventHandler(this.ResourceTypeCombo_TextUpdate);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RemoveCoreButton);
            this.groupBox3.Controls.Add(this.AddCoreButton);
            this.groupBox3.Controls.Add(this.StateCoreBox);
            this.groupBox3.Controls.Add(this.StateCoresListBox);
            this.groupBox3.Location = new System.Drawing.Point(264, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 122);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cores";
            // 
            // RemoveCoreButton
            // 
            this.RemoveCoreButton.Location = new System.Drawing.Point(91, 91);
            this.RemoveCoreButton.Name = "RemoveCoreButton";
            this.RemoveCoreButton.Size = new System.Drawing.Size(103, 23);
            this.RemoveCoreButton.TabIndex = 7;
            this.RemoveCoreButton.Text = "Remove Core";
            this.RemoveCoreButton.UseVisualStyleBackColor = true;
            this.RemoveCoreButton.Click += new System.EventHandler(this.RemoveCoreButton_Click);
            // 
            // AddCoreButton
            // 
            this.AddCoreButton.Location = new System.Drawing.Point(91, 45);
            this.AddCoreButton.Name = "AddCoreButton";
            this.AddCoreButton.Size = new System.Drawing.Size(103, 23);
            this.AddCoreButton.TabIndex = 7;
            this.AddCoreButton.Text = "Add Core";
            this.AddCoreButton.UseVisualStyleBackColor = true;
            this.AddCoreButton.Click += new System.EventHandler(this.AddCoreButton_Click);
            // 
            // StateCoreBox
            // 
            this.StateCoreBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.StateCoreBox.Location = new System.Drawing.Point(91, 19);
            this.StateCoreBox.MaxLength = 3;
            this.StateCoreBox.Name = "StateCoreBox";
            this.StateCoreBox.Size = new System.Drawing.Size(39, 20);
            this.StateCoreBox.TabIndex = 6;
            this.StateCoreBox.TextChanged += new System.EventHandler(this.StateCoreBox_TextChanged);
            // 
            // StateCoresListBox
            // 
            this.StateCoresListBox.FormattingEnabled = true;
            this.StateCoresListBox.Location = new System.Drawing.Point(6, 19);
            this.StateCoresListBox.Name = "StateCoresListBox";
            this.StateCoresListBox.Size = new System.Drawing.Size(79, 95);
            this.StateCoresListBox.TabIndex = 5;
            this.StateCoresListBox.SelectedIndexChanged += new System.EventHandler(this.StateCoresListBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MainVariablesApplyButton);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.OwnerTextBox);
            this.groupBox2.Controls.Add(this.StateCategoryLabel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ManpowerNumeric);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 139);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Main Variables";
            // 
            // MainVariablesApplyButton
            // 
            this.MainVariablesApplyButton.Location = new System.Drawing.Point(171, 110);
            this.MainVariablesApplyButton.Name = "MainVariablesApplyButton";
            this.MainVariablesApplyButton.Size = new System.Drawing.Size(75, 23);
            this.MainVariablesApplyButton.TabIndex = 10;
            this.MainVariablesApplyButton.Text = "Apply";
            this.MainVariablesApplyButton.UseVisualStyleBackColor = true;
            this.MainVariablesApplyButton.Click += new System.EventHandler(this.MainVariablesApplyButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Owner";
            // 
            // OwnerTextBox
            // 
            this.OwnerTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.OwnerTextBox.Location = new System.Drawing.Point(50, 41);
            this.OwnerTextBox.MaxLength = 3;
            this.OwnerTextBox.Name = "OwnerTextBox";
            this.OwnerTextBox.Size = new System.Drawing.Size(47, 20);
            this.OwnerTextBox.TabIndex = 3;
            // 
            // StateCategoryLabel
            // 
            this.StateCategoryLabel.AutoSize = true;
            this.StateCategoryLabel.Location = new System.Drawing.Point(6, 19);
            this.StateCategoryLabel.Name = "StateCategoryLabel";
            this.StateCategoryLabel.Size = new System.Drawing.Size(80, 13);
            this.StateCategoryLabel.TabIndex = 8;
            this.StateCategoryLabel.Text = "State Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Manpower";
            // 
            // ManpowerNumeric
            // 
            this.ManpowerNumeric.Location = new System.Drawing.Point(6, 107);
            this.ManpowerNumeric.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.ManpowerNumeric.Name = "ManpowerNumeric";
            this.ManpowerNumeric.Size = new System.Drawing.Size(120, 20);
            this.ManpowerNumeric.TabIndex = 0;
            // 
            // ApplyChangesButton
            // 
            this.ApplyChangesButton.Location = new System.Drawing.Point(477, 548);
            this.ApplyChangesButton.Name = "ApplyChangesButton";
            this.ApplyChangesButton.Size = new System.Drawing.Size(167, 38);
            this.ApplyChangesButton.TabIndex = 4;
            this.ApplyChangesButton.Text = "Save States";
            this.ApplyChangesButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ApplyBuildingsButton);
            this.groupBox1.Controls.Add(this.MaxBuildingLabel);
            this.groupBox1.Controls.Add(this.BuildingCountBar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DockyardNumeric);
            this.groupBox1.Controls.Add(this.MilFacNumeric);
            this.groupBox1.Controls.Add(this.CivFacNumeric);
            this.groupBox1.Location = new System.Drawing.Point(6, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 196);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Factories";
            // 
            // ApplyBuildingsButton
            // 
            this.ApplyBuildingsButton.Location = new System.Drawing.Point(171, 167);
            this.ApplyBuildingsButton.Name = "ApplyBuildingsButton";
            this.ApplyBuildingsButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyBuildingsButton.TabIndex = 10;
            this.ApplyBuildingsButton.Text = "Apply";
            this.ApplyBuildingsButton.UseVisualStyleBackColor = true;
            this.ApplyBuildingsButton.Click += new System.EventHandler(this.ApplyBuildingsButton_Click);
            // 
            // MaxBuildingLabel
            // 
            this.MaxBuildingLabel.AutoSize = true;
            this.MaxBuildingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxBuildingLabel.Location = new System.Drawing.Point(171, 72);
            this.MaxBuildingLabel.Name = "MaxBuildingLabel";
            this.MaxBuildingLabel.Size = new System.Drawing.Size(54, 16);
            this.MaxBuildingLabel.TabIndex = 9;
            this.MaxBuildingLabel.Text = "12 (10)";
            // 
            // BuildingCountBar
            // 
            this.BuildingCountBar.Location = new System.Drawing.Point(6, 72);
            this.BuildingCountBar.Name = "BuildingCountBar";
            this.BuildingCountBar.Size = new System.Drawing.Size(159, 11);
            this.BuildingCountBar.TabIndex = 8;
            this.BuildingCountBar.Value = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Dockyard";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 26);
            this.label6.TabIndex = 7;
            this.label6.Text = "Military\r\nFactory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Civilian\r\nFactory";
            // 
            // DockyardNumeric
            // 
            this.DockyardNumeric.Location = new System.Drawing.Point(115, 46);
            this.DockyardNumeric.Name = "DockyardNumeric";
            this.DockyardNumeric.Size = new System.Drawing.Size(47, 20);
            this.DockyardNumeric.TabIndex = 0;
            this.DockyardNumeric.ValueChanged += new System.EventHandler(this.DockyardNumeric_ValueChanged);
            // 
            // MilFacNumeric
            // 
            this.MilFacNumeric.Location = new System.Drawing.Point(62, 46);
            this.MilFacNumeric.Name = "MilFacNumeric";
            this.MilFacNumeric.Size = new System.Drawing.Size(47, 20);
            this.MilFacNumeric.TabIndex = 0;
            this.MilFacNumeric.ValueChanged += new System.EventHandler(this.MilFacNumeric_ValueChanged);
            // 
            // CivFacNumeric
            // 
            this.CivFacNumeric.Location = new System.Drawing.Point(9, 46);
            this.CivFacNumeric.Name = "CivFacNumeric";
            this.CivFacNumeric.Size = new System.Drawing.Size(47, 20);
            this.CivFacNumeric.TabIndex = 0;
            this.CivFacNumeric.ValueChanged += new System.EventHandler(this.CivFacNumeric_ValueChanged);
            // 
            // ActionDetailsGroup
            // 
            this.ActionDetailsGroup.Location = new System.Drawing.Point(6, 353);
            this.ActionDetailsGroup.Name = "ActionDetailsGroup";
            this.ActionDetailsGroup.Size = new System.Drawing.Size(252, 130);
            this.ActionDetailsGroup.TabIndex = 2;
            this.ActionDetailsGroup.TabStop = false;
            this.ActionDetailsGroup.Text = "ActionDetails";
            // 
            // StateTagTextBox
            // 
            this.StateTagTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.StateTagTextBox.Location = new System.Drawing.Point(7, 66);
            this.StateTagTextBox.MaxLength = 3;
            this.StateTagTextBox.Name = "StateTagTextBox";
            this.StateTagTextBox.Size = new System.Drawing.Size(44, 20);
            this.StateTagTextBox.TabIndex = 6;
            this.StateTagTextBox.TextChanged += new System.EventHandler(this.StateTagTextBox_TextChanged);
            // 
            // listStates
            // 
            this.listStates.FormattingEnabled = true;
            this.listStates.Location = new System.Drawing.Point(6, 92);
            this.listStates.Name = "listStates";
            this.listStates.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listStates.Size = new System.Drawing.Size(308, 537);
            this.listStates.TabIndex = 5;
            this.listStates.SelectedIndexChanged += new System.EventHandler(this.listStates_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Strategic Areas:";
            // 
            // CountryEditorButton
            // 
            this.CountryEditorButton.Location = new System.Drawing.Point(356, 9);
            this.CountryEditorButton.Name = "CountryEditorButton";
            this.CountryEditorButton.Size = new System.Drawing.Size(122, 31);
            this.CountryEditorButton.TabIndex = 5;
            this.CountryEditorButton.Text = "Country Editor";
            this.CountryEditorButton.UseVisualStyleBackColor = true;
            this.CountryEditorButton.Click += new System.EventHandler(this.CountryEditorButton_Click);
            // 
            // SaveAllChangesButton
            // 
            this.SaveAllChangesButton.Location = new System.Drawing.Point(787, 9);
            this.SaveAllChangesButton.Name = "SaveAllChangesButton";
            this.SaveAllChangesButton.Size = new System.Drawing.Size(209, 36);
            this.SaveAllChangesButton.TabIndex = 6;
            this.SaveAllChangesButton.Text = "Save";
            this.SaveAllChangesButton.UseVisualStyleBackColor = true;
            this.SaveAllChangesButton.Click += new System.EventHandler(this.SaveAllChangesButton_Click);
            // 
            // outputFolderCheck
            // 
            this.outputFolderCheck.AutoSize = true;
            this.outputFolderCheck.Location = new System.Drawing.Point(787, 51);
            this.outputFolderCheck.Name = "outputFolderCheck";
            this.outputFolderCheck.Size = new System.Drawing.Size(125, 17);
            this.outputFolderCheck.TabIndex = 7;
            this.outputFolderCheck.Text = "Save to output folder";
            this.outputFolderCheck.UseVisualStyleBackColor = true;
            // 
            // StateEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.outputFolderCheck);
            this.Controls.Add(this.SaveAllChangesButton);
            this.Controls.Add(this.CountryEditorButton);
            this.Controls.Add(this.groupStateDetails);
            this.Controls.Add(this.lblHOI4Path);
            this.Controls.Add(this.lblModName);
            this.Controls.Add(this.btnSelectMod);
            this.Name = "StateEditorForm";
            this.Text = "State Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupStateDetails.ResumeLayout(false);
            this.groupStateDetails.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.StateViewTab.ResumeLayout(false);
            this.StateDetailsPanel.ResumeLayout(false);
            this.StateDetailsPanel.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResourceValueNumeric)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManpowerNumeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DockyardNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MilFacNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CivFacNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSelectMod;
        private System.Windows.Forms.Label lblModName;
        private System.Windows.Forms.Label lblHOI4Path;
        private System.Windows.Forms.ComboBox StrategicRegionCombo;
        private System.Windows.Forms.GroupBox groupStateDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listStates;
        private System.Windows.Forms.TextBox StateTagTextBox;
        private System.Windows.Forms.Label lblStateOwner;
        private System.Windows.Forms.RichTextBox StateHistoryVariablesBox;
        private System.Windows.Forms.Label lblStateID;
        private System.Windows.Forms.Label lblStateName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox StateMainVariablesBox;
        private System.Windows.Forms.RichTextBox BuildingsTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage StateViewTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel StateDetailsPanel;
        private System.Windows.Forms.GroupBox ActionDetailsGroup;
        private System.Windows.Forms.TextBox OwnerTextBox;
        private System.Windows.Forms.Button ApplyChangesButton;
        private System.Windows.Forms.Button CountryEditorButton;
        private System.Windows.Forms.Button CopyStatesButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox StateCoresListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ManpowerNumeric;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown CivFacNumeric;
        private System.Windows.Forms.ProgressBar BuildingCountBar;
        private System.Windows.Forms.NumericUpDown DockyardNumeric;
        private System.Windows.Forms.NumericUpDown MilFacNumeric;
        private System.Windows.Forms.Button ResourceSetButton;
        private System.Windows.Forms.ComboBox ResourceTypeCombo;
        private System.Windows.Forms.NumericUpDown ResourceValueNumeric;
        private System.Windows.Forms.ListBox ResourcesListBox;
        private System.Windows.Forms.Label StateCategoryLabel;
        private System.Windows.Forms.Label MaxBuildingLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button RemoveCoreButton;
        private System.Windows.Forms.Button AddCoreButton;
        private System.Windows.Forms.TextBox StateCoreBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button MainVariablesApplyButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ApplyBuildingsButton;
        private System.Windows.Forms.Button RefreshStateListButton;
        private System.Windows.Forms.Button SaveAllChangesButton;
        private System.Windows.Forms.CheckBox outputFolderCheck;
    }
}

