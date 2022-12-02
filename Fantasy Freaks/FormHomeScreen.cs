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

        private readonly IDefenseService _defenseService;
        private readonly IPreviousPlayerService _previousPlayerService;
        private readonly IPlayerPerformanceService _playerService;
        private IEnumerable<PlayerPerformanceDataModel> _players;

        public FormHomeScreen(IDefenseService defenseService, IPreviousPlayerService previousPlayerService, IPlayerPerformanceService playerService)
        {
            InitializeComponent();
            instance = this;
            _defenseService = defenseService;
            _previousPlayerService = previousPlayerService;
            _playerService = playerService;
            //activeForm = this;
        }

        private void FormHomeScreen_Load(object sender, EventArgs e) {
            logo.Parent = titleBackground;
            title.Parent = titleBackground;
        }

        private void btnPlay_Click(object sender, EventArgs e) {
            FFWindow.instance.changePanel(new FormSportSelection());
        }

        private async void btnHelp_Click(object sender, EventArgs e)
        {
            await DBTest();
            //FFWindow.instance.changePanel(new FormHelpScreen());
        }

        private async Task DBTest()
        {
            var test = await _previousPlayerService.GetAllQuarterBacks();
        }

    }

}
