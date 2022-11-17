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

        //int pointsAllowed = WinStat.instance.TYscore(/*ty value*/);
        //int yardsAllowed = WinStat.instance.Tpscore(/*tp value*/);
        //int offScore = WinStat.instance.offScoreCalc(/*from table for off*/);
        //double defScore = WinStat.instance.defScoreCalc(/*from table for def, pointsAllowed, yardsAllowed*/);

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            FFWindow.instance.changePanel(new FormHelpScreen());
        }
    }
}
