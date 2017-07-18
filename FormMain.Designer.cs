namespace FF12RNGHelper
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbLevel = new System.Windows.Forms.TextBox();
            this.tbMagic = new System.Windows.Forms.TextBox();
            this.cbSpellPow = new System.Windows.Forms.ComboBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblMagic = new System.Windows.Forms.Label();
            this.lblSpellPow = new System.Windows.Forms.Label();
            this.chkbSerenity = new System.Windows.Forms.CheckBox();
            this.gbStats = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Heal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OneIn256 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stealCuffs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLastHeal = new System.Windows.Forms.Label();
            this.tbLastHeal = new System.Windows.Forms.TextBox();
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.groupBoxChoose = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.tbNumDisp = new System.Windows.Forms.TextBox();
            this.lblNumDisp = new System.Windows.Forms.Label();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBarPercent = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabelPercent = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorkerConsume = new System.ComponentModel.BackgroundWorker();
            this.gbPlatform = new System.Windows.Forms.GroupBox();
            this.cbPlatform = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.gbStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxChoose.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gbPlatform.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(541, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tbLevel
            // 
            this.tbLevel.Location = new System.Drawing.Point(48, 19);
            this.tbLevel.Name = "tbLevel";
            this.tbLevel.Size = new System.Drawing.Size(34, 20);
            this.tbLevel.TabIndex = 2;
            this.tbLevel.Text = "3";
            this.tbLevel.Validating += new System.ComponentModel.CancelEventHandler(this.tbLevel_Validating);
            // 
            // tbMagic
            // 
            this.tbMagic.Location = new System.Drawing.Point(125, 19);
            this.tbMagic.Name = "tbMagic";
            this.tbMagic.Size = new System.Drawing.Size(40, 20);
            this.tbMagic.TabIndex = 3;
            this.tbMagic.Text = "21";
            this.tbMagic.Validating += new System.ComponentModel.CancelEventHandler(this.tbMagic_Validating);
            // 
            // cbSpellPow
            // 
            this.cbSpellPow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpellPow.FormattingEnabled = true;
            this.cbSpellPow.Items.AddRange(new object[] {
            "Cure (20)",
            "Cura (45)",
            "Curaga (85)",
            "Curaja (145)",
            "Cura IZJS/ZA (46)",
            "Curaga IZJS/ZA (86)",
            "Curaja IZJS/ZA (120)"});
            this.cbSpellPow.Location = new System.Drawing.Point(210, 18);
            this.cbSpellPow.Name = "cbSpellPow";
            this.cbSpellPow.Size = new System.Drawing.Size(118, 21);
            this.cbSpellPow.TabIndex = 4;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(6, 22);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(36, 13);
            this.lblLevel.TabIndex = 5;
            this.lblLevel.Text = "Level:";
            // 
            // lblMagic
            // 
            this.lblMagic.AutoSize = true;
            this.lblMagic.Location = new System.Drawing.Point(88, 22);
            this.lblMagic.Name = "lblMagic";
            this.lblMagic.Size = new System.Drawing.Size(31, 13);
            this.lblMagic.TabIndex = 6;
            this.lblMagic.Text = "Mag:";
            // 
            // lblSpellPow
            // 
            this.lblSpellPow.AutoSize = true;
            this.lblSpellPow.Location = new System.Drawing.Point(171, 22);
            this.lblSpellPow.Name = "lblSpellPow";
            this.lblSpellPow.Size = new System.Drawing.Size(33, 13);
            this.lblSpellPow.TabIndex = 7;
            this.lblSpellPow.Text = "Spell:";
            // 
            // chkbSerenity
            // 
            this.chkbSerenity.AutoSize = true;
            this.chkbSerenity.Location = new System.Drawing.Point(334, 21);
            this.chkbSerenity.Name = "chkbSerenity";
            this.chkbSerenity.Size = new System.Drawing.Size(70, 17);
            this.chkbSerenity.TabIndex = 9;
            this.chkbSerenity.Text = "Serenity?";
            this.chkbSerenity.UseVisualStyleBackColor = true;
            // 
            // gbStats
            // 
            this.gbStats.Controls.Add(this.lblLevel);
            this.gbStats.Controls.Add(this.chkbSerenity);
            this.gbStats.Controls.Add(this.tbLevel);
            this.gbStats.Controls.Add(this.cbSpellPow);
            this.gbStats.Controls.Add(this.lblSpellPow);
            this.gbStats.Controls.Add(this.lblMagic);
            this.gbStats.Controls.Add(this.tbMagic);
            this.gbStats.Location = new System.Drawing.Point(12, 27);
            this.gbStats.Name = "gbStats";
            this.gbStats.Size = new System.Drawing.Size(410, 50);
            this.gbStats.TabIndex = 1;
            this.gbStats.TabStop = false;
            this.gbStats.Text = "Character Stats";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Position,
            this.Value,
            this.Heal,
            this.Percent,
            this.OneIn256,
            this.steal,
            this.stealCuffs});
            this.dataGridView1.Location = new System.Drawing.Point(13, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(516, 338);
            this.dataGridView1.TabIndex = 14;
            // 
            // Position
            // 
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            this.Position.ToolTipText = "Position in the RNG.";
            this.Position.Width = 70;
            // 
            // Value
            // 
            this.Value.FillWeight = 70F;
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.ToolTipText = "32 bit random number.";
            this.Value.Width = 70;
            // 
            // Heal
            // 
            this.Heal.FillWeight = 50F;
            this.Heal.HeaderText = "Heal";
            this.Heal.Name = "Heal";
            this.Heal.ReadOnly = true;
            this.Heal.ToolTipText = "How much you heal for at this number.";
            this.Heal.Width = 50;
            // 
            // Percent
            // 
            this.Percent.FillWeight = 50F;
            this.Percent.HeaderText = "%";
            this.Percent.Name = "Percent";
            this.Percent.ReadOnly = true;
            this.Percent.ToolTipText = "Random number mod 100 (percent chance events will use this for determinig sucess)" +
    ".";
            this.Percent.Width = 30;
            // 
            // OneIn256
            // 
            this.OneIn256.HeaderText = "1/256?";
            this.OneIn256.Name = "OneIn256";
            this.OneIn256.ToolTipText = "1/256 success rate. Used for Lvl99 Red Chocobo";
            this.OneIn256.Width = 53;
            // 
            // steal
            // 
            this.steal.HeaderText = "Steal";
            this.steal.Name = "steal";
            this.steal.ToolTipText = "What you would steal without thiefs cuffs.";
            // 
            // stealCuffs
            // 
            this.stealCuffs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stealCuffs.HeaderText = "Steal /w Cuffs";
            this.stealCuffs.Name = "stealCuffs";
            this.stealCuffs.ToolTipText = "What you would steal with thiefs cuffs.";
            // 
            // lblLastHeal
            // 
            this.lblLastHeal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLastHeal.AutoSize = true;
            this.lblLastHeal.Location = new System.Drawing.Point(5, 25);
            this.lblLastHeal.Name = "lblLastHeal";
            this.lblLastHeal.Size = new System.Drawing.Size(80, 13);
            this.lblLastHeal.TabIndex = 0;
            this.lblLastHeal.Text = "Last healed for:";
            // 
            // tbLastHeal
            // 
            this.tbLastHeal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbLastHeal.Location = new System.Drawing.Point(91, 22);
            this.tbLastHeal.Name = "tbLastHeal";
            this.tbLastHeal.Size = new System.Drawing.Size(79, 20);
            this.tbLastHeal.TabIndex = 11;
            this.tbLastHeal.Text = "81";
            this.tbLastHeal.Validating += new System.ComponentModel.CancelEventHandler(this.tbLastHeal_Validating);
            // 
            // btnBegin
            // 
            this.btnBegin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBegin.Location = new System.Drawing.Point(257, 19);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(79, 23);
            this.btnBegin.TabIndex = 13;
            this.btnBegin.Text = "Begin Search";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnContinue.Enabled = false;
            this.btnContinue.Location = new System.Drawing.Point(176, 20);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 23);
            this.btnContinue.TabIndex = 12;
            this.btnContinue.Text = "Continue Search";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearch.Controls.Add(this.tbLastHeal);
            this.groupBoxSearch.Controls.Add(this.btnContinue);
            this.groupBoxSearch.Controls.Add(this.lblLastHeal);
            this.groupBoxSearch.Controls.Add(this.btnBegin);
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 427);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(517, 51);
            this.groupBoxSearch.TabIndex = 2;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "RNG Search";
            // 
            // groupBoxChoose
            // 
            this.groupBoxChoose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxChoose.Controls.Add(this.btnCancel);
            this.groupBoxChoose.Controls.Add(this.btnGo);
            this.groupBoxChoose.Controls.Add(this.tbNumDisp);
            this.groupBoxChoose.Controls.Add(this.lblNumDisp);
            this.groupBoxChoose.Controls.Add(this.tbPosition);
            this.groupBoxChoose.Controls.Add(this.lblPosition);
            this.groupBoxChoose.Location = new System.Drawing.Point(13, 484);
            this.groupBoxChoose.Name = "groupBoxChoose";
            this.groupBoxChoose.Size = new System.Drawing.Size(516, 53);
            this.groupBoxChoose.TabIndex = 3;
            this.groupBoxChoose.TabStop = false;
            this.groupBoxChoose.Text = "Choose Your Own Adventure";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(341, 17);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(51, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(292, 17);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(43, 23);
            this.btnGo.TabIndex = 17;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // tbNumDisp
            // 
            this.tbNumDisp.Location = new System.Drawing.Point(223, 19);
            this.tbNumDisp.Name = "tbNumDisp";
            this.tbNumDisp.Size = new System.Drawing.Size(63, 20);
            this.tbNumDisp.TabIndex = 16;
            this.tbNumDisp.Text = "1000";
            this.tbNumDisp.Validating += new System.ComponentModel.CancelEventHandler(this.tbNumDisp_Validating);
            // 
            // lblNumDisp
            // 
            this.lblNumDisp.AutoSize = true;
            this.lblNumDisp.Location = new System.Drawing.Point(151, 22);
            this.lblNumDisp.Name = "lblNumDisp";
            this.lblNumDisp.Size = new System.Drawing.Size(66, 13);
            this.lblNumDisp.TabIndex = 2;
            this.lblNumDisp.Text = "# to Display:";
            // 
            // tbPosition
            // 
            this.tbPosition.Location = new System.Drawing.Point(59, 19);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(86, 20);
            this.tbPosition.TabIndex = 15;
            this.tbPosition.Text = "0";
            this.tbPosition.Validating += new System.ComponentModel.CancelEventHandler(this.tbPosition_Validating);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(6, 22);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(47, 13);
            this.lblPosition.TabIndex = 0;
            this.lblPosition.Text = "Position:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBarPercent,
            this.toolStripStatusLabelPercent,
            this.toolStripStatusLabelProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(541, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBarPercent
            // 
            this.toolStripProgressBarPercent.Name = "toolStripProgressBarPercent";
            this.toolStripProgressBarPercent.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabelPercent
            // 
            this.toolStripStatusLabelPercent.Name = "toolStripStatusLabelPercent";
            this.toolStripStatusLabelPercent.Size = new System.Drawing.Size(17, 17);
            this.toolStripStatusLabelPercent.Text = "%";
            // 
            // toolStripStatusLabelProgress
            // 
            this.toolStripStatusLabelProgress.Name = "toolStripStatusLabelProgress";
            this.toolStripStatusLabelProgress.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabelProgress.Text = "toolStripStatusLabel1";
            // 
            // backgroundWorkerConsume
            // 
            this.backgroundWorkerConsume.WorkerReportsProgress = true;
            this.backgroundWorkerConsume.WorkerSupportsCancellation = true;
            this.backgroundWorkerConsume.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerConsume_DoWork);
            this.backgroundWorkerConsume.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerConsume_ProgressChanged);
            this.backgroundWorkerConsume.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerConsume_RunWorkerCompleted);
            // 
            // gbPlatform
            // 
            this.gbPlatform.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPlatform.Controls.Add(this.cbPlatform);
            this.gbPlatform.Location = new System.Drawing.Point(429, 28);
            this.gbPlatform.Name = "gbPlatform";
            this.gbPlatform.Size = new System.Drawing.Size(100, 49);
            this.gbPlatform.TabIndex = 2;
            this.gbPlatform.TabStop = false;
            this.gbPlatform.Text = "Platform";
            // 
            // cbPlatform
            // 
            this.cbPlatform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlatform.FormattingEnabled = true;
            this.cbPlatform.Items.AddRange(new object[] {
            "PS2",
            "PS4"});
            this.cbPlatform.Location = new System.Drawing.Point(7, 18);
            this.cbPlatform.Name = "cbPlatform";
            this.cbPlatform.Size = new System.Drawing.Size(87, 21);
            this.cbPlatform.TabIndex = 10;
            this.cbPlatform.SelectionChangeCommitted += new System.EventHandler(this.cbPlatform_SelectionChangeCommitted);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 562);
            this.Controls.Add(this.gbPlatform);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBoxChoose);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbStats);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(557, 601);
            this.Name = "FormMain";
            this.Text = "FF12 RNG Helper";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbStats.ResumeLayout(false);
            this.gbStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBoxChoose.ResumeLayout(false);
            this.groupBoxChoose.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbPlatform.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox tbLevel;
        private System.Windows.Forms.TextBox tbMagic;
        private System.Windows.Forms.ComboBox cbSpellPow;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblMagic;
        private System.Windows.Forms.Label lblSpellPow;
        private System.Windows.Forms.CheckBox chkbSerenity;
        private System.Windows.Forms.GroupBox gbStats;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblLastHeal;
        private System.Windows.Forms.TextBox tbLastHeal;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.GroupBox groupBoxChoose;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox tbNumDisp;
        private System.Windows.Forms.Label lblNumDisp;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarPercent;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPercent;
        private System.ComponentModel.BackgroundWorker backgroundWorkerConsume;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelProgress;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Heal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent;
        private System.Windows.Forms.DataGridViewTextBoxColumn OneIn256;
        private System.Windows.Forms.DataGridViewTextBoxColumn steal;
        private System.Windows.Forms.DataGridViewTextBoxColumn stealCuffs;
        private System.Windows.Forms.GroupBox gbPlatform;
        private System.Windows.Forms.ComboBox cbPlatform;
    }
}

