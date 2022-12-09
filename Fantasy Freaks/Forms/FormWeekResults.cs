using DataAccess;
using DataAccess.Interfaces;
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
    public partial class FormWeekResults : Form {

        private ITeamService _teamService;
        private IDefenseService _defenseService;
        public FormWeekResults(ITeamService teamService, IDefenseService defenseService) {
            InitializeComponent();
            _teamService = teamService;
            _defenseService = defenseService;
            _teamService.WaitSomeTime(buttonChangeRoster);
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
            title.Text = "WEEK " + _teamService.CurrentWeek + " RESULT";

            var EnemyTeam = _teamService.GetCurrentOpponent();

            OPPlabel.Text = EnemyTeam.TeamName;

            int FFeventDay = WinStat.EventForDay();
            int OPPeventDay = WinStat.EventForDay();

            double defScore = WinStat.CalculateDefensiveScore(EnemyTeam);

            double offScore = 0;
            var players = await _teamService.GetActivePlayers();
            foreach (var player in players)
            {
                double currentPlayer = WinStat.CalculateOffensiveScore(player);
                offScore += currentPlayer;
            }

            if (FFeventDay == 0)
            {
                FFDayimg.Image = Fantasy_Freaks.Properties.Resources.day0;
                _teamService.TotalInjuries++;
                offScore = offScore * .5;
            }
            else if (FFeventDay == 1)
            {
                FFDayimg.BackgroundImage = Fantasy_Freaks.Properties.Resources.day1;
                _teamService.TotalBadDays++;
                offScore = offScore * .75;
            }
            else if (FFeventDay == 2)
            {
                FFDayimg.BackgroundImage = Fantasy_Freaks.Properties.Resources.day2;
                _teamService.TotalAveragePoints++;
            }
            else if (FFeventDay == 3)
            {
                FFDayimg.BackgroundImage = Fantasy_Freaks.Properties.Resources.day3;
                _teamService.TotalGoodDays++;
                offScore = offScore * 1.25;
            }
            else
            {
                FFDayimg.BackgroundImage = Fantasy_Freaks.Properties.Resources.day4;
                _teamService.TotalMiraclePlays++;
                offScore = offScore * 1.5;
            }

            if (OPPeventDay == 0)
            {
                OPPDayimg.Image = Fantasy_Freaks.Properties.Resources.day0;
                defScore = defScore * .5;
            }
            else if (OPPeventDay == 1)
            {
                OPPDayimg.Image = Fantasy_Freaks.Properties.Resources.day1;
                defScore = defScore * .75;

            }
            else if (OPPeventDay == 2)
            {
                OPPDayimg.BackgroundImage = Fantasy_Freaks.Properties.Resources.day2;

            }
            else if (OPPeventDay == 3)
            {
                OPPDayimg.Image = Fantasy_Freaks.Properties.Resources.day3;
                defScore = defScore * 1.25;

            }
            else
            {
                OPPDayimg.Image = Fantasy_Freaks.Properties.Resources.day4;
                defScore = defScore * 1.5;

            }

            int offFinalScore = (int)offScore;
            int defFinalScore = (int)defScore;

            var performance = new WeekPerformance(offFinalScore, defFinalScore);
            _teamService.PlayerPerformance.Insert(_teamService.CurrentWeek - 1, performance);
            labelOPPscore.Text = defFinalScore.ToString();
            labelFFscore.Text = offFinalScore.ToString();


            if (offScore > _teamService.BestWeek)
                _teamService.BestWeek = offFinalScore;
            if (offScore < _teamService.WorstWeek)
                _teamService.WorstWeek = offFinalScore;

        }


    }
}
