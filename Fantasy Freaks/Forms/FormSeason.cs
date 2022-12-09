﻿using DataAccess.Interfaces;
using DataAccess.Models;
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
        private readonly IDefenseService _defense;
        public FormSeason(ITeamService teamService, IDefenseService defenseService) {
            InitializeComponent();
            _team = teamService;
            _defense = defenseService;
        }

        private void btnWeekResults_Click(object sender, EventArgs e)
        {
            if(_team.CurrentWeek < 18)
            {
                FFWindow.instance.changePanel(new FormWeekResults(_team, _defense));
            } 
            else
            {
                FFWindow.instance.changePanel(new FormEndResults());
            }
        }

        private async void FormSeason_Load(object sender, EventArgs e)
        {
            FFWindow.instance.setFont(this);
            
            if (_team.EnemyTeams == null)
            {
                var teams = await _defense.RandomTeams(17);
                _team.EnemyTeams = teams.ToList();
            }

            LoadPanel(new FormSeasonOpponents(_team));

        }

        private void LoadPanel(Form newForm) {
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            newForm.ControlBox = false;
            newForm.Text = "";
            this.panelOpponents.Controls.Add(newForm);
            this.panelOpponents.Tag = newForm;
            newForm.BringToFront();
            newForm.Show();
        }
    }
}