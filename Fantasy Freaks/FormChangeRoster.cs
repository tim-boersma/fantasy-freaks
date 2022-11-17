using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fantasy_Freaks {
    public partial class FormChangeRoster : Form {
        public FormChangeRoster() {
            InitializeComponent();
        }

        //int pointsAllowed = WinStat.instance.TYscore(/*ty value*/);
        //int yardsAllowed = WinStat.instance.Tpscore(/*tp value*/);
        //int offScore = WinStat.instance.offScoreCalc(/*from table for off*/);
        //double defScore = WinStat.instance.defScoreCalc(/*from table for def, pointsAllowed, yardsAllowed*/);


        private void btnSeason_Click(object sender, EventArgs e)
        {
            FFWindow.instance.changePanel(new FormSeason());
        }

        private void btnQB_Click(object sender, EventArgs e)
        {

        }

        private void btnRB1_Click(object sender, EventArgs e)
        {

        }

        private void btnRB2_Click(object sender, EventArgs e)
        {

        }

        private void btnWR1_Click(object sender, EventArgs e)
        {

        }

        private void btnWR2_Click(object sender, EventArgs e)
        {

        }

        private void btnTE_Click(object sender, EventArgs e)
        {

        }

        private void btnFlex_Click(object sender, EventArgs e)
        {

        }

        private void btnBe1_Click(object sender, EventArgs e)
        {

        }

        private void btnBe2_Click(object sender, EventArgs e)
        {

        }

        private void btnBe3_Click(object sender, EventArgs e)
        {

        }

        private void btnBe4_Click(object sender, EventArgs e)
        {

        }

        private void btnBe5_Click(object sender, EventArgs e)
        {

        }

        private void btnBe6_Click(object sender, EventArgs e)
        {

        }

        private void btnBe7_Click(object sender, EventArgs e)
        {

        }

        private void btnBe8_Click(object sender, EventArgs e)
        {

        }
    }
}
