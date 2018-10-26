namespace HOI4_State_Editor
{
    partial class CountryEditorForm
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
            this.CountryList = new System.Windows.Forms.ListBox();
            this.NeutralFlagPicture = new System.Windows.Forms.PictureBox();
            this.DemocracyFlagPicture = new System.Windows.Forms.PictureBox();
            this.FascistFlagPicture = new System.Windows.Forms.PictureBox();
            this.CommunistFlagPicture = new System.Windows.Forms.PictureBox();
            this.NeutralNameLabel = new System.Windows.Forms.Label();
            this.DemocracyNameLabel = new System.Windows.Forms.Label();
            this.FascistNameLabel = new System.Windows.Forms.Label();
            this.CommunistNameLabel = new System.Windows.Forms.Label();
            this.CountrySeachBox = new System.Windows.Forms.TextBox();
            this.NewCountryButton = new System.Windows.Forms.Button();
            this.CountryColourBox = new System.Windows.Forms.PictureBox();
            this.CountryPoliticsBox = new System.Windows.Forms.RichTextBox();
            this.lblCapital = new System.Windows.Forms.Label();
            this.lblCountryTag = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CountryLocalNameBox = new System.Windows.Forms.TextBox();
            this.CountryLocalDefinitiveBox = new System.Windows.Forms.TextBox();
            this.CountryLocalAdjectiveBox = new System.Windows.Forms.TextBox();
            this.CountryIdeologyLocalCombo = new System.Windows.Forms.ComboBox();
            this.PoliticsGroupBox = new System.Windows.Forms.GroupBox();
            this.EditPartyPopularityNumeric = new System.Windows.Forms.NumericUpDown();
            this.lblCommunismPopularity = new System.Windows.Forms.Label();
            this.lblFascismPopularity = new System.Windows.Forms.Label();
            this.lblDemocraticPopularity = new System.Windows.Forms.Label();
            this.lblNeutralityPopularity = new System.Windows.Forms.Label();
            this.EditPartyNameTextBox = new System.Windows.Forms.TextBox();
            this.EditCountryElectionsBannedCheck = new System.Windows.Forms.CheckBox();
            this.EditCountryElectionFrequencyNumeric = new System.Windows.Forms.NumericUpDown();
            this.EditCountryElectionDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EditCountryRulingPartyCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EditPartyIdeologyCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EditFieldsCheckBox = new System.Windows.Forms.CheckBox();
            this.CountryLeaderListBox = new System.Windows.Forms.ListBox();
            this.LeaderPicture = new System.Windows.Forms.PictureBox();
            this.LeaderNameLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LeaderTypeDropdown = new System.Windows.Forms.ComboBox();
            this.LeaderTypeLabel = new System.Windows.Forms.Label();
            this.LeaderPicturePathLabel = new System.Windows.Forms.Label();
            this.LeaderSkillLabel = new System.Windows.Forms.Label();
            this.attackPicture = new System.Windows.Forms.PictureBox();
            this.defencePicture = new System.Windows.Forms.PictureBox();
            this.planningPicture = new System.Windows.Forms.PictureBox();
            this.supplyPicture = new System.Windows.Forms.PictureBox();
            this.LeaderAttackLabel = new System.Windows.Forms.Label();
            this.LeaderDefenceLabel = new System.Windows.Forms.Label();
            this.LeaderPlanningLabel = new System.Windows.Forms.Label();
            this.LeaderSupplyLabel = new System.Windows.Forms.Label();
            this.LeaderTraitListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.NeutralFlagPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DemocracyFlagPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FascistFlagPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommunistFlagPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryColourBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.PoliticsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditPartyPopularityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditCountryElectionFrequencyNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeaderPicture)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attackPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defencePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planningPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // CountryList
            // 
            this.CountryList.FormattingEnabled = true;
            this.CountryList.Location = new System.Drawing.Point(12, 97);
            this.CountryList.Name = "CountryList";
            this.CountryList.Size = new System.Drawing.Size(256, 615);
            this.CountryList.Sorted = true;
            this.CountryList.TabIndex = 0;
            this.CountryList.SelectedIndexChanged += new System.EventHandler(this.CountryList_SelectedIndexChanged);
            // 
            // NeutralFlagPicture
            // 
            this.NeutralFlagPicture.Location = new System.Drawing.Point(274, 71);
            this.NeutralFlagPicture.Name = "NeutralFlagPicture";
            this.NeutralFlagPicture.Size = new System.Drawing.Size(82, 52);
            this.NeutralFlagPicture.TabIndex = 1;
            this.NeutralFlagPicture.TabStop = false;
            // 
            // DemocracyFlagPicture
            // 
            this.DemocracyFlagPicture.Location = new System.Drawing.Point(398, 71);
            this.DemocracyFlagPicture.Name = "DemocracyFlagPicture";
            this.DemocracyFlagPicture.Size = new System.Drawing.Size(82, 52);
            this.DemocracyFlagPicture.TabIndex = 1;
            this.DemocracyFlagPicture.TabStop = false;
            // 
            // FascistFlagPicture
            // 
            this.FascistFlagPicture.Location = new System.Drawing.Point(525, 71);
            this.FascistFlagPicture.Name = "FascistFlagPicture";
            this.FascistFlagPicture.Size = new System.Drawing.Size(82, 52);
            this.FascistFlagPicture.TabIndex = 1;
            this.FascistFlagPicture.TabStop = false;
            // 
            // CommunistFlagPicture
            // 
            this.CommunistFlagPicture.Location = new System.Drawing.Point(644, 71);
            this.CommunistFlagPicture.Name = "CommunistFlagPicture";
            this.CommunistFlagPicture.Size = new System.Drawing.Size(82, 52);
            this.CommunistFlagPicture.TabIndex = 1;
            this.CommunistFlagPicture.TabStop = false;
            // 
            // NeutralNameLabel
            // 
            this.NeutralNameLabel.AutoSize = true;
            this.NeutralNameLabel.Location = new System.Drawing.Point(271, 126);
            this.NeutralNameLabel.Name = "NeutralNameLabel";
            this.NeutralNameLabel.Size = new System.Drawing.Size(35, 13);
            this.NeutralNameLabel.TabIndex = 2;
            this.NeutralNameLabel.Text = "label1";
            // 
            // DemocracyNameLabel
            // 
            this.DemocracyNameLabel.AutoSize = true;
            this.DemocracyNameLabel.Location = new System.Drawing.Point(395, 126);
            this.DemocracyNameLabel.Name = "DemocracyNameLabel";
            this.DemocracyNameLabel.Size = new System.Drawing.Size(35, 13);
            this.DemocracyNameLabel.TabIndex = 3;
            this.DemocracyNameLabel.Text = "label2";
            // 
            // FascistNameLabel
            // 
            this.FascistNameLabel.AutoSize = true;
            this.FascistNameLabel.Location = new System.Drawing.Point(522, 126);
            this.FascistNameLabel.Name = "FascistNameLabel";
            this.FascistNameLabel.Size = new System.Drawing.Size(35, 13);
            this.FascistNameLabel.TabIndex = 4;
            this.FascistNameLabel.Text = "label3";
            // 
            // CommunistNameLabel
            // 
            this.CommunistNameLabel.AutoSize = true;
            this.CommunistNameLabel.Location = new System.Drawing.Point(641, 126);
            this.CommunistNameLabel.Name = "CommunistNameLabel";
            this.CommunistNameLabel.Size = new System.Drawing.Size(35, 13);
            this.CommunistNameLabel.TabIndex = 5;
            this.CommunistNameLabel.Text = "label4";
            // 
            // CountrySeachBox
            // 
            this.CountrySeachBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CountrySeachBox.Location = new System.Drawing.Point(12, 71);
            this.CountrySeachBox.MaxLength = 3;
            this.CountrySeachBox.Name = "CountrySeachBox";
            this.CountrySeachBox.Size = new System.Drawing.Size(256, 20);
            this.CountrySeachBox.TabIndex = 6;
            this.CountrySeachBox.TextChanged += new System.EventHandler(this.CountrySeachBox_TextChanged);
            // 
            // NewCountryButton
            // 
            this.NewCountryButton.Location = new System.Drawing.Point(12, 42);
            this.NewCountryButton.Name = "NewCountryButton";
            this.NewCountryButton.Size = new System.Drawing.Size(122, 23);
            this.NewCountryButton.TabIndex = 7;
            this.NewCountryButton.Text = "New Country";
            this.NewCountryButton.UseVisualStyleBackColor = true;
            // 
            // CountryColourBox
            // 
            this.CountryColourBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CountryColourBox.Location = new System.Drawing.Point(274, 142);
            this.CountryColourBox.Name = "CountryColourBox";
            this.CountryColourBox.Size = new System.Drawing.Size(452, 23);
            this.CountryColourBox.TabIndex = 8;
            this.CountryColourBox.TabStop = false;
            // 
            // CountryPoliticsBox
            // 
            this.CountryPoliticsBox.Location = new System.Drawing.Point(274, 202);
            this.CountryPoliticsBox.Name = "CountryPoliticsBox";
            this.CountryPoliticsBox.Size = new System.Drawing.Size(283, 510);
            this.CountryPoliticsBox.TabIndex = 9;
            this.CountryPoliticsBox.Text = "";
            // 
            // lblCapital
            // 
            this.lblCapital.AutoSize = true;
            this.lblCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapital.Location = new System.Drawing.Point(274, 179);
            this.lblCapital.Name = "lblCapital";
            this.lblCapital.Size = new System.Drawing.Size(66, 20);
            this.lblCapital.TabIndex = 10;
            this.lblCapital.Text = "Capital: ";
            // 
            // lblCountryTag
            // 
            this.lblCountryTag.AutoSize = true;
            this.lblCountryTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountryTag.Location = new System.Drawing.Point(272, 9);
            this.lblCountryTag.Name = "lblCountryTag";
            this.lblCountryTag.Size = new System.Drawing.Size(207, 39);
            this.lblCountryTag.TabIndex = 10;
            this.lblCountryTag.Text = "TAG: NAME";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CountryLocalNameBox);
            this.groupBox1.Controls.Add(this.CountryLocalDefinitiveBox);
            this.groupBox1.Controls.Add(this.CountryLocalAdjectiveBox);
            this.groupBox1.Controls.Add(this.CountryIdeologyLocalCombo);
            this.groupBox1.Location = new System.Drawing.Point(732, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 133);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Country Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Adjective";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Definitive";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // CountryLocalNameBox
            // 
            this.CountryLocalNameBox.Location = new System.Drawing.Point(84, 46);
            this.CountryLocalNameBox.Name = "CountryLocalNameBox";
            this.CountryLocalNameBox.Size = new System.Drawing.Size(174, 20);
            this.CountryLocalNameBox.TabIndex = 2;
            // 
            // CountryLocalDefinitiveBox
            // 
            this.CountryLocalDefinitiveBox.Location = new System.Drawing.Point(84, 72);
            this.CountryLocalDefinitiveBox.Name = "CountryLocalDefinitiveBox";
            this.CountryLocalDefinitiveBox.Size = new System.Drawing.Size(174, 20);
            this.CountryLocalDefinitiveBox.TabIndex = 2;
            // 
            // CountryLocalAdjectiveBox
            // 
            this.CountryLocalAdjectiveBox.Location = new System.Drawing.Point(84, 98);
            this.CountryLocalAdjectiveBox.Name = "CountryLocalAdjectiveBox";
            this.CountryLocalAdjectiveBox.Size = new System.Drawing.Size(174, 20);
            this.CountryLocalAdjectiveBox.TabIndex = 1;
            // 
            // CountryIdeologyLocalCombo
            // 
            this.CountryIdeologyLocalCombo.FormattingEnabled = true;
            this.CountryIdeologyLocalCombo.Items.AddRange(new object[] {
            "neutrality",
            "democratic",
            "fascism",
            "communism"});
            this.CountryIdeologyLocalCombo.Location = new System.Drawing.Point(6, 19);
            this.CountryIdeologyLocalCombo.Name = "CountryIdeologyLocalCombo";
            this.CountryIdeologyLocalCombo.Size = new System.Drawing.Size(121, 21);
            this.CountryIdeologyLocalCombo.TabIndex = 0;
            this.CountryIdeologyLocalCombo.Text = "neutrality";
            this.CountryIdeologyLocalCombo.SelectedIndexChanged += new System.EventHandler(this.CountryIdeologyLocalCombo_SelectedIndexChanged);
            // 
            // PoliticsGroupBox
            // 
            this.PoliticsGroupBox.Controls.Add(this.EditPartyPopularityNumeric);
            this.PoliticsGroupBox.Controls.Add(this.lblCommunismPopularity);
            this.PoliticsGroupBox.Controls.Add(this.lblFascismPopularity);
            this.PoliticsGroupBox.Controls.Add(this.lblDemocraticPopularity);
            this.PoliticsGroupBox.Controls.Add(this.lblNeutralityPopularity);
            this.PoliticsGroupBox.Controls.Add(this.EditPartyNameTextBox);
            this.PoliticsGroupBox.Controls.Add(this.EditCountryElectionsBannedCheck);
            this.PoliticsGroupBox.Controls.Add(this.EditCountryElectionFrequencyNumeric);
            this.PoliticsGroupBox.Controls.Add(this.EditCountryElectionDatePicker);
            this.PoliticsGroupBox.Controls.Add(this.EditCountryRulingPartyCombo);
            this.PoliticsGroupBox.Controls.Add(this.label8);
            this.PoliticsGroupBox.Controls.Add(this.label7);
            this.PoliticsGroupBox.Controls.Add(this.EditPartyIdeologyCombo);
            this.PoliticsGroupBox.Controls.Add(this.label6);
            this.PoliticsGroupBox.Location = new System.Drawing.Point(563, 210);
            this.PoliticsGroupBox.Name = "PoliticsGroupBox";
            this.PoliticsGroupBox.Size = new System.Drawing.Size(433, 139);
            this.PoliticsGroupBox.TabIndex = 13;
            this.PoliticsGroupBox.TabStop = false;
            this.PoliticsGroupBox.Text = "Politics";
            // 
            // EditPartyPopularityNumeric
            // 
            this.EditPartyPopularityNumeric.Location = new System.Drawing.Point(377, 111);
            this.EditPartyPopularityNumeric.Name = "EditPartyPopularityNumeric";
            this.EditPartyPopularityNumeric.Size = new System.Drawing.Size(47, 20);
            this.EditPartyPopularityNumeric.TabIndex = 7;
            // 
            // lblCommunismPopularity
            // 
            this.lblCommunismPopularity.AutoSize = true;
            this.lblCommunismPopularity.Location = new System.Drawing.Point(243, 93);
            this.lblCommunismPopularity.Name = "lblCommunismPopularity";
            this.lblCommunismPopularity.Size = new System.Drawing.Size(74, 13);
            this.lblCommunismPopularity.TabIndex = 6;
            this.lblCommunismPopularity.Text = "communism: 0";
            // 
            // lblFascismPopularity
            // 
            this.lblFascismPopularity.AutoSize = true;
            this.lblFascismPopularity.Location = new System.Drawing.Point(164, 93);
            this.lblFascismPopularity.Name = "lblFascismPopularity";
            this.lblFascismPopularity.Size = new System.Drawing.Size(54, 13);
            this.lblFascismPopularity.TabIndex = 6;
            this.lblFascismPopularity.Text = "fascism: 0";
            // 
            // lblDemocraticPopularity
            // 
            this.lblDemocraticPopularity.AutoSize = true;
            this.lblDemocraticPopularity.Location = new System.Drawing.Point(85, 93);
            this.lblDemocraticPopularity.Name = "lblDemocraticPopularity";
            this.lblDemocraticPopularity.Size = new System.Drawing.Size(71, 13);
            this.lblDemocraticPopularity.TabIndex = 6;
            this.lblDemocraticPopularity.Text = "democratic: 0";
            // 
            // lblNeutralityPopularity
            // 
            this.lblNeutralityPopularity.AutoSize = true;
            this.lblNeutralityPopularity.Location = new System.Drawing.Point(6, 93);
            this.lblNeutralityPopularity.Name = "lblNeutralityPopularity";
            this.lblNeutralityPopularity.Size = new System.Drawing.Size(73, 13);
            this.lblNeutralityPopularity.TabIndex = 6;
            this.lblNeutralityPopularity.Text = "neutrality: 100";
            // 
            // EditPartyNameTextBox
            // 
            this.EditPartyNameTextBox.Location = new System.Drawing.Point(133, 110);
            this.EditPartyNameTextBox.Name = "EditPartyNameTextBox";
            this.EditPartyNameTextBox.Size = new System.Drawing.Size(219, 20);
            this.EditPartyNameTextBox.TabIndex = 5;
            // 
            // EditCountryElectionsBannedCheck
            // 
            this.EditCountryElectionsBannedCheck.AutoSize = true;
            this.EditCountryElectionsBannedCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditCountryElectionsBannedCheck.Location = new System.Drawing.Point(312, 25);
            this.EditCountryElectionsBannedCheck.Name = "EditCountryElectionsBannedCheck";
            this.EditCountryElectionsBannedCheck.Size = new System.Drawing.Size(115, 17);
            this.EditCountryElectionsBannedCheck.TabIndex = 4;
            this.EditCountryElectionsBannedCheck.Text = "Elections Allowed?";
            this.EditCountryElectionsBannedCheck.UseVisualStyleBackColor = true;
            // 
            // EditCountryElectionFrequencyNumeric
            // 
            this.EditCountryElectionFrequencyNumeric.Location = new System.Drawing.Point(377, 51);
            this.EditCountryElectionFrequencyNumeric.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.EditCountryElectionFrequencyNumeric.Name = "EditCountryElectionFrequencyNumeric";
            this.EditCountryElectionFrequencyNumeric.Size = new System.Drawing.Size(50, 20);
            this.EditCountryElectionFrequencyNumeric.TabIndex = 3;
            this.EditCountryElectionFrequencyNumeric.Value = new decimal(new int[] {
            48,
            0,
            0,
            0});
            // 
            // EditCountryElectionDatePicker
            // 
            this.EditCountryElectionDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EditCountryElectionDatePicker.Location = new System.Drawing.Point(79, 47);
            this.EditCountryElectionDatePicker.MaxDate = new System.DateTime(1960, 12, 31, 0, 0, 0, 0);
            this.EditCountryElectionDatePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.EditCountryElectionDatePicker.Name = "EditCountryElectionDatePicker";
            this.EditCountryElectionDatePicker.Size = new System.Drawing.Size(124, 20);
            this.EditCountryElectionDatePicker.TabIndex = 2;
            this.EditCountryElectionDatePicker.Value = new System.DateTime(1936, 1, 1, 0, 0, 0, 0);
            // 
            // EditCountryRulingPartyCombo
            // 
            this.EditCountryRulingPartyCombo.FormattingEnabled = true;
            this.EditCountryRulingPartyCombo.Items.AddRange(new object[] {
            "neutrality",
            "democracy",
            "communism",
            "fascism"});
            this.EditCountryRulingPartyCombo.Location = new System.Drawing.Point(79, 23);
            this.EditCountryRulingPartyCombo.Name = "EditCountryRulingPartyCombo";
            this.EditCountryRulingPartyCombo.Size = new System.Drawing.Size(124, 21);
            this.EditCountryRulingPartyCombo.TabIndex = 1;
            this.EditCountryRulingPartyCombo.Text = "neutrality";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(232, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Election Frequency (months)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Last Election:";
            // 
            // EditPartyIdeologyCombo
            // 
            this.EditPartyIdeologyCombo.FormattingEnabled = true;
            this.EditPartyIdeologyCombo.Items.AddRange(new object[] {
            "neutrality",
            "democratic",
            "fascism",
            "communism"});
            this.EditPartyIdeologyCombo.Location = new System.Drawing.Point(6, 109);
            this.EditPartyIdeologyCombo.Name = "EditPartyIdeologyCombo";
            this.EditPartyIdeologyCombo.Size = new System.Drawing.Size(121, 21);
            this.EditPartyIdeologyCombo.TabIndex = 0;
            this.EditPartyIdeologyCombo.Text = "neutrality";
            this.EditPartyIdeologyCombo.SelectedIndexChanged += new System.EventHandler(this.EditPartyIdeologyCombo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ruling Party:";
            // 
            // EditFieldsCheckBox
            // 
            this.EditFieldsCheckBox.AutoSize = true;
            this.EditFieldsCheckBox.Location = new System.Drawing.Point(888, 29);
            this.EditFieldsCheckBox.Name = "EditFieldsCheckBox";
            this.EditFieldsCheckBox.Size = new System.Drawing.Size(80, 17);
            this.EditFieldsCheckBox.TabIndex = 14;
            this.EditFieldsCheckBox.Text = "Edit Fields?";
            this.EditFieldsCheckBox.UseVisualStyleBackColor = true;
            this.EditFieldsCheckBox.CheckedChanged += new System.EventHandler(this.EditFieldsCheckBox_CheckedChanged);
            // 
            // CountryLeaderListBox
            // 
            this.CountryLeaderListBox.FormattingEnabled = true;
            this.CountryLeaderListBox.Location = new System.Drawing.Point(6, 45);
            this.CountryLeaderListBox.Name = "CountryLeaderListBox";
            this.CountryLeaderListBox.Size = new System.Drawing.Size(163, 303);
            this.CountryLeaderListBox.TabIndex = 15;
            this.CountryLeaderListBox.SelectedIndexChanged += new System.EventHandler(this.CountryLeaderListBox_SelectedIndexChanged);
            // 
            // LeaderPicture
            // 
            this.LeaderPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LeaderPicture.Location = new System.Drawing.Point(175, 51);
            this.LeaderPicture.Name = "LeaderPicture";
            this.LeaderPicture.Size = new System.Drawing.Size(81, 96);
            this.LeaderPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeaderPicture.TabIndex = 16;
            this.LeaderPicture.TabStop = false;
            // 
            // LeaderNameLabel
            // 
            this.LeaderNameLabel.AutoSize = true;
            this.LeaderNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaderNameLabel.Location = new System.Drawing.Point(175, 19);
            this.LeaderNameLabel.Name = "LeaderNameLabel";
            this.LeaderNameLabel.Size = new System.Drawing.Size(121, 16);
            this.LeaderNameLabel.TabIndex = 17;
            this.LeaderNameLabel.Text = "[None Selected]";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LeaderTraitListBox);
            this.groupBox2.Controls.Add(this.LeaderSupplyLabel);
            this.groupBox2.Controls.Add(this.LeaderPlanningLabel);
            this.groupBox2.Controls.Add(this.LeaderDefenceLabel);
            this.groupBox2.Controls.Add(this.LeaderAttackLabel);
            this.groupBox2.Controls.Add(this.supplyPicture);
            this.groupBox2.Controls.Add(this.defencePicture);
            this.groupBox2.Controls.Add(this.planningPicture);
            this.groupBox2.Controls.Add(this.attackPicture);
            this.groupBox2.Controls.Add(this.LeaderSkillLabel);
            this.groupBox2.Controls.Add(this.LeaderPicturePathLabel);
            this.groupBox2.Controls.Add(this.LeaderTypeDropdown);
            this.groupBox2.Controls.Add(this.LeaderTypeLabel);
            this.groupBox2.Controls.Add(this.CountryLeaderListBox);
            this.groupBox2.Controls.Add(this.LeaderPicture);
            this.groupBox2.Controls.Add(this.LeaderNameLabel);
            this.groupBox2.Location = new System.Drawing.Point(563, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 357);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Leaders and Commanders";
            // 
            // LeaderTypeDropdown
            // 
            this.LeaderTypeDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LeaderTypeDropdown.FormattingEnabled = true;
            this.LeaderTypeDropdown.Items.AddRange(new object[] {
            "Leaders",
            "Land Commanders",
            "Naval Commanders"});
            this.LeaderTypeDropdown.Location = new System.Drawing.Point(6, 19);
            this.LeaderTypeDropdown.Name = "LeaderTypeDropdown";
            this.LeaderTypeDropdown.Size = new System.Drawing.Size(163, 21);
            this.LeaderTypeDropdown.TabIndex = 19;
            this.LeaderTypeDropdown.SelectedIndexChanged += new System.EventHandler(this.LeaderTypeDropdown_SelectedIndexChanged);
            // 
            // LeaderTypeLabel
            // 
            this.LeaderTypeLabel.AutoSize = true;
            this.LeaderTypeLabel.Location = new System.Drawing.Point(175, 35);
            this.LeaderTypeLabel.Name = "LeaderTypeLabel";
            this.LeaderTypeLabel.Size = new System.Drawing.Size(22, 13);
            this.LeaderTypeLabel.TabIndex = 18;
            this.LeaderTypeLabel.Text = "-----";
            // 
            // LeaderPicturePathLabel
            // 
            this.LeaderPicturePathLabel.AutoSize = true;
            this.LeaderPicturePathLabel.Location = new System.Drawing.Point(175, 150);
            this.LeaderPicturePathLabel.Name = "LeaderPicturePathLabel";
            this.LeaderPicturePathLabel.Size = new System.Drawing.Size(89, 13);
            this.LeaderPicturePathLabel.TabIndex = 20;
            this.LeaderPicturePathLabel.Text = "PICTURE_PATH";
            // 
            // LeaderSkillLabel
            // 
            this.LeaderSkillLabel.AutoSize = true;
            this.LeaderSkillLabel.Location = new System.Drawing.Point(175, 172);
            this.LeaderSkillLabel.Name = "LeaderSkillLabel";
            this.LeaderSkillLabel.Size = new System.Drawing.Size(38, 13);
            this.LeaderSkillLabel.TabIndex = 21;
            this.LeaderSkillLabel.Text = "Skill: 1";
            // 
            // attackPicture
            // 
            this.attackPicture.Image = global::HOI4_State_Editor.Properties.Resources.trait_attack;
            this.attackPicture.Location = new System.Drawing.Point(175, 196);
            this.attackPicture.Name = "attackPicture";
            this.attackPicture.Size = new System.Drawing.Size(27, 25);
            this.attackPicture.TabIndex = 22;
            this.attackPicture.TabStop = false;
            // 
            // defencePicture
            // 
            this.defencePicture.Image = global::HOI4_State_Editor.Properties.Resources.trait_defense;
            this.defencePicture.Location = new System.Drawing.Point(231, 196);
            this.defencePicture.Name = "defencePicture";
            this.defencePicture.Size = new System.Drawing.Size(27, 25);
            this.defencePicture.TabIndex = 22;
            this.defencePicture.TabStop = false;
            // 
            // planningPicture
            // 
            this.planningPicture.Image = global::HOI4_State_Editor.Properties.Resources.trait_planning;
            this.planningPicture.Location = new System.Drawing.Point(287, 196);
            this.planningPicture.Name = "planningPicture";
            this.planningPicture.Size = new System.Drawing.Size(27, 25);
            this.planningPicture.TabIndex = 22;
            this.planningPicture.TabStop = false;
            // 
            // supplyPicture
            // 
            this.supplyPicture.Image = global::HOI4_State_Editor.Properties.Resources.trait_logistics;
            this.supplyPicture.Location = new System.Drawing.Point(341, 196);
            this.supplyPicture.Name = "supplyPicture";
            this.supplyPicture.Size = new System.Drawing.Size(27, 25);
            this.supplyPicture.TabIndex = 22;
            this.supplyPicture.TabStop = false;
            // 
            // LeaderAttackLabel
            // 
            this.LeaderAttackLabel.AutoSize = true;
            this.LeaderAttackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaderAttackLabel.Location = new System.Drawing.Point(209, 202);
            this.LeaderAttackLabel.Name = "LeaderAttackLabel";
            this.LeaderAttackLabel.Size = new System.Drawing.Size(18, 13);
            this.LeaderAttackLabel.TabIndex = 23;
            this.LeaderAttackLabel.Text = "-1";
            // 
            // LeaderDefenceLabel
            // 
            this.LeaderDefenceLabel.AutoSize = true;
            this.LeaderDefenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaderDefenceLabel.Location = new System.Drawing.Point(265, 202);
            this.LeaderDefenceLabel.Name = "LeaderDefenceLabel";
            this.LeaderDefenceLabel.Size = new System.Drawing.Size(18, 13);
            this.LeaderDefenceLabel.TabIndex = 23;
            this.LeaderDefenceLabel.Text = "-1";
            // 
            // LeaderPlanningLabel
            // 
            this.LeaderPlanningLabel.AutoSize = true;
            this.LeaderPlanningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaderPlanningLabel.Location = new System.Drawing.Point(319, 202);
            this.LeaderPlanningLabel.Name = "LeaderPlanningLabel";
            this.LeaderPlanningLabel.Size = new System.Drawing.Size(18, 13);
            this.LeaderPlanningLabel.TabIndex = 23;
            this.LeaderPlanningLabel.Text = "-1";
            // 
            // LeaderSupplyLabel
            // 
            this.LeaderSupplyLabel.AutoSize = true;
            this.LeaderSupplyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaderSupplyLabel.Location = new System.Drawing.Point(373, 202);
            this.LeaderSupplyLabel.Name = "LeaderSupplyLabel";
            this.LeaderSupplyLabel.Size = new System.Drawing.Size(18, 13);
            this.LeaderSupplyLabel.TabIndex = 23;
            this.LeaderSupplyLabel.Text = "-1";
            // 
            // LeaderTraitListBox
            // 
            this.LeaderTraitListBox.FormattingEnabled = true;
            this.LeaderTraitListBox.Location = new System.Drawing.Point(262, 51);
            this.LeaderTraitListBox.Name = "LeaderTraitListBox";
            this.LeaderTraitListBox.Size = new System.Drawing.Size(120, 95);
            this.LeaderTraitListBox.TabIndex = 24;
            // 
            // CountryEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 729);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.EditFieldsCheckBox);
            this.Controls.Add(this.PoliticsGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCountryTag);
            this.Controls.Add(this.lblCapital);
            this.Controls.Add(this.CountryPoliticsBox);
            this.Controls.Add(this.CountryColourBox);
            this.Controls.Add(this.NewCountryButton);
            this.Controls.Add(this.CountrySeachBox);
            this.Controls.Add(this.CommunistNameLabel);
            this.Controls.Add(this.FascistNameLabel);
            this.Controls.Add(this.DemocracyNameLabel);
            this.Controls.Add(this.NeutralNameLabel);
            this.Controls.Add(this.CommunistFlagPicture);
            this.Controls.Add(this.FascistFlagPicture);
            this.Controls.Add(this.DemocracyFlagPicture);
            this.Controls.Add(this.NeutralFlagPicture);
            this.Controls.Add(this.CountryList);
            this.Name = "CountryEditorForm";
            this.Text = "CountryEditorForm";
            this.Load += new System.EventHandler(this.CountryEditorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NeutralFlagPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DemocracyFlagPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FascistFlagPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommunistFlagPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryColourBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PoliticsGroupBox.ResumeLayout(false);
            this.PoliticsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditPartyPopularityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditCountryElectionFrequencyNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeaderPicture)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attackPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defencePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planningPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CountryList;
        private System.Windows.Forms.PictureBox NeutralFlagPicture;
        private System.Windows.Forms.PictureBox DemocracyFlagPicture;
        private System.Windows.Forms.PictureBox FascistFlagPicture;
        private System.Windows.Forms.PictureBox CommunistFlagPicture;
        private System.Windows.Forms.Label NeutralNameLabel;
        private System.Windows.Forms.Label DemocracyNameLabel;
        private System.Windows.Forms.Label FascistNameLabel;
        private System.Windows.Forms.Label CommunistNameLabel;
        private System.Windows.Forms.TextBox CountrySeachBox;
        private System.Windows.Forms.Button NewCountryButton;
        private System.Windows.Forms.PictureBox CountryColourBox;
        private System.Windows.Forms.RichTextBox CountryPoliticsBox;
        private System.Windows.Forms.Label lblCapital;
        private System.Windows.Forms.Label lblCountryTag;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CountryLocalNameBox;
        private System.Windows.Forms.TextBox CountryLocalDefinitiveBox;
        private System.Windows.Forms.TextBox CountryLocalAdjectiveBox;
        private System.Windows.Forms.ComboBox CountryIdeologyLocalCombo;
        private System.Windows.Forms.GroupBox PoliticsGroupBox;
        private System.Windows.Forms.NumericUpDown EditPartyPopularityNumeric;
        private System.Windows.Forms.Label lblCommunismPopularity;
        private System.Windows.Forms.Label lblFascismPopularity;
        private System.Windows.Forms.Label lblDemocraticPopularity;
        private System.Windows.Forms.Label lblNeutralityPopularity;
        private System.Windows.Forms.TextBox EditPartyNameTextBox;
        private System.Windows.Forms.CheckBox EditCountryElectionsBannedCheck;
        private System.Windows.Forms.NumericUpDown EditCountryElectionFrequencyNumeric;
        private System.Windows.Forms.DateTimePicker EditCountryElectionDatePicker;
        private System.Windows.Forms.ComboBox EditCountryRulingPartyCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox EditPartyIdeologyCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox EditFieldsCheckBox;
        private System.Windows.Forms.ListBox CountryLeaderListBox;
        private System.Windows.Forms.PictureBox LeaderPicture;
        private System.Windows.Forms.Label LeaderNameLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LeaderTypeLabel;
        private System.Windows.Forms.ComboBox LeaderTypeDropdown;
        private System.Windows.Forms.Label LeaderPicturePathLabel;
        private System.Windows.Forms.Label LeaderSkillLabel;
        private System.Windows.Forms.PictureBox attackPicture;
        private System.Windows.Forms.PictureBox defencePicture;
        private System.Windows.Forms.PictureBox supplyPicture;
        private System.Windows.Forms.PictureBox planningPicture;
        private System.Windows.Forms.Label LeaderSupplyLabel;
        private System.Windows.Forms.Label LeaderPlanningLabel;
        private System.Windows.Forms.Label LeaderDefenceLabel;
        private System.Windows.Forms.Label LeaderAttackLabel;
        private System.Windows.Forms.ListBox LeaderTraitListBox;
    }
}