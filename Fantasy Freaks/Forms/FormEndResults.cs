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
    public partial class FormEndResults : Form {
        public FormEndResults() {
            InitializeComponent();
        }

        //int pointsAllowed = WinStat.TYscore(/*ty value*/);
        //int yardsAllowed = WinStat.Tpscore(/*tp value*/);
        //int offScore = WinStat.offScoreCalc(/*from table for off*/);
        //double defScore = WinStat.defScoreCalc(/*from table for def, pointsAllowed, yardsAllowed*/);

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
