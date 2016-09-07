namespace RUSSIAN_ROULETTE_GAME
{
    partial class Login
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
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnScores = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbLoginContent = new System.Windows.Forms.GroupBox();
            this.btnReadMe = new System.Windows.Forms.Button();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.gbLoginTitle = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbLoginContent.SuspendLayout();
            this.gbLoginTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.BackColor = System.Drawing.Color.IndianRed;
            this.txtPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlayerName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerName.ForeColor = System.Drawing.Color.Gold;
            this.txtPlayerName.Location = new System.Drawing.Point(110, 58);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(192, 26);
            this.txtPlayerName.TabIndex = 1;
            this.txtPlayerName.Text = "Name Here";
            this.txtPlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPlayerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlayerName_KeyPress);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.IndianRed;
            this.btnPlay.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Gold;
            this.btnPlay.Location = new System.Drawing.Point(108, 99);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(192, 58);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnScores
            // 
            this.btnScores.BackColor = System.Drawing.Color.IndianRed;
            this.btnScores.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScores.ForeColor = System.Drawing.Color.Gold;
            this.btnScores.Location = new System.Drawing.Point(108, 172);
            this.btnScores.Name = "btnScores";
            this.btnScores.Size = new System.Drawing.Size(192, 55);
            this.btnScores.TabIndex = 3;
            this.btnScores.Text = "Scores";
            this.btnScores.UseVisualStyleBackColor = false;
            this.btnScores.Click += new System.EventHandler(this.btnScores_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Gold;
            this.btnExit.Location = new System.Drawing.Point(110, 303);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(192, 54);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbLoginContent
            // 
            this.gbLoginContent.Controls.Add(this.btnReadMe);
            this.gbLoginContent.Controls.Add(this.lblPlayerName);
            this.gbLoginContent.Controls.Add(this.btnPlay);
            this.gbLoginContent.Controls.Add(this.btnExit);
            this.gbLoginContent.Controls.Add(this.txtPlayerName);
            this.gbLoginContent.Controls.Add(this.btnScores);
            this.gbLoginContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbLoginContent.Location = new System.Drawing.Point(46, 162);
            this.gbLoginContent.Name = "gbLoginContent";
            this.gbLoginContent.Size = new System.Drawing.Size(424, 376);
            this.gbLoginContent.TabIndex = 4;
            this.gbLoginContent.TabStop = false;
            this.gbLoginContent.Text = "Please Select";
            // 
            // btnReadMe
            // 
            this.btnReadMe.BackColor = System.Drawing.Color.IndianRed;
            this.btnReadMe.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadMe.ForeColor = System.Drawing.Color.Gold;
            this.btnReadMe.Location = new System.Drawing.Point(108, 238);
            this.btnReadMe.Name = "btnReadMe";
            this.btnReadMe.Size = new System.Drawing.Size(192, 55);
            this.btnReadMe.TabIndex = 4;
            this.btnReadMe.Text = "Guide";
            this.btnReadMe.UseVisualStyleBackColor = false;
            this.btnReadMe.Click += new System.EventHandler(this.btnReadMe_Click);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.Gold;
            this.lblPlayerName.Location = new System.Drawing.Point(152, 30);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(113, 18);
            this.lblPlayerName.TabIndex = 5;
            this.lblPlayerName.Text = "Player Name";
            // 
            // gbLoginTitle
            // 
            this.gbLoginTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbLoginTitle.Controls.Add(this.pictureBox1);
            this.gbLoginTitle.Controls.Add(this.pictureBox2);
            this.gbLoginTitle.Controls.Add(this.lblTitle);
            this.gbLoginTitle.Location = new System.Drawing.Point(46, 25);
            this.gbLoginTitle.Name = "gbLoginTitle";
            this.gbLoginTitle.Size = new System.Drawing.Size(424, 118);
            this.gbLoginTitle.TabIndex = 5;
            this.gbLoginTitle.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::RUSSIAN_ROULETTE_GAME.Properties.Resources.Point;
            this.pictureBox1.Location = new System.Drawing.Point(334, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::RUSSIAN_ROULETTE_GAME.Properties.Resources.Point;
            this.pictureBox2.Location = new System.Drawing.Point(28, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Sitka Banner", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gold;
            this.lblTitle.Location = new System.Drawing.Point(89, 43);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(239, 47);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Russian Roulette";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(522, 579);
            this.Controls.Add(this.gbLoginTitle);
            this.Controls.Add(this.gbLoginContent);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Russian Roulette Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.gbLoginContent.ResumeLayout(false);
            this.gbLoginContent.PerformLayout();
            this.gbLoginTitle.ResumeLayout(false);
            this.gbLoginTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnScores;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbLoginContent;
        private System.Windows.Forms.GroupBox gbLoginTitle;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnReadMe;
    }
}