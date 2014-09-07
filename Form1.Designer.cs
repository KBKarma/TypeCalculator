namespace TypeCalculator
{
    partial class Form1
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
            this.mvType = new System.Windows.Forms.ComboBox();
            this.vsLbl = new System.Windows.Forms.Label();
            this.defType1 = new System.Windows.Forms.ComboBox();
            this.defType2 = new System.Windows.Forms.ComboBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultText = new System.Windows.Forms.TextBox();
            this.advancedCheck = new System.Windows.Forms.CheckBox();
            this.basicBox = new System.Windows.Forms.GroupBox();
            this.advancedBox = new System.Windows.Forms.GroupBox();
            this.damageText = new System.Windows.Forms.TextBox();
            this.atkType2Lbl = new System.Windows.Forms.Label();
            this.atkType1Lbl = new System.Windows.Forms.Label();
            this.mvPowLbl = new System.Windows.Forms.Label();
            this.atkLvlLbl = new System.Windows.Forms.Label();
            this.defValLbl = new System.Windows.Forms.Label();
            this.atkValLbl = new System.Windows.Forms.Label();
            this.defValBox = new System.Windows.Forms.NumericUpDown();
            this.atkType1 = new System.Windows.Forms.ComboBox();
            this.atkType2 = new System.Windows.Forms.ComboBox();
            this.mvPowBox = new System.Windows.Forms.NumericUpDown();
            this.atkLvlBox = new System.Windows.Forms.NumericUpDown();
            this.atkValBox = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpExplToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpAboutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicBox.SuspendLayout();
            this.advancedBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defValBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvPowBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atkLvlBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atkValBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mvType
            // 
            this.mvType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.mvType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.mvType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mvType.FormattingEnabled = true;
            this.mvType.Items.AddRange(new object[] {
            "Bug",
            "Dark",
            "Dragon",
            "Electric",
            "Fairy",
            "Fighting",
            "Fire",
            "Flying",
            "Ghost",
            "Grass",
            "Ground",
            "Ice",
            "Normal",
            "Poison",
            "Psychic",
            "Rock",
            "Steel",
            "Water"});
            this.mvType.Location = new System.Drawing.Point(77, 19);
            this.mvType.Name = "mvType";
            this.mvType.Size = new System.Drawing.Size(121, 21);
            this.mvType.Sorted = true;
            this.mvType.TabIndex = 0;
            // 
            // vsLbl
            // 
            this.vsLbl.AutoSize = true;
            this.vsLbl.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Bold);
            this.vsLbl.Location = new System.Drawing.Point(107, 43);
            this.vsLbl.Name = "vsLbl";
            this.vsLbl.Size = new System.Drawing.Size(63, 48);
            this.vsLbl.TabIndex = 1;
            this.vsLbl.Text = "VS";
            this.vsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // defType1
            // 
            this.defType1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.defType1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.defType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.defType1.FormattingEnabled = true;
            this.defType1.Items.AddRange(new object[] {
            "Bug",
            "Dark",
            "Dragon",
            "Electric",
            "Fairy",
            "Fighting",
            "Fire",
            "Flying",
            "Ghost",
            "Grass",
            "Ground",
            "Ice",
            "Normal",
            "Poison",
            "Psychic",
            "Rock",
            "Steel",
            "Water"});
            this.defType1.Location = new System.Drawing.Point(6, 94);
            this.defType1.Name = "defType1";
            this.defType1.Size = new System.Drawing.Size(121, 21);
            this.defType1.Sorted = true;
            this.defType1.TabIndex = 1;
            this.defType1.SelectedIndexChanged += new System.EventHandler(this.defType1_SelectedIndexChanged);
            // 
            // defType2
            // 
            this.defType2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.defType2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.defType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.defType2.FormattingEnabled = true;
            this.defType2.Items.AddRange(new object[] {
            "(none)",
            "Bug",
            "Dark",
            "Dragon",
            "Electric",
            "Fairy",
            "Fighting",
            "Fire",
            "Flying",
            "Ghost",
            "Grass",
            "Ground",
            "Ice",
            "Normal",
            "Poison",
            "Psychic",
            "Rock",
            "Steel",
            "Water"});
            this.defType2.Location = new System.Drawing.Point(139, 94);
            this.defType2.Name = "defType2";
            this.defType2.Size = new System.Drawing.Size(121, 21);
            this.defType2.Sorted = true;
            this.defType2.TabIndex = 2;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Impact", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(77, 121);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(121, 76);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "FIGHT!";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resultText
            // 
            this.resultText.Location = new System.Drawing.Point(6, 203);
            this.resultText.Name = "resultText";
            this.resultText.ReadOnly = true;
            this.resultText.Size = new System.Drawing.Size(254, 20);
            this.resultText.TabIndex = 5;
            // 
            // advancedCheck
            // 
            this.advancedCheck.AutoSize = true;
            this.advancedCheck.Location = new System.Drawing.Point(9, 20);
            this.advancedCheck.Name = "advancedCheck";
            this.advancedCheck.Size = new System.Drawing.Size(105, 17);
            this.advancedCheck.TabIndex = 4;
            this.advancedCheck.Text = "Advanced Mode";
            this.advancedCheck.UseVisualStyleBackColor = true;
            this.advancedCheck.CheckedChanged += new System.EventHandler(this.advancedCheck_CheckedChanged);
            // 
            // basicBox
            // 
            this.basicBox.Controls.Add(this.mvType);
            this.basicBox.Controls.Add(this.vsLbl);
            this.basicBox.Controls.Add(this.defType1);
            this.basicBox.Controls.Add(this.resultText);
            this.basicBox.Controls.Add(this.defType2);
            this.basicBox.Controls.Add(this.calculateButton);
            this.basicBox.Location = new System.Drawing.Point(12, 26);
            this.basicBox.Name = "basicBox";
            this.basicBox.Size = new System.Drawing.Size(266, 233);
            this.basicBox.TabIndex = 8;
            this.basicBox.TabStop = false;
            this.basicBox.Text = "Basic Options";
            // 
            // advancedBox
            // 
            this.advancedBox.Controls.Add(this.damageText);
            this.advancedBox.Controls.Add(this.atkType2Lbl);
            this.advancedBox.Controls.Add(this.atkType1Lbl);
            this.advancedBox.Controls.Add(this.mvPowLbl);
            this.advancedBox.Controls.Add(this.atkLvlLbl);
            this.advancedBox.Controls.Add(this.defValLbl);
            this.advancedBox.Controls.Add(this.atkValLbl);
            this.advancedBox.Controls.Add(this.defValBox);
            this.advancedBox.Controls.Add(this.atkType1);
            this.advancedBox.Controls.Add(this.atkType2);
            this.advancedBox.Controls.Add(this.mvPowBox);
            this.advancedBox.Controls.Add(this.atkLvlBox);
            this.advancedBox.Controls.Add(this.atkValBox);
            this.advancedBox.Controls.Add(this.advancedCheck);
            this.advancedBox.Location = new System.Drawing.Point(285, 27);
            this.advancedBox.Name = "advancedBox";
            this.advancedBox.Size = new System.Drawing.Size(314, 232);
            this.advancedBox.TabIndex = 9;
            this.advancedBox.TabStop = false;
            this.advancedBox.Text = "Advanced Options";
            // 
            // damageText
            // 
            this.damageText.Enabled = false;
            this.damageText.Location = new System.Drawing.Point(9, 202);
            this.damageText.Name = "damageText";
            this.damageText.ReadOnly = true;
            this.damageText.Size = new System.Drawing.Size(297, 20);
            this.damageText.TabIndex = 20;
            // 
            // atkType2Lbl
            // 
            this.atkType2Lbl.AutoSize = true;
            this.atkType2Lbl.Location = new System.Drawing.Point(185, 158);
            this.atkType2Lbl.Name = "atkType2Lbl";
            this.atkType2Lbl.Size = new System.Drawing.Size(128, 13);
            this.atkType2Lbl.TabIndex = 19;
            this.atkType2Lbl.Text = "Attacker Secondary Type";
            // 
            // atkType1Lbl
            // 
            this.atkType1Lbl.AutoSize = true;
            this.atkType1Lbl.Location = new System.Drawing.Point(6, 157);
            this.atkType1Lbl.Name = "atkType1Lbl";
            this.atkType1Lbl.Size = new System.Drawing.Size(111, 13);
            this.atkType1Lbl.TabIndex = 18;
            this.atkType1Lbl.Text = "Attacker Primary Type";
            // 
            // mvPowLbl
            // 
            this.mvPowLbl.AutoSize = true;
            this.mvPowLbl.Location = new System.Drawing.Point(185, 105);
            this.mvPowLbl.Name = "mvPowLbl";
            this.mvPowLbl.Size = new System.Drawing.Size(104, 13);
            this.mvPowLbl.TabIndex = 17;
            this.mvPowLbl.Text = "Move Base Damage";
            // 
            // atkLvlLbl
            // 
            this.atkLvlLbl.AutoSize = true;
            this.atkLvlLbl.Location = new System.Drawing.Point(6, 104);
            this.atkLvlLbl.Name = "atkLvlLbl";
            this.atkLvlLbl.Size = new System.Drawing.Size(76, 13);
            this.atkLvlLbl.TabIndex = 16;
            this.atkLvlLbl.Text = "Attacker Level";
            // 
            // defValLbl
            // 
            this.defValLbl.AutoSize = true;
            this.defValLbl.Location = new System.Drawing.Point(185, 54);
            this.defValLbl.Name = "defValLbl";
            this.defValLbl.Size = new System.Drawing.Size(91, 13);
            this.defValLbl.TabIndex = 15;
            this.defValLbl.Text = "Defence Strength";
            // 
            // atkValLbl
            // 
            this.atkValLbl.AutoSize = true;
            this.atkValLbl.Location = new System.Drawing.Point(6, 53);
            this.atkValLbl.Name = "atkValLbl";
            this.atkValLbl.Size = new System.Drawing.Size(81, 13);
            this.atkValLbl.TabIndex = 14;
            this.atkValLbl.Text = "Attack Strength";
            // 
            // defValBox
            // 
            this.defValBox.Enabled = false;
            this.defValBox.Location = new System.Drawing.Point(188, 70);
            this.defValBox.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.defValBox.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.defValBox.Name = "defValBox";
            this.defValBox.ReadOnly = true;
            this.defValBox.Size = new System.Drawing.Size(120, 20);
            this.defValBox.TabIndex = 7;
            this.defValBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // atkType1
            // 
            this.atkType1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.atkType1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.atkType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.atkType1.Enabled = false;
            this.atkType1.FormattingEnabled = true;
            this.atkType1.Items.AddRange(new object[] {
            "Bug",
            "Dark",
            "Dragon",
            "Electric",
            "Fairy",
            "Fighting",
            "Fire",
            "Flying",
            "Ghost",
            "Grass",
            "Ground",
            "Ice",
            "Normal",
            "Poison",
            "Psychic",
            "Rock",
            "Steel",
            "Water"});
            this.atkType1.Location = new System.Drawing.Point(9, 173);
            this.atkType1.Name = "atkType1";
            this.atkType1.Size = new System.Drawing.Size(121, 21);
            this.atkType1.Sorted = true;
            this.atkType1.TabIndex = 10;
            this.atkType1.SelectedIndexChanged += new System.EventHandler(this.atkType1_SelectedIndexChanged);
            // 
            // atkType2
            // 
            this.atkType2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.atkType2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.atkType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.atkType2.Enabled = false;
            this.atkType2.FormattingEnabled = true;
            this.atkType2.Items.AddRange(new object[] {
            "(none)",
            "Bug",
            "Dark",
            "Dragon",
            "Electric",
            "Fairy",
            "Fighting",
            "Fire",
            "Flying",
            "Ghost",
            "Grass",
            "Ground",
            "Ice",
            "Normal",
            "Poison",
            "Psychic",
            "Rock",
            "Steel",
            "Water"});
            this.atkType2.Location = new System.Drawing.Point(186, 174);
            this.atkType2.Name = "atkType2";
            this.atkType2.Size = new System.Drawing.Size(121, 21);
            this.atkType2.Sorted = true;
            this.atkType2.TabIndex = 11;
            // 
            // mvPowBox
            // 
            this.mvPowBox.Enabled = false;
            this.mvPowBox.Location = new System.Drawing.Point(186, 121);
            this.mvPowBox.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.mvPowBox.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.mvPowBox.Name = "mvPowBox";
            this.mvPowBox.ReadOnly = true;
            this.mvPowBox.Size = new System.Drawing.Size(120, 20);
            this.mvPowBox.TabIndex = 9;
            this.mvPowBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // atkLvlBox
            // 
            this.atkLvlBox.Enabled = false;
            this.atkLvlBox.Location = new System.Drawing.Point(9, 120);
            this.atkLvlBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.atkLvlBox.Name = "atkLvlBox";
            this.atkLvlBox.ReadOnly = true;
            this.atkLvlBox.Size = new System.Drawing.Size(120, 20);
            this.atkLvlBox.TabIndex = 8;
            this.atkLvlBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // atkValBox
            // 
            this.atkValBox.Enabled = false;
            this.atkValBox.Location = new System.Drawing.Point(9, 69);
            this.atkValBox.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.atkValBox.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.atkValBox.Name = "atkValBox";
            this.atkValBox.ReadOnly = true;
            this.atkValBox.Size = new System.Drawing.Size(120, 20);
            this.atkValBox.TabIndex = 6;
            this.atkValBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(611, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileResetToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // fileResetToolStripMenuItem
            // 
            this.fileResetToolStripMenuItem.Name = "fileResetToolStripMenuItem";
            this.fileResetToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.fileResetToolStripMenuItem.Text = "Reset";
            this.fileResetToolStripMenuItem.Click += new System.EventHandler(this.resetMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpExplToolStripMenuItem1,
            this.helpAboutToolStripMenuItem2,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpExplToolStripMenuItem1
            // 
            this.helpExplToolStripMenuItem1.Name = "helpExplToolStripMenuItem1";
            this.helpExplToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.helpExplToolStripMenuItem1.Text = "Explanation";
            this.helpExplToolStripMenuItem1.Click += new System.EventHandler(this.explanationMenuItem_Click);
            // 
            // helpAboutToolStripMenuItem2
            // 
            this.helpAboutToolStripMenuItem2.Name = "helpAboutToolStripMenuItem2";
            this.helpAboutToolStripMenuItem2.Size = new System.Drawing.Size(156, 22);
            this.helpAboutToolStripMenuItem2.Text = "Type Matchups";
            this.helpAboutToolStripMenuItem2.Click += new System.EventHandler(this.matchupsMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 268);
            this.Controls.Add(this.advancedBox);
            this.Controls.Add(this.basicBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Pokémon Type Effectiveness Calculator";
            this.basicBox.ResumeLayout(false);
            this.basicBox.PerformLayout();
            this.advancedBox.ResumeLayout(false);
            this.advancedBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defValBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvPowBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atkLvlBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atkValBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox mvType;
        private System.Windows.Forms.Label vsLbl;
        private System.Windows.Forms.ComboBox defType1;
        private System.Windows.Forms.ComboBox defType2;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.CheckBox advancedCheck;
        private System.Windows.Forms.GroupBox basicBox;
        private System.Windows.Forms.GroupBox advancedBox;
        private System.Windows.Forms.TextBox damageText;
        private System.Windows.Forms.Label atkType2Lbl;
        private System.Windows.Forms.Label atkType1Lbl;
        private System.Windows.Forms.Label mvPowLbl;
        private System.Windows.Forms.Label atkLvlLbl;
        private System.Windows.Forms.Label defValLbl;
        private System.Windows.Forms.Label atkValLbl;
        private System.Windows.Forms.NumericUpDown defValBox;
        private System.Windows.Forms.ComboBox atkType1;
        private System.Windows.Forms.ComboBox atkType2;
        private System.Windows.Forms.NumericUpDown mvPowBox;
        private System.Windows.Forms.NumericUpDown atkLvlBox;
        private System.Windows.Forms.NumericUpDown atkValBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileResetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpExplToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpAboutToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

