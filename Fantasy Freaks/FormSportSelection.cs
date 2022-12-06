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

namespace Fantasy_Freaks {
    public partial class FormSportSelection : Form {
        private readonly ITeamService _teamService;
        private readonly IDefenseService _defenseService;
        public FormSportSelection(ITeamService teamService, IDefenseService defenseService) {
            InitializeComponent();
            _teamService = teamService;
            _defenseService = defenseService;
        }

        private void FormSportSelection_Load(object sender, EventArgs e) {
        }

        private void btnFootball_Click(object sender, EventArgs e) {
            FFWindow.instance.activeSport = Sport.Football;
            FFWindow.instance.changePanel(new FormTeamMaker(_teamService, _defenseService));
        }

        
    }
}
