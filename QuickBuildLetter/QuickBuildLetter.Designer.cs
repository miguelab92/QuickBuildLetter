namespace QuickBuildLetter
{
    partial class QuickBuildLetter
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
            this.positiveButton = new System.Windows.Forms.RadioButton();
            this.negativeButton = new System.Windows.Forms.RadioButton();
            this.serverNameButton = new System.Windows.Forms.CheckBox();
            this.businessText = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.runButton = new System.Windows.Forms.Button();
            this.saveLocation = new System.Windows.Forms.TextBox();
            this.folderSelectButton = new System.Windows.Forms.Button();
            this.businessLabel = new System.Windows.Forms.Label();
            this.saveLabel = new System.Windows.Forms.Label();
            this.serverNameText = new System.Windows.Forms.TextBox();
            this.dateButton = new System.Windows.Forms.CheckBox();
            this.experienceLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // positiveButton
            // 
            this.positiveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.positiveButton.AutoSize = true;
            this.positiveButton.Checked = true;
            this.positiveButton.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positiveButton.ForeColor = System.Drawing.Color.White;
            this.positiveButton.Location = new System.Drawing.Point(164, 19);
            this.positiveButton.Name = "positiveButton";
            this.positiveButton.Size = new System.Drawing.Size(81, 18);
            this.positiveButton.TabIndex = 12;
            this.positiveButton.TabStop = true;
            this.positiveButton.Text = "Positive";
            this.positiveButton.UseVisualStyleBackColor = true;
            // 
            // negativeButton
            // 
            this.negativeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.negativeButton.AutoSize = true;
            this.negativeButton.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.negativeButton.ForeColor = System.Drawing.Color.White;
            this.negativeButton.Location = new System.Drawing.Point(288, 19);
            this.negativeButton.Name = "negativeButton";
            this.negativeButton.Size = new System.Drawing.Size(81, 18);
            this.negativeButton.TabIndex = 14;
            this.negativeButton.TabStop = true;
            this.negativeButton.Text = "Negative";
            this.negativeButton.UseVisualStyleBackColor = true;
            // 
            // serverNameButton
            // 
            this.serverNameButton.AutoSize = true;
            this.serverNameButton.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverNameButton.ForeColor = System.Drawing.Color.White;
            this.serverNameButton.Location = new System.Drawing.Point(10, 137);
            this.serverNameButton.Name = "serverNameButton";
            this.serverNameButton.Size = new System.Drawing.Size(110, 18);
            this.serverNameButton.TabIndex = 3;
            this.serverNameButton.Text = "Include Name";
            this.serverNameButton.UseVisualStyleBackColor = true;
            this.serverNameButton.CheckedChanged += new System.EventHandler(this.serverNameButton_CheckedChanged);
            this.serverNameButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.serverNameButton_KeyDown);
            // 
            // businessText
            // 
            this.businessText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.businessText.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessText.Location = new System.Drawing.Point(126, 57);
            this.businessText.Name = "businessText";
            this.businessText.Size = new System.Drawing.Size(273, 20);
            this.businessText.TabIndex = 0;
            this.businessText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.businessText_KeyDown);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(126, 96);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(273, 20);
            this.dateTimePicker.TabIndex = 2;
            // 
            // runButton
            // 
            this.runButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.runButton.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runButton.Location = new System.Drawing.Point(164, 211);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(90, 23);
            this.runButton.TabIndex = 10;
            this.runButton.Text = "Generate";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // saveLocation
            // 
            this.saveLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveLocation.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveLocation.Location = new System.Drawing.Point(126, 174);
            this.saveLocation.Name = "saveLocation";
            this.saveLocation.Size = new System.Drawing.Size(243, 20);
            this.saveLocation.TabIndex = 6;
            this.saveLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.saveLocation_KeyDown);
            // 
            // folderSelectButton
            // 
            this.folderSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.folderSelectButton.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderSelectButton.Location = new System.Drawing.Point(375, 173);
            this.folderSelectButton.Name = "folderSelectButton";
            this.folderSelectButton.Size = new System.Drawing.Size(24, 23);
            this.folderSelectButton.TabIndex = 8;
            this.folderSelectButton.Text = "...";
            this.folderSelectButton.UseVisualStyleBackColor = true;
            this.folderSelectButton.Click += new System.EventHandler(this.folderSelectButton_Click);
            // 
            // businessLabel
            // 
            this.businessLabel.AutoSize = true;
            this.businessLabel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessLabel.ForeColor = System.Drawing.Color.White;
            this.businessLabel.Location = new System.Drawing.Point(57, 60);
            this.businessLabel.Name = "businessLabel";
            this.businessLabel.Size = new System.Drawing.Size(63, 14);
            this.businessLabel.TabIndex = 8;
            this.businessLabel.Text = "Business";
            // 
            // saveLabel
            // 
            this.saveLabel.AutoSize = true;
            this.saveLabel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveLabel.ForeColor = System.Drawing.Color.White;
            this.saveLabel.Location = new System.Drawing.Point(22, 177);
            this.saveLabel.Name = "saveLabel";
            this.saveLabel.Size = new System.Drawing.Size(98, 14);
            this.saveLabel.TabIndex = 9;
            this.saveLabel.Text = "Save location";
            // 
            // serverNameText
            // 
            this.serverNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverNameText.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverNameText.Location = new System.Drawing.Point(126, 135);
            this.serverNameText.Name = "serverNameText";
            this.serverNameText.Size = new System.Drawing.Size(273, 20);
            this.serverNameText.TabIndex = 4;
            this.serverNameText.Visible = false;
            this.serverNameText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.serverNameText_KeyDown);
            // 
            // dateButton
            // 
            this.dateButton.AutoSize = true;
            this.dateButton.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateButton.ForeColor = System.Drawing.Color.White;
            this.dateButton.Location = new System.Drawing.Point(10, 99);
            this.dateButton.Name = "dateButton";
            this.dateButton.Size = new System.Drawing.Size(110, 18);
            this.dateButton.TabIndex = 1;
            this.dateButton.Text = "Include Date";
            this.dateButton.UseVisualStyleBackColor = true;
            this.dateButton.CheckedChanged += new System.EventHandler(this.dateButton_CheckedChanged);
            this.dateButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateButton_KeyDown);
            // 
            // experienceLabel
            // 
            this.experienceLabel.AutoSize = true;
            this.experienceLabel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.experienceLabel.ForeColor = System.Drawing.Color.White;
            this.experienceLabel.Location = new System.Drawing.Point(43, 21);
            this.experienceLabel.Name = "experienceLabel";
            this.experienceLabel.Size = new System.Drawing.Size(77, 14);
            this.experienceLabel.TabIndex = 12;
            this.experienceLabel.Text = "Experience";
            // 
            // QuickBuildLetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(413, 246);
            this.Controls.Add(this.experienceLabel);
            this.Controls.Add(this.dateButton);
            this.Controls.Add(this.serverNameText);
            this.Controls.Add(this.saveLabel);
            this.Controls.Add(this.businessLabel);
            this.Controls.Add(this.folderSelectButton);
            this.Controls.Add(this.saveLocation);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.businessText);
            this.Controls.Add(this.serverNameButton);
            this.Controls.Add(this.negativeButton);
            this.Controls.Add(this.positiveButton);
            this.MinimumSize = new System.Drawing.Size(429, 284);
            this.Name = "QuickBuildLetter";
            this.Text = "QuickBuildLetter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton positiveButton;
        private System.Windows.Forms.RadioButton negativeButton;
        private System.Windows.Forms.CheckBox serverNameButton;
        private System.Windows.Forms.TextBox businessText;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.TextBox saveLocation;
        private System.Windows.Forms.Button folderSelectButton;
        private System.Windows.Forms.Label businessLabel;
        private System.Windows.Forms.Label saveLabel;
        private System.Windows.Forms.TextBox serverNameText;
        private System.Windows.Forms.CheckBox dateButton;
        private System.Windows.Forms.Label experienceLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

