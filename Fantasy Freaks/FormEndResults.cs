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


        WinStat foo = new WinStat();
        //int dayEvent = foo.eventDay();
        //int pointsAllowed = foo.TYscore(/*ty value*/);
        //int yardsAllowed = foo.Tpscore(/*tp value*/)
        //foo.offScoreCalc(/*from table for off*/)
        //foo.defScoreCalc(/*from table for off, pointsAllowed, yardsAllowed*/)

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
