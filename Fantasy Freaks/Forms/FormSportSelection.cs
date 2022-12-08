﻿using DataAccess.Interfaces;
using DataAccess.Models;
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
        private readonly ICurrentPlayerService _currentPlayer;
        public FormSportSelection(ITeamService teamService, IDefenseService defenseService, ICurrentPlayerService currentPlayer) {
            InitializeComponent();
            _teamService = teamService;
            _defenseService = defenseService;
            _currentPlayer = currentPlayer;
        }

        private void FormSportSelection_Load(object sender, EventArgs e) {
        }

        private void btnFootball_Click(object sender, EventArgs e) {
            FFWindow.instance.activeSport = Sport.Football;
            FFWindow.instance.changePanel(new FormTeamMaker(_teamService, _defenseService, _currentPlayer));
        }

        
    }
}