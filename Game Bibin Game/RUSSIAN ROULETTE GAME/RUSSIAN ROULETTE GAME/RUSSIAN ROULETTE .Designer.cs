namespace RUSSIAN_ROULETTE_GAME
{
    partial class frmRussianRoulette
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnShootU = new System.Windows.Forms.Button();
            this.btnShootC = new System.Windows.Forms.Button();
            this.btnSpin = new System.Windows.Forms.Button();
            this.lblChamber = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.dgvScores = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRounds = new System.Windows.Forms.Label();
            this.lblGameRound = new System.Windows.Forms.Label();
            this.proBarRounds = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TimerChamberLoad = new System.Windows.Forms.Timer(this.components);
            this.lblPlayerL = new System.Windows.Forms.Label();
            this.gbTitle = new System.Windows.Forms.GroupBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblWinLoss = new System.Windows.Forms.Label();
            this.lblWL = new System.Windows.Forms.Label();
            this.lblScoreL = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblProBarBullets6 = new System.Windows.Forms.Label();
            this.lblProBarBullets5 = new System.Windows.Forms.Label();
            this.lblProBarBullets4 = new System.Windows.Forms.Label();
            this.lblProBarBullets3 = new System.Windows.Forms.Label();
            this.lblProBarBullets2 = new System.Windows.Forms.Label();
            this.lblProBarBullets1 = new System.Windows.Forms.Label();
            this.lblProBars = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.PanelMessage = new System.Windows.Forms.Panel();
            this.lblGameMessage = new System.Windows.Forms.Label();
            this.lblGameMessage1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.PBBulletL = new System.Windows.Forms.PictureBox();
            this.PBBulletR = new System.Windows.Forms.PictureBox();
            this.PBShootAwayFrame = new System.Windows.Forms.PictureBox();
            this.pbGameFrame = new System.Windows.Forms.PictureBox();
            this.PBChamberSpin = new System.Windows.Forms.PictureBox();
            this.lblC = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblSubTiltle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GBScores = new System.Windows.Forms.GroupBox();
            this.btnPlaySameUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScores)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.gbTitle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PanelMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBBulletL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBBulletR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBShootAwayFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBChamberSpin)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GBScores.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShootU
            // 
            this.btnShootU.BackColor = System.Drawing.Color.IndianRed;
            this.btnShootU.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShootU.Location = new System.Drawing.Point(532, 312);
            this.btnShootU.Name = "btnShootU";
            this.btnShootU.Size = new System.Drawing.Size(232, 65);
            this.btnShootU.TabIndex = 2;
            this.btnShootU.Text = "Shoot Yourself";
            this.btnShootU.UseVisualStyleBackColor = false;
            this.btnShootU.Click += new System.EventHandler(this.btnShootU_Click);
            this.btnShootU.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnShootU_MouseMove);
            // 
            // btnShootC
            // 
            this.btnShootC.BackColor = System.Drawing.Color.IndianRed;
            this.btnShootC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnShootC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShootC.Location = new System.Drawing.Point(268, 312);
            this.btnShootC.Name = "btnShootC";
            this.btnShootC.Size = new System.Drawing.Size(237, 65);
            this.btnShootC.TabIndex = 3;
            this.btnShootC.Text = "Shoot Away";
            this.btnShootC.UseVisualStyleBackColor = false;
            this.btnShootC.Click += new System.EventHandler(this.btnShootC_Click);
            this.btnShootC.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnShootC_MouseMove);
            // 
            // btnSpin
            // 
            this.btnSpin.BackColor = System.Drawing.Color.IndianRed;
            this.btnSpin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSpin.Location = new System.Drawing.Point(380, 19);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(242, 67);
            this.btnSpin.TabIndex = 0;
            this.btnSpin.Text = "Load Bullet Spin Chamber";
            this.btnSpin.UseVisualStyleBackColor = false;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // lblChamber
            // 
            this.lblChamber.AutoSize = true;
            this.lblChamber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChamber.Location = new System.Drawing.Point(1072, 9);
            this.lblChamber.Name = "lblChamber";
            this.lblChamber.Size = new System.Drawing.Size(46, 18);
            this.lblChamber.TabIndex = 7;
            this.lblChamber.Text = "label2";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Gold;
            this.lblScore.Location = new System.Drawing.Point(714, 28);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(70, 23);
            this.lblScore.TabIndex = 8;
            this.lblScore.Text = "label2";
            // 
            // dgvScores
            // 
            this.dgvScores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvScores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvScores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvScores.Location = new System.Drawing.Point(286, 34);
            this.dgvScores.Name = "dgvScores";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvScores.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvScores.Size = new System.Drawing.Size(499, 110);
            this.dgvScores.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Player Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 138;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Scores";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 87;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Round Played";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 148;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Won/Lost";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 116;
            // 
            // lblRounds
            // 
            this.lblRounds.AutoSize = true;
            this.lblRounds.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRounds.ForeColor = System.Drawing.Color.Gold;
            this.lblRounds.Location = new System.Drawing.Point(503, 28);
            this.lblRounds.Name = "lblRounds";
            this.lblRounds.Size = new System.Drawing.Size(76, 23);
            this.lblRounds.TabIndex = 12;
            this.lblRounds.Text = "Round";
            // 
            // lblGameRound
            // 
            this.lblGameRound.AutoSize = true;
            this.lblGameRound.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameRound.ForeColor = System.Drawing.Color.Gold;
            this.lblGameRound.Location = new System.Drawing.Point(421, 28);
            this.lblGameRound.Name = "lblGameRound";
            this.lblGameRound.Size = new System.Drawing.Size(93, 23);
            this.lblGameRound.TabIndex = 13;
            this.lblGameRound.Text = "Round : ";
            // 
            // proBarRounds
            // 
            this.proBarRounds.BackColor = System.Drawing.Color.IndianRed;
            this.proBarRounds.ForeColor = System.Drawing.Color.Transparent;
            this.proBarRounds.Location = new System.Drawing.Point(251, 415);
            this.proBarRounds.Name = "proBarRounds";
            this.proBarRounds.Size = new System.Drawing.Size(536, 44);
            this.proBarRounds.TabIndex = 14;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 913);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1115, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(142, 17);
            this.toolStripStatusLabel1.Text = "Russian Roulette Progress";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 913);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(120, 21);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // TimerChamberLoad
            // 
            this.TimerChamberLoad.Interval = 925;
            this.TimerChamberLoad.Tick += new System.EventHandler(this.TimerChamberLoad_Tick);
            // 
            // lblPlayerL
            // 
            this.lblPlayerL.AutoSize = true;
            this.lblPlayerL.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerL.ForeColor = System.Drawing.Color.Gold;
            this.lblPlayerL.Location = new System.Drawing.Point(68, 28);
            this.lblPlayerL.Name = "lblPlayerL";
            this.lblPlayerL.Size = new System.Drawing.Size(90, 23);
            this.lblPlayerL.TabIndex = 4;
            this.lblPlayerL.Text = "Player  :";
            this.lblPlayerL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbTitle
            // 
            this.gbTitle.Controls.Add(this.lblPlayerName);
            this.gbTitle.Controls.Add(this.lblWinLoss);
            this.gbTitle.Controls.Add(this.lblWL);
            this.gbTitle.Controls.Add(this.lblScoreL);
            this.gbTitle.Controls.Add(this.lblPlayerL);
            this.gbTitle.Controls.Add(this.lblRounds);
            this.gbTitle.Controls.Add(this.lblGameRound);
            this.gbTitle.Controls.Add(this.lblScore);
            this.gbTitle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTitle.ForeColor = System.Drawing.Color.Gold;
            this.gbTitle.Location = new System.Drawing.Point(38, 130);
            this.gbTitle.Name = "gbTitle";
            this.gbTitle.Size = new System.Drawing.Size(1037, 70);
            this.gbTitle.TabIndex = 19;
            this.gbTitle.TabStop = false;
            this.gbTitle.Text = "Player Details";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.Gold;
            this.lblPlayerName.Location = new System.Drawing.Point(164, 28);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(135, 23);
            this.lblPlayerName.TabIndex = 17;
            this.lblPlayerName.Text = "Player Name";
            // 
            // lblWinLoss
            // 
            this.lblWinLoss.AutoSize = true;
            this.lblWinLoss.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinLoss.ForeColor = System.Drawing.Color.Gold;
            this.lblWinLoss.Location = new System.Drawing.Point(926, 28);
            this.lblWinLoss.Name = "lblWinLoss";
            this.lblWinLoss.Size = new System.Drawing.Size(19, 23);
            this.lblWinLoss.TabIndex = 16;
            this.lblWinLoss.Text = "/";
            // 
            // lblWL
            // 
            this.lblWL.AutoSize = true;
            this.lblWL.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWL.ForeColor = System.Drawing.Color.Gold;
            this.lblWL.Location = new System.Drawing.Point(809, 28);
            this.lblWL.Name = "lblWL";
            this.lblWL.Size = new System.Drawing.Size(122, 23);
            this.lblWL.TabIndex = 15;
            this.lblWL.Text = "Win/Loss : ";
            // 
            // lblScoreL
            // 
            this.lblScoreL.AutoSize = true;
            this.lblScoreL.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreL.ForeColor = System.Drawing.Color.Gold;
            this.lblScoreL.Location = new System.Drawing.Point(636, 28);
            this.lblScoreL.Name = "lblScoreL";
            this.lblScoreL.Size = new System.Drawing.Size(77, 23);
            this.lblScoreL.TabIndex = 14;
            this.lblScoreL.Text = "Score :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Controls.Add(this.btnPlaySameUser);
            this.groupBox1.Controls.Add(this.lblProBarBullets6);
            this.groupBox1.Controls.Add(this.lblProBarBullets5);
            this.groupBox1.Controls.Add(this.lblProBarBullets4);
            this.groupBox1.Controls.Add(this.lblProBarBullets3);
            this.groupBox1.Controls.Add(this.lblProBarBullets2);
            this.groupBox1.Controls.Add(this.lblProBarBullets1);
            this.groupBox1.Controls.Add(this.lblProBars);
            this.groupBox1.Controls.Add(this.btnPlayAgain);
            this.groupBox1.Controls.Add(this.PanelMessage);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.PBBulletL);
            this.groupBox1.Controls.Add(this.PBBulletR);
            this.groupBox1.Controls.Add(this.PBShootAwayFrame);
            this.groupBox1.Controls.Add(this.pbGameFrame);
            this.groupBox1.Controls.Add(this.PBChamberSpin);
            this.groupBox1.Controls.Add(this.btnSpin);
            this.groupBox1.Controls.Add(this.btnShootU);
            this.groupBox1.Controls.Add(this.btnShootC);
            this.groupBox1.Controls.Add(this.proBarRounds);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(38, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1037, 478);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game";
            // 
            // lblProBarBullets6
            // 
            this.lblProBarBullets6.AutoSize = true;
            this.lblProBarBullets6.Location = new System.Drawing.Point(767, 392);
            this.lblProBarBullets6.Name = "lblProBarBullets6";
            this.lblProBarBullets6.Size = new System.Drawing.Size(22, 23);
            this.lblProBarBullets6.TabIndex = 34;
            this.lblProBarBullets6.Text = "6";
            // 
            // lblProBarBullets5
            // 
            this.lblProBarBullets5.AutoSize = true;
            this.lblProBarBullets5.Location = new System.Drawing.Point(682, 391);
            this.lblProBarBullets5.Name = "lblProBarBullets5";
            this.lblProBarBullets5.Size = new System.Drawing.Size(21, 23);
            this.lblProBarBullets5.TabIndex = 33;
            this.lblProBarBullets5.Text = "5";
            // 
            // lblProBarBullets4
            // 
            this.lblProBarBullets4.AutoSize = true;
            this.lblProBarBullets4.Location = new System.Drawing.Point(585, 391);
            this.lblProBarBullets4.Name = "lblProBarBullets4";
            this.lblProBarBullets4.Size = new System.Drawing.Size(22, 23);
            this.lblProBarBullets4.TabIndex = 32;
            this.lblProBarBullets4.Text = "4";
            // 
            // lblProBarBullets3
            // 
            this.lblProBarBullets3.AutoSize = true;
            this.lblProBarBullets3.Location = new System.Drawing.Point(497, 391);
            this.lblProBarBullets3.Name = "lblProBarBullets3";
            this.lblProBarBullets3.Size = new System.Drawing.Size(22, 23);
            this.lblProBarBullets3.TabIndex = 31;
            this.lblProBarBullets3.Text = "3";
            // 
            // lblProBarBullets2
            // 
            this.lblProBarBullets2.AutoSize = true;
            this.lblProBarBullets2.Location = new System.Drawing.Point(405, 391);
            this.lblProBarBullets2.Name = "lblProBarBullets2";
            this.lblProBarBullets2.Size = new System.Drawing.Size(22, 23);
            this.lblProBarBullets2.TabIndex = 30;
            this.lblProBarBullets2.Text = "2";
            // 
            // lblProBarBullets1
            // 
            this.lblProBarBullets1.AutoSize = true;
            this.lblProBarBullets1.Location = new System.Drawing.Point(321, 391);
            this.lblProBarBullets1.Name = "lblProBarBullets1";
            this.lblProBarBullets1.Size = new System.Drawing.Size(19, 23);
            this.lblProBarBullets1.TabIndex = 29;
            this.lblProBarBullets1.Text = "1";
            // 
            // lblProBars
            // 
            this.lblProBars.AutoSize = true;
            this.lblProBars.BackColor = System.Drawing.Color.IndianRed;
            this.lblProBars.ForeColor = System.Drawing.Color.Gold;
            this.lblProBars.Location = new System.Drawing.Point(245, 392);
            this.lblProBars.Name = "lblProBars";
            this.lblProBars.Size = new System.Drawing.Size(75, 23);
            this.lblProBars.TabIndex = 28;
            this.lblProBars.Text = "Bullet ";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.IndianRed;
            this.btnPlayAgain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPlayAgain.Location = new System.Drawing.Point(406, 30);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(201, 44);
            this.btnPlayAgain.TabIndex = 27;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // PanelMessage
            // 
            this.PanelMessage.Controls.Add(this.lblGameMessage);
            this.PanelMessage.Controls.Add(this.lblGameMessage1);
            this.PanelMessage.Location = new System.Drawing.Point(324, 241);
            this.PanelMessage.Name = "PanelMessage";
            this.PanelMessage.Size = new System.Drawing.Size(365, 62);
            this.PanelMessage.TabIndex = 26;
            // 
            // lblGameMessage
            // 
            this.lblGameMessage.AutoSize = true;
            this.lblGameMessage.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameMessage.Location = new System.Drawing.Point(34, 16);
            this.lblGameMessage.Name = "lblGameMessage";
            this.lblGameMessage.Size = new System.Drawing.Size(239, 18);
            this.lblGameMessage.TabIndex = 24;
            this.lblGameMessage.Text = "Please Load Bullet and Spin";
            this.lblGameMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGameMessage1
            // 
            this.lblGameMessage1.AutoSize = true;
            this.lblGameMessage1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameMessage1.Location = new System.Drawing.Point(67, 43);
            this.lblGameMessage1.Name = "lblGameMessage1";
            this.lblGameMessage1.Size = new System.Drawing.Size(0, 18);
            this.lblGameMessage1.TabIndex = 25;
            this.lblGameMessage1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(811, 405);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(201, 54);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // PBBulletL
            // 
            this.PBBulletL.Location = new System.Drawing.Point(324, 111);
            this.PBBulletL.Name = "PBBulletL";
            this.PBBulletL.Size = new System.Drawing.Size(34, 25);
            this.PBBulletL.TabIndex = 22;
            this.PBBulletL.TabStop = false;
            // 
            // PBBulletR
            // 
            this.PBBulletR.Location = new System.Drawing.Point(642, 111);
            this.PBBulletR.Name = "PBBulletR";
            this.PBBulletR.Size = new System.Drawing.Size(32, 25);
            this.PBBulletR.TabIndex = 21;
            this.PBBulletR.TabStop = false;
            // 
            // PBShootAwayFrame
            // 
            this.PBShootAwayFrame.Location = new System.Drawing.Point(25, 57);
            this.PBShootAwayFrame.Name = "PBShootAwayFrame";
            this.PBShootAwayFrame.Size = new System.Drawing.Size(276, 210);
            this.PBShootAwayFrame.TabIndex = 20;
            this.PBShootAwayFrame.TabStop = false;
            // 
            // pbGameFrame
            // 
            this.pbGameFrame.Location = new System.Drawing.Point(691, 63);
            this.pbGameFrame.Name = "pbGameFrame";
            this.pbGameFrame.Size = new System.Drawing.Size(299, 210);
            this.pbGameFrame.TabIndex = 19;
            this.pbGameFrame.TabStop = false;
            this.pbGameFrame.Click += new System.EventHandler(this.pbGameFrame_Click);
            // 
            // PBChamberSpin
            // 
            this.PBChamberSpin.Location = new System.Drawing.Point(380, 102);
            this.PBChamberSpin.Name = "PBChamberSpin";
            this.PBChamberSpin.Size = new System.Drawing.Size(242, 134);
            this.PBChamberSpin.TabIndex = 18;
            this.PBChamberSpin.TabStop = false;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(1083, 37);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(35, 13);
            this.lblC.TabIndex = 21;
            this.lblC.Text = "label2";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.lblSubTiltle);
            this.groupBox2.Controls.Add(this.lblTitle);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(37, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1038, 114);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::RUSSIAN_ROULETTE_GAME.Properties.Resources.Point;
            this.pictureBox2.Location = new System.Drawing.Point(703, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lblSubTiltle
            // 
            this.lblSubTiltle.AutoSize = true;
            this.lblSubTiltle.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTiltle.ForeColor = System.Drawing.Color.Gold;
            this.lblSubTiltle.Location = new System.Drawing.Point(420, 76);
            this.lblSubTiltle.Name = "lblSubTiltle";
            this.lblSubTiltle.Size = new System.Drawing.Size(161, 35);
            this.lblSubTiltle.TabIndex = 1;
            this.lblSubTiltle.Text = "ShootoutGame";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Sitka Banner", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gold;
            this.lblTitle.Location = new System.Drawing.Point(331, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(360, 69);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Russian Roulette";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::RUSSIAN_ROULETTE_GAME.Properties.Resources.Point;
            this.pictureBox1.Location = new System.Drawing.Point(223, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // GBScores
            // 
            this.GBScores.Controls.Add(this.dgvScores);
            this.GBScores.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBScores.ForeColor = System.Drawing.Color.Gold;
            this.GBScores.Location = new System.Drawing.Point(37, 690);
            this.GBScores.Name = "GBScores";
            this.GBScores.Size = new System.Drawing.Size(1038, 200);
            this.GBScores.TabIndex = 23;
            this.GBScores.TabStop = false;
            this.GBScores.Text = "Scores";
            // 
            // btnPlaySameUser
            // 
            this.btnPlaySameUser.BackColor = System.Drawing.Color.IndianRed;
            this.btnPlaySameUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPlaySameUser.Location = new System.Drawing.Point(25, 405);
            this.btnPlaySameUser.Name = "btnPlaySameUser";
            this.btnPlaySameUser.Size = new System.Drawing.Size(201, 54);
            this.btnPlaySameUser.TabIndex = 35;
            this.btnPlaySameUser.Text = "Play As Same User";
            this.btnPlaySameUser.UseVisualStyleBackColor = false;
            this.btnPlaySameUser.Click += new System.EventHandler(this.btnPlaySameUser_Click);
            // 
            // frmRussianRoulette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1115, 935);
            this.Controls.Add(this.GBScores);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbTitle);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblChamber);
            this.Controls.Add(this.statusStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRussianRoulette";
            this.Text = "RUSSIAN ROULETTE GAME";
            this.Load += new System.EventHandler(this.frmRussianRoulette_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScores)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbTitle.ResumeLayout(false);
            this.gbTitle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PanelMessage.ResumeLayout(false);
            this.PanelMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBBulletL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBBulletR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBShootAwayFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBChamberSpin)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GBScores.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShootU;
        private System.Windows.Forms.Button btnShootC;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Label lblChamber;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.DataGridView dgvScores;
        private System.Windows.Forms.Label lblRounds;
        private System.Windows.Forms.Label lblGameRound;
        private System.Windows.Forms.ProgressBar proBarRounds;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer TimerChamberLoad;
        private System.Windows.Forms.Label lblPlayerL;
        private System.Windows.Forms.GroupBox gbTitle;
        private System.Windows.Forms.Label lblScoreL;
        private System.Windows.Forms.Label lblWinLoss;
        private System.Windows.Forms.Label lblWL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox PBChamberSpin;
        private System.Windows.Forms.PictureBox pbGameFrame;
        private System.Windows.Forms.PictureBox PBShootAwayFrame;
        private System.Windows.Forms.PictureBox PBBulletR;
        private System.Windows.Forms.PictureBox PBBulletL;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblGameMessage;
        private System.Windows.Forms.Label lblGameMessage1;
        private System.Windows.Forms.Panel PanelMessage;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Label lblProBars;
        private System.Windows.Forms.Label lblProBarBullets1;
        private System.Windows.Forms.Label lblProBarBullets6;
        private System.Windows.Forms.Label lblProBarBullets5;
        private System.Windows.Forms.Label lblProBarBullets4;
        private System.Windows.Forms.Label lblProBarBullets3;
        private System.Windows.Forms.Label lblProBarBullets2;
        private System.Windows.Forms.Label lblSubTiltle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox GBScores;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnPlaySameUser;
    }
}

