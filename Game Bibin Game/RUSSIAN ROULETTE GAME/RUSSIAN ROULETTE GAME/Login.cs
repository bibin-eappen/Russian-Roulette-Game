using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RUSSIAN_ROULETTE_GAME
{
    public partial class Login : Form
    {
        public static String Login_Player_Name;
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (txtPlayerName.Text != "")/* validating empty textbox */
            {
                frmRussianRoulette f2 = new frmRussianRoulette();
                //f2.Show();
                Login_Player_Name = txtPlayerName.Text;
                txtPlayerName.Clear(); txtPlayerName.Focus();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Enter Player Name : ");
                txtPlayerName.Focus();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPlayerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) { }
            else if (char.IsSymbol(e.KeyChar)) { }
            else if (e.KeyChar == (char)Keys.Back) { }
            else e.Handled = true;
        }

        /* Validating and Next Step on Enter Key */
        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPlayerName.Text != "")
                {
                    Login_Player_Name = txtPlayerName.Text;
                    btnPlay.Focus();
                }
                else
                {
                    MessageBox.Show("Please Enter Player Name");
                    txtPlayerName.Focus();
                }
            }
        }

        private void btnScores_Click(object sender, EventArgs e)
        {
            frmShowScore Score = new frmShowScore();
            Score.ShowDialog();
        }

        /* Readme file on Notepad*/
        private void btnReadMe_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", "S:\\Software\\Shared\\Bibin Works\\ReadME_RR.txt");

        }
    }
}
