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
    public partial class FormHomeScreen : Form {
        public static FormHomeScreen instance;

        private readonly ITeamService _teamService;
        private readonly IDefenseService _defenseService;

        public FormHomeScreen(ITeamService teamService, IDefenseService defenseService)
        {
            InitializeComponent();
            instance = this;
            _teamService = teamService;
            _defenseService = defenseService;
            //activeForm = this;
        }

        private void FormHomeScreen_Load(object sender, EventArgs e) {
            logo.Parent = titleBackground;
            title.Parent = titleBackground;
        }

        private void btnPlay_Click(object sender, EventArgs e) {
            FFWindow.instance.changePanel(new FormSportSelection(_teamService, _defenseService));
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            FFWindow.instance.changePanel(new FormHelpScreen());
        }
    }
}
