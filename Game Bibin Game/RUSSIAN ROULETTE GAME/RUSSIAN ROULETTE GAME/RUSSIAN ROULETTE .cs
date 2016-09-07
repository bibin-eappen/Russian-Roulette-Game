using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace RUSSIAN_ROULETTE_GAME
{
    public partial class frmRussianRoulette : Form
    {
        int[] PlayerGun = new int[6] { 0, 0, 0, 0, 0, 0 };// Player and Computer Gun Chambers
        Random Rnd_Spin = new Random(); // Random No for the spin
        int PlayerChamber;
        int ChamberPull;
        int Shoot_Away = 0;
        int Game_Round = 1;
        int Player_Scores = 0;
        int Bonus_Points=100;
        int Seconds = 0;
        int Win = 0;
        int Loss = 0;
        int Bullet_Left=0, Bullet_Right=0;
        bool Game_Status = false;
        bool Round_Status = false;
        bool File_Flag=false ;
        public static String ScoreFile_Path = "S:\\Software\\Shared\\Bibin Works\\Russian R Scores\\ScoreFile.txt";
      // String ScoreFile_Path = "C:\\Users\\User\\Desktop\\Game Bibin Game\\ScoreFile.txt";
        

    
        public frmRussianRoulette()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            proBarRounds.Maximum = 6;
         }

        private void frmRussianRoulette_Load(object sender, EventArgs e)
        {
            btnSpin.Focus();
            Default_Events();
            lblPlayerName.Text = Login.Login_Player_Name;
            btnPlayAgain.Visible = false;
            btnPlaySameUser.Enabled = false;
           
         }

        
        private void btnShootU_Click(object sender, EventArgs e)
        {
            /* Shoot YourSelf */
             PBChamberSpin.Image = Properties.Resources.Gun_Right1;
           
            //lblChamber.Text = ChamberPull.ToString(); //To Know How many shots fired
            if (PlayerGun[ChamberPull] == 1)

            {
                Play_GunFire();
                PBBulletR.Image = Properties.Resources.Bullet_Right;
                PBBulletR.Left = PBBulletR.Left + 85; Bullet_Right = 80; Bullet_Left = 0;
                pbGameFrame.Image = Properties.Resources.Person_Dead;
                lblGameMessage.Text = "     Oops..Bad Luck..  ";
                lblGameMessage1.Text = "Load Bullet and Spin";
                Round_Status = true; // Round Over
                RoundOver(Round_Status);
                Game_Round++; lblRounds.Text = Game_Round.ToString();
            }
            else
            {
                /* Gun not fired */
                Play_DryFire();
                lblGameMessage.Text = "     Lucky You.. Try Next Shot   ";
                lblGameMessage1.Text = "          SHOOT        ";
                ChamberPull++;
                Shoot_Away = 0;
                Player_Scores += 10; lblScore.Text = Player_Scores.ToString();
            }
            if (Game_Round > 6) 
                {
                Player_Scores += Bonus_Points;
                f_GameOver();
                }
        }

        private void btnShootC_Click(object sender, EventArgs e)
        {
            /* Shoot Away */
            PBChamberSpin.Image = Properties.Resources.Gun_Left1;
           // lblChamber.Text = ChamberPull.ToString();
            if (PlayerGun[ChamberPull] == 1)
            { /* Gun fired in shoot away */
                Play_GlassBoken();
                PBBulletL.Image = Properties.Resources.Bullet_Left;                
                PBBulletL.Left = PBBulletL.Left -120;Bullet_Left = 120;Bullet_Right = 0;
                Player_Scores += Bonus_Points; lblScore.Text = Player_Scores.ToString();
                Game_Round++; lblRounds.Text = Game_Round.ToString();
                lblGameMessage.Text = "Lucky..You Won..100 Bonus Points.";
                lblGameMessage1.Text = " Load Bullet and Spin ";
                btnSpin.Focus();
                Round_Status = false;
                PBShootAwayFrame.Image = Properties.Resources.ShootAwayBroken;                
                //MessageBox.Show("Survived and next round");
                RoundOver(Game_Status);//Round over     
            }
            else

            {
                /* Gun not fired in shoot away */
                Play_DryFire();
                ChamberPull++;
                Shoot_Away++;//MessageBox.Show("Shoot Away Chance" + Shoot_Away.ToString());
                lblGameMessage.Text = "   You Lost 1 Shoot Away Chance  ";
            }
            if (Shoot_Away >= 2) /*shoot away counting only 2 chances allowed*/
            {   btnShootC.Enabled = false; btnShootU.Focus();
                lblGameMessage.Text = "   Bad Luck..Nomore Shoot Away  ";
                lblGameMessage1.Text = "    Shoot Yourself    ";
                ChamberPull = PlayerChamber; //Shoot U on the next click
            }

            if (Game_Round > 6)/* Total 6 rounds on the basis of 6 Bullets per Game */
            {
                
                Player_Scores += Bonus_Points;
                 f_GameOver();
            }
        }


        private void btnSpin_Click(object sender, EventArgs e)

        {/* Loading and Spinning Gun Chamber */
            File_Flag = true;
            btnSpin.Enabled = false;
            btnExit.Enabled = false;
            PBBulletR.Image = null; //Bulet image space adjuster
            PBBulletL.Image = null;

            lblGameMessage.Text = "  Shoot Yourself or Shoot Away..";
            lblGameMessage1.Text = "Click the Buttons Below";
            if (Game_Round <= 6)
            {
                Seconds = 0;
                PlayerChamber = Rnd_Spin.Next(0, 6);
                lblC.Text = Convert.ToString(PlayerChamber);
                TimerChamberLoad.Start();
                PBChamberSpin.Image = Properties.Resources.chamber_Spin;
                PlayerGun[PlayerChamber] = 1;
                proBarRounds.PerformStep();
                ChamberPull = 0; Shoot_Away = 0;
                
            }
            else
            {
                f_GameOver();                 
            }

            if (PBShootAwayFrame.Image != Properties.Resources.ShootAway1|| pbGameFrame.Image != Properties.Resources.Person1)
            {
                PBShootAwayFrame.Image = Properties.Resources.ShootAway1;
                pbGameFrame.Image = Properties.Resources.Person1;
            }
               PBBulletR.Left -= Bullet_Right; PBBulletL.Left += Bullet_Left; //Adjusting the Bullet image
          
            
        }
        public void RoundOver(bool Round_Status)/* Going to Next Round of Game*/
        {
            if (Round_Status == true)
            {   
                /* Going to next round after firing bullet at Shoot Yourself */
                btnSpin.Enabled = true;btnSpin.Focus();
                lblScore.Text = Player_Scores.ToString();
                Loss++; lblWinLoss.Text = Win + " / " + Loss;             
                ChamberPull = 0;
                Clear_Gun();            
                Round_Status = false;
            }
            else
            {
                /* Going to next round after firing bullet at Shoot Away */
                btnSpin.Enabled = true;
                Win++; lblWinLoss.Text = Win + " / " + Loss;
                lblRounds.Text = Game_Round.ToString();              
                ChamberPull = 0;       
                Clear_Gun();
            }


        }
        public void f_GameOver() /*Game Over after 6 Rounds */
        {
            btnSpin.Enabled = true;
            Write_Scores();
            dgvScores.Rows.Clear();
             Default_Events();
            Player_Scores = 0;
            ChamberPull = 0;           
            proBarRounds.Value = 0;
            Game_Round = 0;
            Game_Status = false;
            Clear_Gun();           
            lblGameMessage.Text =  "!!!  NO MORE BULLETS  GAME OVER  !!!    ";
            lblGameMessage1.Text = "   !!!  PLAY AGAIN   !!!         ";
            btnSpin.Visible = false;
            btnShootU.Enabled = false;
            btnShootC.Enabled = false;
            btnPlaySameUser.Enabled = true;
            btnPlayAgain.Visible = true;btnPlayAgain.Focus();
            
        }
        public void Default_Events() //Load Event Initializing
        {
            btnShootC.Enabled = false;
            btnShootU.Enabled = false;
            proBarRounds.Step = Game_Round;
            lblRounds.Text = Game_Round.ToString();
            lblScore.Text = Player_Scores.ToString();
            //lblChamber.Text = ChamberPull.ToString();
            Read_Scores();// Reading scores and displaying to file
            lblWinLoss.Text = "0 / 0";
            pbGameFrame.SizeMode = PictureBoxSizeMode.StretchImage;
            PBChamberSpin.SizeMode = PictureBoxSizeMode.StretchImage;
            PBShootAwayFrame.SizeMode = PictureBoxSizeMode.StretchImage;
            PBBulletR.SizeMode = PictureBoxSizeMode.StretchImage;
            PBBulletL.SizeMode = PictureBoxSizeMode.StretchImage;

        }
        
        // To Change Gun Positions on Mouse Over
       
        private void btnShootU_MouseMove(object sender, MouseEventArgs e)
        {
            if (PBChamberSpin.Image != Properties.Resources.Gun_Right1)
            {
                PBChamberSpin.Image = Properties.Resources.Gun_Right1;
            }
        }

        private void btnShootC_MouseMove(object sender, MouseEventArgs e)
        {
            if (PBChamberSpin.Image != Properties.Resources.Gun_Left1)
            {
                PBChamberSpin.Image = Properties.Resources.Gun_Left1;
            }
        }

        // Function to Write Scores in to a File Scores.txt
        public void Write_Scores()
        {
            try
            {
                using (StreamWriter ScoreWriter = new StreamWriter(ScoreFile_Path, true))
                {
                    ScoreWriter.Write(lblPlayerName.Text + "-" + Player_Scores +"-"+(Game_Round-1) + "-"+Win+"/"+Loss+"\r\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("File not open to write" + ex.Message);
            }
        }

        private void pbGameFrame_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            if (!File_Flag)
            {              
                File_Flag = false;
                this.Close();              
            }
            else
            {                
                Write_Scores(); this.Close();
            }
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Timer for Chamber load image,sound and buttons
        private void TimerChamberLoad_Tick(object sender, EventArgs e)
        {
            Seconds++;
            if (Seconds == 1) { Play_ChamberLoad(); }
            if (Seconds == 2)
            {
                //MessageBox.Show(Seconds.ToString());
                pbGameFrame.Image = Properties.Resources.Person1;
                PBChamberSpin.Image = Properties.Resources.Gun_Right1;
                PBShootAwayFrame.Image = Properties.Resources.ShootAway1;
                    TimerChamberLoad.Stop();
                Seconds = 0;
                btnShootU.Enabled = true;
                btnShootC.Enabled = true;
                btnSpin.Enabled = false;
                btnShootU.Focus();
                btnExit.Enabled = true;
            }
        }

        // Reading from score file..
        public void Read_Scores() 
        {
            try
            {
                using (StreamReader ScoreReader = new StreamReader(ScoreFile_Path))
                {
                    String Line; // Reading from file to this var
                    while ((Line = ScoreReader.ReadLine()) != null)
                    {
                        if (Line == String.Empty)
                        {
                            continue;
                        }
                        else
                        {
                            String[] Scores = Line.Split('-');
                            // Convert.ToInt16(Scores[1]);
                            dgvScores.Rows.Add(Scores[0], Convert.ToInt16(Scores[1]), Scores[2], Scores[3]);
                        }
                    }
                    dgvScores.Sort(dgvScores.Columns[1], ListSortDirection.Descending);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Read from file" + ex.Message);
            }
        }

        //Sounds
        public void Play_GunFire()
        {
            SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.GunFire);
            player.Play();
        }
        public void Play_DryFire()
        {
            SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.DryFire);
            player.Play();
        }
        public void Play_ChamberLoad()
        {
            SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Reload);
            player.Play();
        }
        public void Play_GlassBoken()
        {
            SoundPlayer player1 = new System.Media.SoundPlayer(Properties.Resources.GlassBroken);
            player1.Play();
        }

        private void btnPlaySameUser_Click(object sender, EventArgs e)
        {
            frmRussianRoulette Same_User = new frmRussianRoulette();
            this.Close();
            Same_User.Show();
        }


        //Function to clear PlayerGun Array
        public void Clear_Gun()
        {
            for (int i = 0; i < 6; i++) { PlayerGun[i] = 0; }
            btnShootC.Enabled = false;
            btnShootU.Enabled = false;
        }
    }
}
  
        
