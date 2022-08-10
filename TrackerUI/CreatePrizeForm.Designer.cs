namespace TrackerUI
{
    partial class CreatePrizeForm
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
            this.prizePercentageValue = new System.Windows.Forms.TextBox();
            this.prizePercentageLabel = new System.Windows.Forms.Label();
            this.prizeAmountValue = new System.Windows.Forms.TextBox();
            this.prizeAmountLabel = new System.Windows.Forms.Label();
            this.placeNameValue = new System.Windows.Forms.TextBox();
            this.placeNameLabel = new System.Windows.Forms.Label();
            this.placeNumberValue = new System.Windows.Forms.TextBox();
            this.placeNumberLabel = new System.Windows.Forms.Label();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.orLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerLabel.Location = new System.Drawing.Point(31, 35);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(267, 62);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Create Prize";
            // 
            // prizePercentageValue
            // 
            this.prizePercentageValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizePercentageValue.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizePercentageValue.Location = new System.Drawing.Point(325, 424);
            this.prizePercentageValue.Name = "prizePercentageValue";
            this.prizePercentageValue.Size = new System.Drawing.Size(265, 51);
            this.prizePercentageValue.TabIndex = 30;
            this.prizePercentageValue.Text = "0";
            this.prizePercentageValue.TextChanged += new System.EventHandler(this.cellphoneValue_TextChanged);
            // 
            // prizePercentageLabel
            // 
            this.prizePercentageLabel.AutoSize = true;
            this.prizePercentageLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizePercentageLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.prizePercentageLabel.Location = new System.Drawing.Point(45, 430);
            this.prizePercentageLabel.Name = "prizePercentageLabel";
            this.prizePercentageLabel.Size = new System.Drawing.Size(258, 45);
            this.prizePercentageLabel.TabIndex = 29;
            this.prizePercentageLabel.Text = "Prize Percentage";
            this.prizePercentageLabel.Click += new System.EventHandler(this.cellphoneLabel_Click);
            // 
            // prizeAmountValue
            // 
            this.prizeAmountValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizeAmountValue.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizeAmountValue.Location = new System.Drawing.Point(325, 271);
            this.prizeAmountValue.Name = "prizeAmountValue";
            this.prizeAmountValue.Size = new System.Drawing.Size(265, 51);
            this.prizeAmountValue.TabIndex = 28;
            this.prizeAmountValue.Text = "0";
            this.prizeAmountValue.TextChanged += new System.EventHandler(this.emailValue_TextChanged);
            // 
            // prizeAmountLabel
            // 
            this.prizeAmountLabel.AutoSize = true;
            this.prizeAmountLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizeAmountLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.prizeAmountLabel.Location = new System.Drawing.Point(45, 277);
            this.prizeAmountLabel.Name = "prizeAmountLabel";
            this.prizeAmountLabel.Size = new System.Drawing.Size(215, 45);
            this.prizeAmountLabel.TabIndex = 27;
            this.prizeAmountLabel.Text = "Prize Amount";
            this.prizeAmountLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // placeNameValue
            // 
            this.placeNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.placeNameValue.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placeNameValue.Location = new System.Drawing.Point(325, 208);
            this.placeNameValue.Name = "placeNameValue";
            this.placeNameValue.Size = new System.Drawing.Size(265, 51);
            this.placeNameValue.TabIndex = 26;
            this.placeNameValue.TextChanged += new System.EventHandler(this.LastNameValue_TextChanged);
            // 
            // placeNameLabel
            // 
            this.placeNameLabel.AutoSize = true;
            this.placeNameLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placeNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.placeNameLabel.Location = new System.Drawing.Point(45, 214);
            this.placeNameLabel.Name = "placeNameLabel";
            this.placeNameLabel.Size = new System.Drawing.Size(191, 45);
            this.placeNameLabel.TabIndex = 25;
            this.placeNameLabel.Text = "Place Name";
            this.placeNameLabel.Click += new System.EventHandler(this.lastNameLabel_Click);
            // 
            // placeNumberValue
            // 
            this.placeNumberValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.placeNumberValue.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placeNumberValue.Location = new System.Drawing.Point(325, 146);
            this.placeNumberValue.Name = "placeNumberValue";
            this.placeNumberValue.Size = new System.Drawing.Size(265, 51);
            this.placeNumberValue.TabIndex = 24;
            this.placeNumberValue.TextChanged += new System.EventHandler(this.firstNameValue_TextChanged);
            // 
            // placeNumberLabel
            // 
            this.placeNumberLabel.AutoSize = true;
            this.placeNumberLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placeNumberLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.placeNumberLabel.Location = new System.Drawing.Point(45, 152);
            this.placeNumberLabel.Name = "placeNumberLabel";
            this.placeNumberLabel.Size = new System.Drawing.Size(223, 45);
            this.placeNumberLabel.TabIndex = 23;
            this.placeNumberLabel.Text = "Place Number";
            this.placeNumberLabel.Click += new System.EventHandler(this.firstNameLabel_Click);
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createPrizeButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createPrizeButton.Location = new System.Drawing.Point(107, 559);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(442, 59);
            this.createPrizeButton.TabIndex = 34;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.orLabel.Location = new System.Drawing.Point(266, 356);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(76, 45);
            this.orLabel.TabIndex = 35;
            this.orLabel.Text = "-or-";
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(655, 662);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.prizePercentageValue);
            this.Controls.Add(this.prizePercentageLabel);
            this.Controls.Add(this.prizeAmountValue);
            this.Controls.Add(this.prizeAmountLabel);
            this.Controls.Add(this.placeNameValue);
            this.Controls.Add(this.placeNameLabel);
            this.Controls.Add(this.placeNumberValue);
            this.Controls.Add(this.placeNumberLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreatePrizeForm";
            this.Text = "Create Prize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private TextBox prizePercentageValue;
        private Label prizePercentageLabel;
        private TextBox prizeAmountValue;
        private Label prizeAmountLabel;
        private TextBox placeNameValue;
        private Label placeNameLabel;
        private TextBox placeNumberValue;
        private Label placeNumberLabel;
        private Button createPrizeButton;
        private Label orLabel;
    }
}