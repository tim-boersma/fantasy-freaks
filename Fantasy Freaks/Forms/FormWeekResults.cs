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
            _teamService.WaitSomeTime(buttonChangeRoster, 1000);
            _teamService.WaitSomeTime(btnNext, 1000);
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
            TransparentLabelonBanner(labelFFscore, FFbanner);
            TransparentLabelonBanner(labelOPPscore, OPPbanner);
            var enemyTeam = _teamService.GetCurrentOpponent();
            var teamBanner = ResourceDictionaries.bannerSeason[enemyTeam.TeamName];
            OPPbanner.BackgroundImage = teamBanner;

            FFWindow.instance.setFont(this);
            title.Text = "WEEK " + _teamService.CurrentWeek + " RESULT";
            OPPlabel.Text = enemyTeam.TeamName;

            double defScore = WinStat.CalculateDefensiveScore(enemyTeam);

            var players = await _teamService.GetActivePlayerPerformances();
            double offScore = WinStat.CalculateOffensiveScore(players);

            var userModifier = CalucateTeamPerformance(WinStat.EventForDay(), FFDayimg, true);
            var oppModifier = CalucateTeamPerformance(WinStat.EventForDay(), OPPDayimg, false);

            int offFinalScore = (int)(offScore * userModifier);
            int defFinalScore = (int)(defScore * oppModifier);

            var performance = new WeekPerformance(offFinalScore, defFinalScore, enemyTeam);
            _teamService.PlayerPerformance.Insert(_teamService.CurrentWeek - 1, performance);
            labelOPPscore.Text = defFinalScore.ToString();
            labelFFscore.Text = offFinalScore.ToString();


            if (_teamService.BestWeek == null || offFinalScore > _teamService.BestWeek.UserScore)
                _teamService.BestWeek = performance;
            if (_teamService.WorstWeek == null || offFinalScore < _teamService.WorstWeek.UserScore)
                _teamService.WorstWeek = performance;

            _teamService.NextWeek();
        }

        private double CalucateTeamPerformance(int FFeventDay, PictureBox teamImg, bool teamIsPlayer)
        {
            double modifier;
            if (FFeventDay == 0)
            {
                teamImg.BackgroundImage = Fantasy_Freaks.Properties.Resources.day0;
                if(teamIsPlayer)
                    _teamService.TotalInjuries++;
                modifier = 0.5;
            }
            else if (FFeventDay == 1)
            {
                teamImg.BackgroundImage = Fantasy_Freaks.Properties.Resources.day1;
                if(teamIsPlayer)
                    _teamService.TotalBadDays++;
                modifier =  .75;
            }
            else if (FFeventDay == 3)
            {
                teamImg.BackgroundImage = Fantasy_Freaks.Properties.Resources.day3;
                if(teamIsPlayer)
                    _teamService.TotalGoodDays++;
                modifier = 1.25;
            }
            else if (FFeventDay == 4)
            {
                teamImg.BackgroundImage = Fantasy_Freaks.Properties.Resources.day4;
                if (teamIsPlayer)
                    _teamService.TotalMiraclePlays++;
                modifier = 1.5;
            }
            else
            {
                teamImg.BackgroundImage = Fantasy_Freaks.Properties.Resources.day2;
                if (teamIsPlayer)
                    _teamService.TotalAveragePoints++;
                modifier = 1;
            }
            return modifier;
        }

        private void TransparentLabelonBanner(Label l, PictureBox b) {
            l.BackColor = Color.Transparent;
            l.Location = b.PointToClient(l.Parent.PointToScreen(l.Location));
            l.Parent = b;
        }
    }
}
