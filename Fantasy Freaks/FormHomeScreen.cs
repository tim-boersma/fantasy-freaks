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
    public partial class FormHomeScreen : Form {
        public static FormHomeScreen instance;


        public FormHomeScreen() { 
            InitializeComponent();
        }

        private void FormHomeScreen_Load(object sender, EventArgs e) {
            logo.Parent = titleBackground;
            title.Parent = titleBackground;
        }

        private void btnPlay_Click(object sender, EventArgs e) {
            FFWindow.instance.changePanel(new FormSportSelection());
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //FFWindow.instance.changePanel(new FormHelpScreen());
        }

    }

}
