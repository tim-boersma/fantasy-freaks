using DataAccess.Interfaces;
using DataAccess.Models;
using System;
using System.Windows.Forms;

namespace Fantasy_Freaks
{
    public partial class FormHelpScreen : Form
    {
        private readonly ITeamService _teamService;
        private readonly IDefenseService _defenseService;
        private readonly ICurrentPlayerService _currentPlayer;

        public FormHelpScreen(ITeamService teamService, IDefenseService defenseService, ICurrentPlayerService currentPlayer) {
            InitializeComponent();
            _teamService = teamService;
            _defenseService = defenseService;
            _defenseService = defenseService;
            _currentPlayer = currentPlayer;
            //activeForm = this;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FFWindow.instance.changePanel(new FormHomeScreen(_teamService, _defenseService, _currentPlayer));
        }

        private void FormHelpScreen_Load(object sender, EventArgs e) {
            FFWindow.instance.setFont(this);
        }
    }
}
