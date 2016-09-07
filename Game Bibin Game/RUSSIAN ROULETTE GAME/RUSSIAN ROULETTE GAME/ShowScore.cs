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

namespace RUSSIAN_ROULETTE_GAME
{
    public partial class frmShowScore : Form
    {

        String ScoreFile_Path;
       //String ScoreFile_Path = "C:\\Users\\User\\Desktop\\Game Bibin Game\\ScoreFile.txt";
        public frmShowScore()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ScoreFile_Path = frmRussianRoulette.ScoreFile_Path;
        }

        private void frmShowScore_Load(object sender, EventArgs e)
        {

            Read_Scores();
           
              
        }


        public void Read_Scores() // Reading from score file..
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
    }

}
