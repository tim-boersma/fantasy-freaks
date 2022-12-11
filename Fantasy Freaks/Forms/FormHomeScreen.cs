using DataAccess.Interfaces;
using DataAccess.Models;
using System;
using System.Windows.Forms;

namespace Fantasy_Freaks {
    public partial class FormHomeScreen : Form {
        public static FormHomeScreen instance;

        private readonly ITeamService _teamService;
        private readonly IDefenseService _defenseService;
        private readonly ICurrentPlayerService _currentPlayer;

        public FormHomeScreen(ITeamService teamService, IDefenseService defenseService, ICurrentPlayerService currentPlayer)
        {
            InitializeComponent();
            instance = this;
            _teamService = teamService;
            _defenseService = defenseService;
            _currentPlayer = currentPlayer;
        }

        private void FormHomeScreen_Load(object sender, EventArgs e) {
            FFWindow.instance.setFont(this);
            logo.Parent = titleBackground;
            title.Parent = titleBackground;
        }

        private void btnPlay_Click(object sender, EventArgs e) {
            FFWindow.instance.changePanel(new FormSportSelection(_teamService, _defenseService, _currentPlayer));
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            FFWindow.instance.changePanel(new FormHelpScreen(_teamService, _defenseService, _currentPlayer));
        }

    }
}
