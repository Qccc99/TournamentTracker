namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.tournamentNameValue = new System.Windows.Forms.TextBox();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.createNewTeamLabelLink = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.tournamentMembersLabel = new System.Windows.Forms.Label();
            this.tournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.RemoveSelectedPlayersButton = new System.Windows.Forms.Button();
            this.removeSelectedPrizeButton = new System.Windows.Forms.Button();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.prizesLabel = new System.Windows.Forms.Label();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerLabel.Location = new System.Drawing.Point(26, 28);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(403, 62);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Create Tournament";
            this.headerLabel.Click += new System.EventHandler(this.headerLabel_Click);
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tournamentNameLabel.Location = new System.Drawing.Point(52, 128);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(290, 45);
            this.tournamentNameLabel.TabIndex = 27;
            this.tournamentNameLabel.Text = "Tournament Name";
            // 
            // tournamentNameValue
            // 
            this.tournamentNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentNameValue.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentNameValue.Location = new System.Drawing.Point(52, 188);
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Size = new System.Drawing.Size(460, 51);
            this.tournamentNameValue.TabIndex = 28;
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entryFeeValue.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entryFeeValue.Location = new System.Drawing.Point(232, 261);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(265, 51);
            this.entryFeeValue.TabIndex = 30;
            this.entryFeeValue.Text = "0";
            this.entryFeeValue.TextChanged += new System.EventHandler(this.placeNumberValue_TextChanged);
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entryFeeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.entryFeeLabel.Location = new System.Drawing.Point(52, 263);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(153, 45);
            this.entryFeeLabel.TabIndex = 29;
            this.entryFeeLabel.Text = "Entry Fee";
            this.entryFeeLabel.Click += new System.EventHandler(this.placeNumberLabel_Click);
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.selectTeamLabel.Location = new System.Drawing.Point(52, 356);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(191, 45);
            this.selectTeamLabel.TabIndex = 32;
            this.selectTeamLabel.Text = "Select Team";
            // 
            // selectTeamDropDown
            // 
            this.selectTeamDropDown.FormattingEnabled = true;
            this.selectTeamDropDown.Location = new System.Drawing.Point(52, 419);
            this.selectTeamDropDown.Name = "selectTeamDropDown";
            this.selectTeamDropDown.Size = new System.Drawing.Size(460, 45);
            this.selectTeamDropDown.TabIndex = 31;
            this.selectTeamDropDown.SelectedIndexChanged += new System.EventHandler(this.selectTeamDropDown_SelectedIndexChanged);
            // 
            // createNewTeamLabelLink
            // 
            this.createNewTeamLabelLink.AutoSize = true;
            this.createNewTeamLabelLink.Location = new System.Drawing.Point(372, 366);
            this.createNewTeamLabelLink.Name = "createNewTeamLabelLink";
            this.createNewTeamLabelLink.Size = new System.Drawing.Size(149, 38);
            this.createNewTeamLabelLink.TabIndex = 33;
            this.createNewTeamLabelLink.TabStop = true;
            this.createNewTeamLabelLink.Text = "createNew";
            this.createNewTeamLabelLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewTeamLabelLink_LinkClicked);
            // 
            // addTeamButton
            // 
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addTeamButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addTeamButton.Location = new System.Drawing.Point(171, 525);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(230, 59);
            this.addTeamButton.TabIndex = 34;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createPrizeButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createPrizeButton.Location = new System.Drawing.Point(171, 602);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(230, 59);
            this.createPrizeButton.TabIndex = 35;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // tournamentMembersLabel
            // 
            this.tournamentMembersLabel.AutoSize = true;
            this.tournamentMembersLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentMembersLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tournamentMembersLabel.Location = new System.Drawing.Point(621, 128);
            this.tournamentMembersLabel.Name = "tournamentMembersLabel";
            this.tournamentMembersLabel.Size = new System.Drawing.Size(242, 45);
            this.tournamentMembersLabel.TabIndex = 36;
            this.tournamentMembersLabel.Text = "Teams / Players";
            // 
            // tournamentPlayersListBox
            // 
            this.tournamentPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentPlayersListBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentPlayersListBox.FormattingEnabled = true;
            this.tournamentPlayersListBox.ItemHeight = 37;
            this.tournamentPlayersListBox.Location = new System.Drawing.Point(631, 189);
            this.tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            this.tournamentPlayersListBox.Size = new System.Drawing.Size(339, 224);
            this.tournamentPlayersListBox.TabIndex = 37;
            // 
            // RemoveSelectedPlayersButton
            // 
            this.RemoveSelectedPlayersButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.RemoveSelectedPlayersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.RemoveSelectedPlayersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.RemoveSelectedPlayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveSelectedPlayersButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemoveSelectedPlayersButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.RemoveSelectedPlayersButton.Location = new System.Drawing.Point(1004, 261);
            this.RemoveSelectedPlayersButton.Name = "RemoveSelectedPlayersButton";
            this.RemoveSelectedPlayersButton.Size = new System.Drawing.Size(139, 93);
            this.RemoveSelectedPlayersButton.TabIndex = 38;
            this.RemoveSelectedPlayersButton.Text = "Remove Selected";
            this.RemoveSelectedPlayersButton.UseVisualStyleBackColor = true;
            this.RemoveSelectedPlayersButton.Click += new System.EventHandler(this.RemoveSelectedPlayersButton_Click);
            // 
            // removeSelectedPrizeButton
            // 
            this.removeSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.removeSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.removeSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.removeSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeSelectedPrizeButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.removeSelectedPrizeButton.Location = new System.Drawing.Point(1004, 573);
            this.removeSelectedPrizeButton.Name = "removeSelectedPrizeButton";
            this.removeSelectedPrizeButton.Size = new System.Drawing.Size(139, 98);
            this.removeSelectedPrizeButton.TabIndex = 41;
            this.removeSelectedPrizeButton.Text = "Remove Selected";
            this.removeSelectedPrizeButton.UseVisualStyleBackColor = true;
            this.removeSelectedPrizeButton.Click += new System.EventHandler(this.removeSelectedPrizeButton_Click);
            // 
            // prizesListBox
            // 
            this.prizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizesListBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 37;
            this.prizesListBox.Location = new System.Drawing.Point(631, 497);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(339, 224);
            this.prizesListBox.TabIndex = 40;
            this.prizesListBox.SelectedIndexChanged += new System.EventHandler(this.prizesListBox_SelectedIndexChanged);
            // 
            // prizesLabel
            // 
            this.prizesLabel.AutoSize = true;
            this.prizesLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizesLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.prizesLabel.Location = new System.Drawing.Point(621, 436);
            this.prizesLabel.Name = "prizesLabel";
            this.prizesLabel.Size = new System.Drawing.Size(103, 45);
            this.prizesLabel.TabIndex = 39;
            this.prizesLabel.Text = "Prizes";
            this.prizesLabel.Click += new System.EventHandler(this.prizesLabel_Click);
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createTournamentButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createTournamentButton.Location = new System.Drawing.Point(348, 752);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(475, 59);
            this.createTournamentButton.TabIndex = 42;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            this.createTournamentButton.Click += new System.EventHandler(this.createTournamentButton_Click);
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1170, 832);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.removeSelectedPrizeButton);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.prizesLabel);
            this.Controls.Add(this.RemoveSelectedPlayersButton);
            this.Controls.Add(this.tournamentPlayersListBox);
            this.Controls.Add(this.tournamentMembersLabel);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.createNewTeamLabelLink);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.selectTeamDropDown);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private Label tournamentNameLabel;
        private TextBox tournamentNameValue;
        private TextBox entryFeeValue;
        private Label entryFeeLabel;
        private Label selectTeamLabel;
        private ComboBox selectTeamDropDown;
        private LinkLabel createNewTeamLabelLink;
        private Button addTeamButton;
        private Button createPrizeButton;
        private Label tournamentMembersLabel;
        private ListBox tournamentPlayersListBox;
        private Button RemoveSelectedPlayersButton;
        private Button removeSelectedPrizeButton;
        private ListBox prizesListBox;
        private Label prizesLabel;
        private Button createTournamentButton;
    }
}