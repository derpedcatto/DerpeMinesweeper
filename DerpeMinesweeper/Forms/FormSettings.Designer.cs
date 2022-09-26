namespace DerpeMinesweeper.Forms
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.groupBox_Skin = new System.Windows.Forms.GroupBox();
            this.comboBox_Skin = new System.Windows.Forms.ComboBox();
            this.groupBox_MineCount = new System.Windows.Forms.GroupBox();
            this.radioDifficulty_Custom = new System.Windows.Forms.RadioButton();
            this.radioDifficulty_Hard = new System.Windows.Forms.RadioButton();
            this.radioDifficulty_Medium = new System.Windows.Forms.RadioButton();
            this.radioDifficulty_Easy = new System.Windows.Forms.RadioButton();
            this.numericMineCount = new System.Windows.Forms.NumericUpDown();
            this.groupBox_SpriteSize = new System.Windows.Forms.GroupBox();
            this.labelSpriteWidth = new System.Windows.Forms.Label();
            this.numericSpriteWidth = new System.Windows.Forms.NumericUpDown();
            this.labelSpriteHeight = new System.Windows.Forms.Label();
            this.numericSpriteHeight = new System.Windows.Forms.NumericUpDown();
            this.groupBox_FieldSize = new System.Windows.Forms.GroupBox();
            this.labelFieldWidth = new System.Windows.Forms.Label();
            this.numericFieldWidth = new System.Windows.Forms.NumericUpDown();
            this.labelFieldHeight = new System.Windows.Forms.Label();
            this.numericFieldHeight = new System.Windows.Forms.NumericUpDown();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.labelNote = new System.Windows.Forms.Label();
            this.groupBox_Skin.SuspendLayout();
            this.groupBox_MineCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMineCount)).BeginInit();
            this.groupBox_SpriteSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpriteWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpriteHeight)).BeginInit();
            this.groupBox_FieldSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFieldWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFieldHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Skin
            // 
            this.groupBox_Skin.Controls.Add(this.comboBox_Skin);
            this.groupBox_Skin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_Skin.Location = new System.Drawing.Point(111, 204);
            this.groupBox_Skin.Name = "groupBox_Skin";
            this.groupBox_Skin.Size = new System.Drawing.Size(135, 65);
            this.groupBox_Skin.TabIndex = 0;
            this.groupBox_Skin.TabStop = false;
            this.groupBox_Skin.Text = "Skin";
            // 
            // comboBox_Skin
            // 
            this.comboBox_Skin.FormattingEnabled = true;
            this.comboBox_Skin.Items.AddRange(new object[] {
            "Classic",
            "Windows 7"});
            this.comboBox_Skin.Location = new System.Drawing.Point(6, 26);
            this.comboBox_Skin.Name = "comboBox_Skin";
            this.comboBox_Skin.Size = new System.Drawing.Size(121, 28);
            this.comboBox_Skin.TabIndex = 1;
            this.comboBox_Skin.SelectedValueChanged += new System.EventHandler(this.comboBox_Skin_SelectedValueChanged);
            // 
            // groupBox_MineCount
            // 
            this.groupBox_MineCount.Controls.Add(this.radioDifficulty_Custom);
            this.groupBox_MineCount.Controls.Add(this.radioDifficulty_Hard);
            this.groupBox_MineCount.Controls.Add(this.radioDifficulty_Medium);
            this.groupBox_MineCount.Controls.Add(this.radioDifficulty_Easy);
            this.groupBox_MineCount.Controls.Add(this.numericMineCount);
            this.groupBox_MineCount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_MineCount.Location = new System.Drawing.Point(111, 12);
            this.groupBox_MineCount.Name = "groupBox_MineCount";
            this.groupBox_MineCount.Size = new System.Drawing.Size(135, 183);
            this.groupBox_MineCount.TabIndex = 1;
            this.groupBox_MineCount.TabStop = false;
            this.groupBox_MineCount.Text = "Mine Count";
            // 
            // radioDifficulty_Custom
            // 
            this.radioDifficulty_Custom.AutoSize = true;
            this.radioDifficulty_Custom.Location = new System.Drawing.Point(8, 116);
            this.radioDifficulty_Custom.Name = "radioDifficulty_Custom";
            this.radioDifficulty_Custom.Size = new System.Drawing.Size(77, 24);
            this.radioDifficulty_Custom.TabIndex = 6;
            this.radioDifficulty_Custom.Text = "Custom";
            this.radioDifficulty_Custom.UseVisualStyleBackColor = true;
            this.radioDifficulty_Custom.CheckedChanged += new System.EventHandler(this.radioDifficulty_Custom_CheckedChanged);
            // 
            // radioDifficulty_Hard
            // 
            this.radioDifficulty_Hard.AutoSize = true;
            this.radioDifficulty_Hard.Location = new System.Drawing.Point(8, 86);
            this.radioDifficulty_Hard.Name = "radioDifficulty_Hard";
            this.radioDifficulty_Hard.Size = new System.Drawing.Size(60, 24);
            this.radioDifficulty_Hard.TabIndex = 5;
            this.radioDifficulty_Hard.Text = "Hard";
            this.radioDifficulty_Hard.UseVisualStyleBackColor = true;
            // 
            // radioDifficulty_Medium
            // 
            this.radioDifficulty_Medium.AutoSize = true;
            this.radioDifficulty_Medium.Location = new System.Drawing.Point(8, 56);
            this.radioDifficulty_Medium.Name = "radioDifficulty_Medium";
            this.radioDifficulty_Medium.Size = new System.Drawing.Size(82, 24);
            this.radioDifficulty_Medium.TabIndex = 4;
            this.radioDifficulty_Medium.Text = "Medium";
            this.radioDifficulty_Medium.UseVisualStyleBackColor = true;
            // 
            // radioDifficulty_Easy
            // 
            this.radioDifficulty_Easy.AutoSize = true;
            this.radioDifficulty_Easy.Location = new System.Drawing.Point(8, 27);
            this.radioDifficulty_Easy.Name = "radioDifficulty_Easy";
            this.radioDifficulty_Easy.Size = new System.Drawing.Size(56, 24);
            this.radioDifficulty_Easy.TabIndex = 3;
            this.radioDifficulty_Easy.Text = "Easy";
            this.radioDifficulty_Easy.UseVisualStyleBackColor = true;
            // 
            // numericMineCount
            // 
            this.numericMineCount.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericMineCount.Location = new System.Drawing.Point(8, 146);
            this.numericMineCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericMineCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericMineCount.Name = "numericMineCount";
            this.numericMineCount.ReadOnly = true;
            this.numericMineCount.Size = new System.Drawing.Size(77, 27);
            this.numericMineCount.TabIndex = 2;
            this.numericMineCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericMineCount.ValueChanged += new System.EventHandler(this.numericMineCount_ValueChanged);
            // 
            // groupBox_SpriteSize
            // 
            this.groupBox_SpriteSize.Controls.Add(this.labelSpriteWidth);
            this.groupBox_SpriteSize.Controls.Add(this.numericSpriteWidth);
            this.groupBox_SpriteSize.Controls.Add(this.labelSpriteHeight);
            this.groupBox_SpriteSize.Controls.Add(this.numericSpriteHeight);
            this.groupBox_SpriteSize.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_SpriteSize.Location = new System.Drawing.Point(12, 204);
            this.groupBox_SpriteSize.Name = "groupBox_SpriteSize";
            this.groupBox_SpriteSize.Size = new System.Drawing.Size(82, 93);
            this.groupBox_SpriteSize.TabIndex = 2;
            this.groupBox_SpriteSize.TabStop = false;
            this.groupBox_SpriteSize.Text = "Sprite";
            // 
            // labelSpriteWidth
            // 
            this.labelSpriteWidth.AutoSize = true;
            this.labelSpriteWidth.Location = new System.Drawing.Point(6, 60);
            this.labelSpriteWidth.Name = "labelSpriteWidth";
            this.labelSpriteWidth.Size = new System.Drawing.Size(26, 20);
            this.labelSpriteWidth.TabIndex = 4;
            this.labelSpriteWidth.Text = "W:";
            // 
            // numericSpriteWidth
            // 
            this.numericSpriteWidth.Location = new System.Drawing.Point(32, 57);
            this.numericSpriteWidth.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericSpriteWidth.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericSpriteWidth.Name = "numericSpriteWidth";
            this.numericSpriteWidth.Size = new System.Drawing.Size(42, 27);
            this.numericSpriteWidth.TabIndex = 5;
            this.numericSpriteWidth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericSpriteWidth.ValueChanged += new System.EventHandler(this.numericSpriteWidth_ValueChanged);
            // 
            // labelSpriteHeight
            // 
            this.labelSpriteHeight.AutoSize = true;
            this.labelSpriteHeight.Location = new System.Drawing.Point(6, 29);
            this.labelSpriteHeight.Name = "labelSpriteHeight";
            this.labelSpriteHeight.Size = new System.Drawing.Size(23, 20);
            this.labelSpriteHeight.TabIndex = 3;
            this.labelSpriteHeight.Text = "H:";
            // 
            // numericSpriteHeight
            // 
            this.numericSpriteHeight.Location = new System.Drawing.Point(32, 26);
            this.numericSpriteHeight.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericSpriteHeight.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericSpriteHeight.Name = "numericSpriteHeight";
            this.numericSpriteHeight.Size = new System.Drawing.Size(42, 27);
            this.numericSpriteHeight.TabIndex = 3;
            this.numericSpriteHeight.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericSpriteHeight.ValueChanged += new System.EventHandler(this.numericSpriteHeight_ValueChanged);
            // 
            // groupBox_FieldSize
            // 
            this.groupBox_FieldSize.Controls.Add(this.labelFieldWidth);
            this.groupBox_FieldSize.Controls.Add(this.numericFieldWidth);
            this.groupBox_FieldSize.Controls.Add(this.labelFieldHeight);
            this.groupBox_FieldSize.Controls.Add(this.numericFieldHeight);
            this.groupBox_FieldSize.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_FieldSize.Location = new System.Drawing.Point(12, 12);
            this.groupBox_FieldSize.Name = "groupBox_FieldSize";
            this.groupBox_FieldSize.Size = new System.Drawing.Size(82, 93);
            this.groupBox_FieldSize.TabIndex = 3;
            this.groupBox_FieldSize.TabStop = false;
            this.groupBox_FieldSize.Text = "Field";
            // 
            // labelFieldWidth
            // 
            this.labelFieldWidth.AutoSize = true;
            this.labelFieldWidth.Location = new System.Drawing.Point(6, 60);
            this.labelFieldWidth.Name = "labelFieldWidth";
            this.labelFieldWidth.Size = new System.Drawing.Size(26, 20);
            this.labelFieldWidth.TabIndex = 4;
            this.labelFieldWidth.Text = "W:";
            // 
            // numericFieldWidth
            // 
            this.numericFieldWidth.Location = new System.Drawing.Point(32, 57);
            this.numericFieldWidth.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericFieldWidth.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericFieldWidth.Name = "numericFieldWidth";
            this.numericFieldWidth.Size = new System.Drawing.Size(42, 27);
            this.numericFieldWidth.TabIndex = 5;
            this.numericFieldWidth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericFieldWidth.ValueChanged += new System.EventHandler(this.numericFieldWidth_ValueChanged);
            // 
            // labelFieldHeight
            // 
            this.labelFieldHeight.AutoSize = true;
            this.labelFieldHeight.Location = new System.Drawing.Point(6, 29);
            this.labelFieldHeight.Name = "labelFieldHeight";
            this.labelFieldHeight.Size = new System.Drawing.Size(23, 20);
            this.labelFieldHeight.TabIndex = 3;
            this.labelFieldHeight.Text = "H:";
            // 
            // numericFieldHeight
            // 
            this.numericFieldHeight.Location = new System.Drawing.Point(32, 26);
            this.numericFieldHeight.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericFieldHeight.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericFieldHeight.Name = "numericFieldHeight";
            this.numericFieldHeight.Size = new System.Drawing.Size(42, 27);
            this.numericFieldHeight.TabIndex = 3;
            this.numericFieldHeight.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericFieldHeight.ValueChanged += new System.EventHandler(this.numericFieldHeight_ValueChanged);
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveSettings.Location = new System.Drawing.Point(12, 303);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(234, 31);
            this.buttonSaveSettings.TabIndex = 4;
            this.buttonSaveSettings.Text = "Save Settings and Exit";
            this.buttonSaveSettings.UseVisualStyleBackColor = true;
            this.buttonSaveSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNote.Location = new System.Drawing.Point(12, 337);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(233, 15);
            this.labelNote.TabIndex = 5;
            this.labelNote.Text = "*Note - some settings may break the game";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 364);
            this.ControlBox = false;
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.buttonSaveSettings);
            this.Controls.Add(this.groupBox_FieldSize);
            this.Controls.Add(this.groupBox_SpriteSize);
            this.Controls.Add(this.groupBox_MineCount);
            this.Controls.Add(this.groupBox_Skin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.groupBox_Skin.ResumeLayout(false);
            this.groupBox_MineCount.ResumeLayout(false);
            this.groupBox_MineCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMineCount)).EndInit();
            this.groupBox_SpriteSize.ResumeLayout(false);
            this.groupBox_SpriteSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpriteWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpriteHeight)).EndInit();
            this.groupBox_FieldSize.ResumeLayout(false);
            this.groupBox_FieldSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFieldWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFieldHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox_Skin;
        private ComboBox comboBox_Skin;
        private GroupBox groupBox_MineCount;
        private NumericUpDown numericMineCount;
        private GroupBox groupBox_SpriteSize;
        private Label labelSpriteWidth;
        private NumericUpDown numericSpriteWidth;
        private Label labelSpriteHeight;
        private NumericUpDown numericSpriteHeight;
        private GroupBox groupBox_FieldSize;
        private Label labelFieldWidth;
        private NumericUpDown numericFieldWidth;
        private Label labelFieldHeight;
        private NumericUpDown numericFieldHeight;
        private Button buttonSaveSettings;
        private Label labelNote;
        private RadioButton radioDifficulty_Easy;
        private RadioButton radioDifficulty_Medium;
        private RadioButton radioDifficulty_Custom;
        private RadioButton radioDifficulty_Hard;
    }
}