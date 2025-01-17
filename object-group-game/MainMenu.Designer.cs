﻿
namespace object_group_game
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.intelligenceBar = new System.Windows.Forms.ProgressBar();
            this.dexterityBar = new System.Windows.Forms.ProgressBar();
            this.strengthBar = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.characterNameLabel = new System.Windows.Forms.Label();
            this.manaBar = new System.Windows.Forms.ProgressBar();
            this.experienceBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.goldLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.liveMap = new GMap.NET.WindowsForms.GMapControl();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewEffectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.manaBar);
            this.groupBox1.Controls.Add(this.experienceBar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.healthBar);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.intelligenceBar);
            this.groupBox6.Controls.Add(this.dexterityBar);
            this.groupBox6.Controls.Add(this.strengthBar);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Location = new System.Drawing.Point(203, 131);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(212, 157);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            // 
            // intelligenceBar
            // 
            this.intelligenceBar.Location = new System.Drawing.Point(106, 117);
            this.intelligenceBar.Margin = new System.Windows.Forms.Padding(50, 50, 50, 50);
            this.intelligenceBar.Maximum = 1000;
            this.intelligenceBar.Name = "intelligenceBar";
            this.intelligenceBar.Size = new System.Drawing.Size(96, 13);
            this.intelligenceBar.Step = 1;
            this.intelligenceBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.intelligenceBar.TabIndex = 7;
            this.intelligenceBar.Value = 15;
            // 
            // dexterityBar
            // 
            this.dexterityBar.Location = new System.Drawing.Point(106, 84);
            this.dexterityBar.Margin = new System.Windows.Forms.Padding(50, 50, 50, 50);
            this.dexterityBar.Maximum = 1000;
            this.dexterityBar.Name = "dexterityBar";
            this.dexterityBar.Size = new System.Drawing.Size(96, 13);
            this.dexterityBar.Step = 1;
            this.dexterityBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.dexterityBar.TabIndex = 6;
            this.dexterityBar.Value = 15;
            // 
            // strengthBar
            // 
            this.strengthBar.Location = new System.Drawing.Point(106, 48);
            this.strengthBar.Margin = new System.Windows.Forms.Padding(50, 50, 50, 50);
            this.strengthBar.Maximum = 1000;
            this.strengthBar.Name = "strengthBar";
            this.strengthBar.Size = new System.Drawing.Size(96, 13);
            this.strengthBar.Step = 1;
            this.strengthBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.strengthBar.TabIndex = 5;
            this.strengthBar.Value = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Intelligence";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Dexterity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Strength";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(54, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Attributes";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.characterNameLabel);
            this.groupBox4.Location = new System.Drawing.Point(10, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(187, 257);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(6, 44);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(175, 195);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // characterNameLabel
            // 
            this.characterNameLabel.AutoSize = true;
            this.characterNameLabel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.characterNameLabel.Location = new System.Drawing.Point(25, 26);
            this.characterNameLabel.Name = "characterNameLabel";
            this.characterNameLabel.Size = new System.Drawing.Size(133, 16);
            this.characterNameLabel.TabIndex = 0;
            this.characterNameLabel.Text = "Character Name";
            this.characterNameLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // manaBar
            // 
            this.manaBar.Location = new System.Drawing.Point(309, 98);
            this.manaBar.Margin = new System.Windows.Forms.Padding(50, 50, 50, 50);
            this.manaBar.Name = "manaBar";
            this.manaBar.Size = new System.Drawing.Size(96, 13);
            this.manaBar.Step = 1;
            this.manaBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.manaBar.TabIndex = 5;
            this.manaBar.Value = 15;
            // 
            // experienceBar
            // 
            this.experienceBar.Location = new System.Drawing.Point(309, 75);
            this.experienceBar.Margin = new System.Windows.Forms.Padding(50, 50, 50, 50);
            this.experienceBar.Maximum = 1000000;
            this.experienceBar.Name = "experienceBar";
            this.experienceBar.Size = new System.Drawing.Size(96, 13);
            this.experienceBar.Step = 1;
            this.experienceBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.experienceBar.TabIndex = 4;
            this.experienceBar.Value = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(216, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(216, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Experience";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(216, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Health";
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(309, 49);
            this.healthBar.Margin = new System.Windows.Forms.Padding(50, 50, 50, 50);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(96, 13);
            this.healthBar.Step = 1;
            this.healthBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.healthBar.TabIndex = 0;
            this.healthBar.Value = 15;
            this.healthBar.SystemColorsChanged += new System.EventHandler(this.health_SystemColorsChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.goldLabel);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(449, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(872, 303);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // goldLabel
            // 
            this.goldLabel.AutoSize = true;
            this.goldLabel.Font = new System.Drawing.Font("SimSun", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.goldLabel.Location = new System.Drawing.Point(698, 25);
            this.goldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.goldLabel.Name = "goldLabel";
            this.goldLabel.Size = new System.Drawing.Size(55, 15);
            this.goldLabel.TabIndex = 2;
            this.goldLabel.Text = "Gold: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(798, 232);
            this.dataGridView1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(365, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Inventory";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(12, 343);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1309, 288);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.liveMap);
            this.groupBox7.Location = new System.Drawing.Point(16, 43);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1287, 239);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            // 
            // liveMap
            // 
            this.liveMap.Bearing = 0F;
            this.liveMap.CanDragMap = true;
            this.liveMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.liveMap.GrayScaleMode = false;
            this.liveMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.liveMap.LevelsKeepInMemory = 5;
            this.liveMap.Location = new System.Drawing.Point(18, 0);
            this.liveMap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.liveMap.MarkersEnabled = true;
            this.liveMap.MaxZoom = 2;
            this.liveMap.MinZoom = 2;
            this.liveMap.MouseWheelZoomEnabled = true;
            this.liveMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.liveMap.Name = "liveMap";
            this.liveMap.NegativeMode = false;
            this.liveMap.PolygonsEnabled = true;
            this.liveMap.RetryLoadTile = 0;
            this.liveMap.RoutesEnabled = true;
            this.liveMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.liveMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.liveMap.ShowTileGridLines = false;
            this.liveMap.Size = new System.Drawing.Size(1263, 226);
            this.liveMap.TabIndex = 0;
            this.liveMap.Zoom = 0D;
            this.liveMap.Load += new System.EventHandler(this.liveMap_Load);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(603, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Location";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.gameMasterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1333, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // gameMasterToolStripMenuItem
            // 
            this.gameMasterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewItemToolStripMenuItem,
            this.createNewLocationToolStripMenuItem,
            this.createNewEffectToolStripMenuItem,
            this.editPlayerToolStripMenuItem,
            this.editCharacterToolStripMenuItem});
            this.gameMasterToolStripMenuItem.Name = "gameMasterToolStripMenuItem";
            this.gameMasterToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.gameMasterToolStripMenuItem.Text = "Game Master";
            // 
            // createNewItemToolStripMenuItem
            // 
            this.createNewItemToolStripMenuItem.Name = "createNewItemToolStripMenuItem";
            this.createNewItemToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.createNewItemToolStripMenuItem.Text = "Create new Item";
            this.createNewItemToolStripMenuItem.Click += new System.EventHandler(this.createNewItemToolStripMenuItem_Click);
            // 
            // createNewLocationToolStripMenuItem
            // 
            this.createNewLocationToolStripMenuItem.Name = "createNewLocationToolStripMenuItem";
            this.createNewLocationToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.createNewLocationToolStripMenuItem.Text = "Create new Location";
            this.createNewLocationToolStripMenuItem.Click += new System.EventHandler(this.createNewLocationToolStripMenuItem_Click);
            // 
            // createNewEffectToolStripMenuItem
            // 
            this.createNewEffectToolStripMenuItem.Name = "createNewEffectToolStripMenuItem";
            this.createNewEffectToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.createNewEffectToolStripMenuItem.Text = "Create new Effect";
            // 
            // editPlayerToolStripMenuItem
            // 
            this.editPlayerToolStripMenuItem.Name = "editPlayerToolStripMenuItem";
            this.editPlayerToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.editPlayerToolStripMenuItem.Text = "Edit Player";
            // 
            // editCharacterToolStripMenuItem
            // 
            this.editCharacterToolStripMenuItem.Name = "editCharacterToolStripMenuItem";
            this.editCharacterToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.editCharacterToolStripMenuItem.Text = "Edit Character";
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 1000;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Gold";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1333, 643);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ProgressBar manaBar;
        private System.Windows.Forms.ProgressBar experienceBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label characterNameLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar intelligenceBar;
        private System.Windows.Forms.ProgressBar dexterityBar;
        private System.Windows.Forms.ProgressBar strengthBar;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label goldLabel;
        private System.Windows.Forms.Timer updateTimer;
        private GMap.NET.WindowsForms.GMapControl liveMap;
        private System.Windows.Forms.ToolStripMenuItem gameMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewEffectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCharacterToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}