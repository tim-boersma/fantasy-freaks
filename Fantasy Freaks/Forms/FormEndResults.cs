using DataAccess;
using DataAccess.Interfaces;
using DataAccess.Services;
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
    

    public partial class FormEndResults : Form {
        private readonly ITeamService _teamService;

        public FormEndResults(ITeamService teamService) {
            InitializeComponent();
            _teamService = teamService;
        }

        //int pointsAllowed = WinStat.TYscore(/*ty value*/);
        //int yardsAllowed = WinStat.Tpscore(/*tp value*/);
        //int offScore = WinStat.offScoreCalc(/*from table for off*/);
        //double defScore = WinStat.defScoreCalc(/*from table for def, pointsAllowed, yardsAllowed*/);

        private void FormEndResults_Load(object sender, EventArgs e) {


            TransparentBackgroundLabel(labelInjury, pictureDayType);
            TransparentBackgroundLabel(labelBadDay, pictureDayType);
            TransparentBackgroundLabel(labelAverage, pictureDayType);
            TransparentBackgroundLabel(labelGoodDay, pictureDayType);
            TransparentBackgroundLabel(labelMiraclePlay, pictureDayType);

            FFWindow.instance.setFont(this);

            labelInjury.Text = _teamService.TotalInjuries.ToString();
            labelBadDay.Text = _teamService.TotalBadDays.ToString();
            labelAverage.Text = _teamService.TotalAveragePoints.ToString();
            labelGoodDay.Text = _teamService.TotalGoodDays.ToString();
            labelMiraclePlay.Text = _teamService.TotalMiraclePlays.ToString();

            var userTotalWins = _teamService.PlayerPerformance.Where(x => x.UserWon).Count();
            var userTotalLosses = _teamService.PlayerPerformance.Where(x => !x.UserWon).Count();

            labelFFTotalScore.Text = userTotalWins+ " - " + userTotalLosses;

            //Best Game
            var oppBannerImg = teamDictionary.bannerSeason[_teamService.BestWeek.OpposingTeam.TeamName];
            var weekNum = _teamService.EnemyTeams.IndexOf(_teamService.BestWeek.OpposingTeam) + 1;
            GenerateBanner(bestFFBanner, bestFFScore, bestButton, weekNum, _teamService.BestWeek.UserScore, Properties.Resources.FF);
            GenerateBanner(bestOppBanner, bestOppScore, worstButton, weekNum, _teamService.BestWeek.OppScore, oppBannerImg);// opponeent

            //Worst Game
            oppBannerImg = teamDictionary.bannerSeason[_teamService.WorstWeek.OpposingTeam.TeamName];
            weekNum = _teamService.EnemyTeams.IndexOf(_teamService.BestWeek.OpposingTeam) + 1;
            GenerateBanner(worstFFBanner, worstFFScore, bestButton, weekNum, _teamService.WorstWeek.UserScore, Properties.Resources.FF);
            GenerateBanner(worstOppBanner, worstOppScore, worstButton, weekNum, _teamService.WorstWeek.OppScore, oppBannerImg);// opponeent
        }

        private void GenerateBanner(PictureBox banner, Label scoreLabel, Button button, int weekNum, double score, Image bImg) {
            TransparentBackgroundLabel(scoreLabel, banner);
            banner.BackgroundImage = bImg;
            scoreLabel.Text = score.ToString();
            button.Text = "WEEK " + weekNum + "\nVS";
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
