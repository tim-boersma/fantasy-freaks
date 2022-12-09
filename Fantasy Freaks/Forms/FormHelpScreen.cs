using Fantasy_Freaks.Interfaces;
using Fantasy_Freaks.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fantasy_Freaks
{
    public partial class FormHelpScreen : Form
    {
        private readonly ITeamService _teamService;
        private readonly IDefenseService _defenseService;

        public FormHelpScreen(ITeamService teamService, IDefenseService defenseService) {
            InitializeComponent();
            _teamService = teamService;
            _defenseService = defenseService;
            //activeForm = this;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FFWindow.instance.changePanel(new FormHomeScreen(_teamService, _defenseService));
        }

        private void FormHelpScreen_Load(object sender, EventArgs e) {
            FFWindow.instance.setFont(this);
        }
    }
}
