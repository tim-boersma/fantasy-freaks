using Fantasy_Freaks.Interfaces;
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

namespace Fantasy_Freaks {
    public partial class FormSeason : Form {
        private readonly ITeamService _team;
        public FormSeason(ITeamService teamService) {
            InitializeComponent();
            _team = teamService;
        }

        private void btnWeekResults_Click(object sender, EventArgs e)
        {
            _team.NextWeek();
            if(_team.CurrentWeek < 18)
            {
                FFWindow.instance.changePanel(new FormWeekResults(_team));
            } 
            else
            {
                FFWindow.instance.changePanel(new FormEndResults());
            }
        }
    }
}
