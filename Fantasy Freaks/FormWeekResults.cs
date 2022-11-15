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
    public partial class FormWeekResults : Form {
        public FormWeekResults() {
            InitializeComponent();
        }


        private void buttonChangeRoster_Click(object sender, EventArgs e)
        {
            FFWindow.instance.changePanel(new FormChangeRoster());
        }

        /*if (week == 17)
        {
            
            private void btnNext_Click(object sender, EventArgs e)
            {
                FFWindow.instance.changePanel(new FormEndResults());
            }
            week++;
        }
        else
        {*/
        private void btnNext_Click(object sender, EventArgs e)
            {
                FFWindow.instance.changePanel(new FormUpcomingSeason());
            }
  
    }
}
