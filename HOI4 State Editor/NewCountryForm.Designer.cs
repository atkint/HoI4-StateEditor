namespace HOI4_State_Editor
{
    partial class NewCountryForm
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
            this.NewCountryTagBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNeutralityFlag = new System.Windows.Forms.Button();
            this.NewCountryFlagPicture = new System.Windows.Forms.PictureBox();
            this.CreateNewCountryButton = new System.Windows.Forms.Button();
            this.PoliticsGroupBox = new System.Windows.Forms.GroupBox();
            this.PartyPopularityNumeric = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PartyNameTextBox = new System.Windows.Forms.TextBox();
            this.NewCountryElectionsBannedCheck = new System.Windows.Forms.CheckBox();
            this.NewCountryElectionFrequencyNumeric = new System.Windows.Forms.NumericUpDown();
            this.ElectionDatePicker = new System.Windows.Forms.DateTimePicker();
            this.NewCountryRulingPartyCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PartyIdeologyCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CountryNameGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CountryLocalNameBox = new System.Windows.Forms.TextBox();
            this.CountryLocalDefinitiveBox = new System.Windows.Forms.TextBox();
            this.CountryLocalAdjectiveBox = new System.Windows.Forms.TextBox();
            this.CountryIdeologyLocalCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NewCountryFlagPicture)).BeginInit();
            this.PoliticsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartyPopularityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewCountryElectionFrequencyNumeric)).BeginInit();
            this.CountryNameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewCountryTagBox
            // 
            this.NewCountryTagBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NewCountryTagBox.Location = new System.Drawing.Point(50, 12);
            this.NewCountryTagBox.MaxLength = 3;
            this.NewCountryTagBox.Name = "NewCountryTagBox";
            this.NewCountryTagBox.Size = new System.Drawing.Size(39, 20);
            this.NewCountryTagBox.TabIndex = 2;
            this.NewCountryTagBox.TextChanged += new System.EventHandler(this.NewCountryTagBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tag";
            // 
            // btnNeutralityFlag
            // 
            this.btnNeutralityFlag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnNeutralityFlag.Location = new System.Drawing.Point(286, 47);
            this.btnNeutralityFlag.Name = "btnNeutralityFlag";
            this.btnNeutralityFlag.Size = new System.Drawing.Size(82, 23);
            this.btnNeutralityFlag.TabIndex = 5;
            this.btnNeutralityFlag.Text = "Select Flag...";
            this.btnNeutralityFlag.UseVisualStyleBackColor = false;
            this.btnNeutralityFlag.Click += new System.EventHandler(this.btnNeutralityFlag_Click);
            // 
            // NewCountryFlagPicture
            // 
            this.NewCountryFlagPicture.Location = new System.Drawing.Point(286, 74);
            this.NewCountryFlagPicture.Name = "NewCountryFlagPicture";
            this.NewCountryFlagPicture.Size = new System.Drawing.Size(82, 52);
            this.NewCountryFlagPicture.TabIndex = 6;
            this.NewCountryFlagPicture.TabStop = false;
            // 
            // CreateNewCountryButton
            // 
            this.CreateNewCountryButton.Location = new System.Drawing.Point(359, 369);
            this.CreateNewCountryButton.Name = "CreateNewCountryButton";
            this.CreateNewCountryButton.Size = new System.Drawing.Size(95, 37);
            this.CreateNewCountryButton.TabIndex = 7;
            this.CreateNewCountryButton.Text = "Create Country";
            this.CreateNewCountryButton.UseVisualStyleBackColor = true;
            this.CreateNewCountryButton.Click += new System.EventHandler(this.CreateNewCountryButton_Click);
            // 
            // PoliticsGroupBox
            // 
            this.PoliticsGroupBox.Controls.Add(this.PartyPopularityNumeric);
            this.PoliticsGroupBox.Controls.Add(this.label11);
            this.PoliticsGroupBox.Controls.Add(this.label10);
            this.PoliticsGroupBox.Controls.Add(this.label9);
            this.PoliticsGroupBox.Controls.Add(this.label4);
            this.PoliticsGroupBox.Controls.Add(this.PartyNameTextBox);
            this.PoliticsGroupBox.Controls.Add(this.NewCountryElectionsBannedCheck);
            this.PoliticsGroupBox.Controls.Add(this.NewCountryElectionFrequencyNumeric);
            this.PoliticsGroupBox.Controls.Add(this.ElectionDatePicker);
            this.PoliticsGroupBox.Controls.Add(this.NewCountryRulingPartyCombo);
            this.PoliticsGroupBox.Controls.Add(this.label8);
            this.PoliticsGroupBox.Controls.Add(this.label7);
            this.PoliticsGroupBox.Controls.Add(this.PartyIdeologyCombo);
            this.PoliticsGroupBox.Controls.Add(this.label6);
            this.PoliticsGroupBox.Location = new System.Drawing.Point(12, 186);
            this.PoliticsGroupBox.Name = "PoliticsGroupBox";
            this.PoliticsGroupBox.Size = new System.Drawing.Size(429, 136);
            this.PoliticsGroupBox.TabIndex = 8;
            this.PoliticsGroupBox.TabStop = false;
            this.PoliticsGroupBox.Text = "Politics";
            // 
            // PartyPopularityNumeric
            // 
            this.PartyPopularityNumeric.Location = new System.Drawing.Point(347, 109);
            this.PartyPopularityNumeric.Name = "PartyPopularityNumeric";
            this.PartyPopularityNumeric.Size = new System.Drawing.Size(47, 20);
            this.PartyPopularityNumeric.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(243, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "communism: 0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(164, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "fascism: 0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(85, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "democratic: 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "neutrality: 100";
            // 
            // PartyNameTextBox
            // 
            this.PartyNameTextBox.Location = new System.Drawing.Point(133, 110);
            this.PartyNameTextBox.Name = "PartyNameTextBox";
            this.PartyNameTextBox.Size = new System.Drawing.Size(184, 20);
            this.PartyNameTextBox.TabIndex = 5;
            this.PartyNameTextBox.TextChanged += new System.EventHandler(this.PartyNameTextBox_TextChanged);
            // 
            // NewCountryElectionsBannedCheck
            // 
            this.NewCountryElectionsBannedCheck.AutoSize = true;
            this.NewCountryElectionsBannedCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NewCountryElectionsBannedCheck.Location = new System.Drawing.Point(298, 22);
            this.NewCountryElectionsBannedCheck.Name = "NewCountryElectionsBannedCheck";
            this.NewCountryElectionsBannedCheck.Size = new System.Drawing.Size(115, 17);
            this.NewCountryElectionsBannedCheck.TabIndex = 4;
            this.NewCountryElectionsBannedCheck.Text = "Elections Allowed?";
            this.NewCountryElectionsBannedCheck.UseVisualStyleBackColor = true;
            // 
            // NewCountryElectionFrequencyNumeric
            // 
            this.NewCountryElectionFrequencyNumeric.Location = new System.Drawing.Point(363, 47);
            this.NewCountryElectionFrequencyNumeric.Name = "NewCountryElectionFrequencyNumeric";
            this.NewCountryElectionFrequencyNumeric.Size = new System.Drawing.Size(50, 20);
            this.NewCountryElectionFrequencyNumeric.TabIndex = 3;
            this.NewCountryElectionFrequencyNumeric.Value = new decimal(new int[] {
            48,
            0,
            0,
            0});
            // 
            // ElectionDatePicker
            // 
            this.ElectionDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ElectionDatePicker.Location = new System.Drawing.Point(79, 47);
            this.ElectionDatePicker.MaxDate = new System.DateTime(1960, 12, 31, 0, 0, 0, 0);
            this.ElectionDatePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.ElectionDatePicker.Name = "ElectionDatePicker";
            this.ElectionDatePicker.Size = new System.Drawing.Size(124, 20);
            this.ElectionDatePicker.TabIndex = 2;
            this.ElectionDatePicker.Value = new System.DateTime(1936, 1, 1, 0, 0, 0, 0);
            // 
            // NewCountryRulingPartyCombo
            // 
            this.NewCountryRulingPartyCombo.FormattingEnabled = true;
            this.NewCountryRulingPartyCombo.Items.AddRange(new object[] {
            "neutrality",
            "democracy",
            "communism",
            "fascism"});
            this.NewCountryRulingPartyCombo.Location = new System.Drawing.Point(79, 23);
            this.NewCountryRulingPartyCombo.Name = "NewCountryRulingPartyCombo";
            this.NewCountryRulingPartyCombo.Size = new System.Drawing.Size(124, 21);
            this.NewCountryRulingPartyCombo.TabIndex = 1;
            this.NewCountryRulingPartyCombo.Text = "neutrality";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 49);
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
            // PartyIdeologyCombo
            // 
            this.PartyIdeologyCombo.FormattingEnabled = true;
            this.PartyIdeologyCombo.Items.AddRange(new object[] {
            "neutrality",
            "democratic",
            "fascism",
            "communism"});
            this.PartyIdeologyCombo.Location = new System.Drawing.Point(6, 109);
            this.PartyIdeologyCombo.Name = "PartyIdeologyCombo";
            this.PartyIdeologyCombo.Size = new System.Drawing.Size(121, 21);
            this.PartyIdeologyCombo.TabIndex = 0;
            this.PartyIdeologyCombo.Text = "neutrality";
            this.PartyIdeologyCombo.SelectedIndexChanged += new System.EventHandler(this.PartyIdeologyCombo_SelectedIndexChanged);
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
            // CountryNameGroupBox
            // 
            this.CountryNameGroupBox.Controls.Add(this.label3);
            this.CountryNameGroupBox.Controls.Add(this.label2);
            this.CountryNameGroupBox.Controls.Add(this.label1);
            this.CountryNameGroupBox.Controls.Add(this.CountryLocalNameBox);
            this.CountryNameGroupBox.Controls.Add(this.CountryLocalDefinitiveBox);
            this.CountryNameGroupBox.Controls.Add(this.CountryLocalAdjectiveBox);
            this.CountryNameGroupBox.Controls.Add(this.CountryIdeologyLocalCombo);
            this.CountryNameGroupBox.Location = new System.Drawing.Point(12, 38);
            this.CountryNameGroupBox.Name = "CountryNameGroupBox";
            this.CountryNameGroupBox.Size = new System.Drawing.Size(268, 129);
            this.CountryNameGroupBox.TabIndex = 13;
            this.CountryNameGroupBox.TabStop = false;
            this.CountryNameGroupBox.Text = "Country Name";
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
            // NewCountryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 418);
            this.Controls.Add(this.CountryNameGroupBox);
            this.Controls.Add(this.PoliticsGroupBox);
            this.Controls.Add(this.CreateNewCountryButton);
            this.Controls.Add(this.NewCountryFlagPicture);
            this.Controls.Add(this.btnNeutralityFlag);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NewCountryTagBox);
            this.Name = "NewCountryForm";
            this.Text = "NewCountryForm";
            ((System.ComponentModel.ISupportInitialize)(this.NewCountryFlagPicture)).EndInit();
            this.PoliticsGroupBox.ResumeLayout(false);
            this.PoliticsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartyPopularityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewCountryElectionFrequencyNumeric)).EndInit();
            this.CountryNameGroupBox.ResumeLayout(false);
            this.CountryNameGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NewCountryTagBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNeutralityFlag;
        private System.Windows.Forms.PictureBox NewCountryFlagPicture;
        private System.Windows.Forms.Button CreateNewCountryButton;
        private System.Windows.Forms.GroupBox PoliticsGroupBox;
        private System.Windows.Forms.ComboBox NewCountryRulingPartyCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ElectionDatePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NewCountryElectionFrequencyNumeric;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox NewCountryElectionsBannedCheck;
        private System.Windows.Forms.GroupBox CountryNameGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CountryLocalNameBox;
        private System.Windows.Forms.TextBox CountryLocalDefinitiveBox;
        private System.Windows.Forms.TextBox CountryLocalAdjectiveBox;
        private System.Windows.Forms.ComboBox CountryIdeologyLocalCombo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PartyNameTextBox;
        private System.Windows.Forms.ComboBox PartyIdeologyCombo;
        private System.Windows.Forms.NumericUpDown PartyPopularityNumeric;
    }
}