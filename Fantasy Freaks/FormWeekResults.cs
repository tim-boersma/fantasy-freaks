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
    public partial class FormWeekResults : Form {

        private ITeamService _teamService;
        private IDefenseService _defenseService;
        public FormWeekResults(ITeamService teamService, IDefenseService defenseService) {
            InitializeComponent();
            _teamService = teamService;
            _defenseService = defenseService;
        }


        private void buttonChangeRoster_Click(object sender, EventArgs e)
        {
            FFWindow.instance.changePanel(new FormChangeRoster(_teamService, _defenseService));
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            FFWindow.instance.changePanel(new FormSeason(_teamService, _defenseService));
        }

        private async void FormWeekResults_Load(object sender, EventArgs e)
        {
            FFWindow.instance.setFont(this);

            var EnemyTeam = _teamService.GetCurrentOpponent();

            OPPlabel.Text = EnemyTeam.TeamName;

            int FFeventDay = WinStat.EventForDay();
            int OPPeventDay = WinStat.EventForDay();

            if(FFeventDay == 0)
            {
                FFDayimg.Image = Fantasy_Freaks.Properties.Resources.day0;
                _teamService.TotalInjuries++;
            }
            else if(FFeventDay == 1)
            {
                FFDayimg.Image = Fantasy_Freaks.Properties.Resources.day1;
                _teamService.TotalBadDays++;
            }
            else if (FFeventDay == 2)
            {
                FFDayimg.Image = Fantasy_Freaks.Properties.Resources.day2;
                _teamService.TotalAveragePoints++;

            }
            else if (FFeventDay == 3)
            {
                FFDayimg.Image = Fantasy_Freaks.Properties.Resources.day3;
                _teamService.TotalGoodDays++;
            }
            else
            {
                FFDayimg.Image = Fantasy_Freaks.Properties.Resources.day4;
                _teamService.TotalMiraclePlays++;
            }

            if (OPPeventDay == 0)
            {
                OPPDayimg.Image = Fantasy_Freaks.Properties.Resources.day0;
            }
            else if (FFeventDay == 1)
            {
                OPPDayimg.Image = Fantasy_Freaks.Properties.Resources.day1;
            }
            else if (FFeventDay == 2)
            {
                OPPDayimg.Image = Fantasy_Freaks.Properties.Resources.day2;

            }
            else if (FFeventDay == 3)
            {
                OPPDayimg.Image = Fantasy_Freaks.Properties.Resources.day3;
            }
            else
            {
                OPPDayimg.Image = Fantasy_Freaks.Properties.Resources.day4;
            }


            double defScore = WinStat.CalculateDefensiveScore(EnemyTeam);

            int offScore = 0;
            var players = await _teamService.GetActivePlayers();
            foreach (var player in players)
            {
                double currentPlayer = WinStat.CalculateOffensiveScore(player);
                currentPlayer += offScore;
            }

            var performance = _teamService.PlayerPerformance[_teamService.CurrentWeek];
            performance.OppScore = defScore;
            performance.UserScore = offScore;
            performance.UserWon = offScore >= defScore; 
            labelOPPscore.Text = defScore.ToString();
            labelFFscore.Text = offScore.ToString();


            if (offScore > _teamService.BestWeek)
                _teamService.BestWeek = offScore;
            if (offScore < _teamService.WorstWeek)
                _teamService.WorstWeek = offScore;

            _teamService.NextWeek();
        }
    }
}
