using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Fantasy_Freaks {
    

    public partial class FormEndResults : Form {
        private readonly ITeamService _teamService;
        private Dictionary<Label, string> labelTextPairs;

        public FormEndResults(ITeamService teamService) {
            InitializeComponent();
            _teamService = teamService;

            labelTextPairs = new Dictionary<Label, string>()
            {
                { labelDayInjury, _teamService.TotalInjuries.ToString() },
                { labelDayBad, _teamService.TotalBadDays.ToString() },
                { labelDayAverage, _teamService.TotalAveragePoints.ToString() },
                { labelDayGood, _teamService.TotalGoodDays.ToString() },
                { labelDayMiracle, _teamService.TotalMiraclePlays.ToString() },
            };
        }

        private void FormEndResults_Load(object sender, EventArgs e) {
            FFWindow.instance.setFont(this);

            foreach (var keyValuePair in labelTextPairs)
            {
                TransparentBackgroundLabel(keyValuePair.Key, pictureDayType);
                keyValuePair.Key.Text = keyValuePair.Value;
            }        

            var userTotalWins = _teamService.UserPerformance.Where(x => x.UserWon).Count();
            var userTotalLosses = _teamService.UserPerformance.Where(x => !x.UserWon).Count();

            labelFFTotalScore.Text = userTotalWins+ " - " + userTotalLosses;

            //Best Game
            var oppBannerImg = ResourceDictionaries.bannerSeason[_teamService.BestWeek.OpposingTeam.TeamName];
            var bestWeekNum = _teamService.EnemyTeams.IndexOf(_teamService.BestWeek.OpposingTeam) + 1;
            GenerateBanner(bestFFBanner, bestFFScore, bestButton, bestWeekNum, _teamService.BestWeek.UserScore, Properties.Resources.FF);
            GenerateBanner(bestOppBanner, bestOppScore, bestButton, bestWeekNum, _teamService.BestWeek.OppScore, oppBannerImg);// opponeent

            //Worst Game
            oppBannerImg = ResourceDictionaries.bannerSeason[_teamService.WorstWeek.OpposingTeam.TeamName];
            var worstWeekNum = _teamService.EnemyTeams.IndexOf(_teamService.WorstWeek.OpposingTeam) + 1;
            GenerateBanner(worstFFBanner, worstFFScore, worstButton, worstWeekNum, _teamService.WorstWeek.UserScore, Properties.Resources.FF);
            GenerateBanner(worstOppBanner, worstOppScore, worstButton, worstWeekNum, _teamService.WorstWeek.OppScore, oppBannerImg);// opponeent
        }

        private void GenerateBanner(PictureBox banner, Label scoreLabel, Button button, int weekNum, double score, Image bImg) {
            TransparentBackgroundLabel(scoreLabel, banner);
            banner.BackgroundImage = bImg;
            scoreLabel.Text = score.ToString();
            button.Text = "WEEK " + weekNum + "\nVS";
            if (_teamService.BestWeek.UserWon)
            {
                bestButton.BackColor = Color.ForestGreen;
                bestButton.FlatAppearance.MouseDownBackColor = Color.ForestGreen;
                bestButton.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            }
            else
            {
                bestButton.BackColor = Color.Firebrick;
                bestButton.FlatAppearance.MouseDownBackColor = Color.Firebrick;
                bestButton.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            }
            if (_teamService.WorstWeek.UserWon)
            {
                worstButton.BackColor = Color.ForestGreen;
                worstButton.FlatAppearance.MouseDownBackColor = Color.ForestGreen;
                worstButton.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            }
            else
            {
                worstButton.BackColor = Color.Firebrick;
                worstButton.FlatAppearance.MouseDownBackColor = Color.Firebrick;
                worstButton.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            }
        }

        private void TransparentBackgroundLabel (Label l , PictureBox p) {
            l.BackColor = Color.Transparent;
            l.Location = p.PointToClient(l.Parent.PointToScreen(l.Location));
            l.Parent = p;
        }

        private void buttonExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void buttonRestart_Click(object sender, EventArgs e) {
            Application.Restart();
        }
    }
}
