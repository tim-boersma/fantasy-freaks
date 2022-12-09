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

            labelInjury.Text = _teamService.TotalInjuries.ToString();
            labelBadDay.Text = _teamService.TotalBadDays.ToString();
            labelAverage.Text = _teamService.TotalAveragePoints.ToString();
            labelGoodDay.Text = _teamService.TotalGoodDays.ToString();
            labelMiraclePlay.Text = _teamService.TotalMiraclePlays.ToString();


            //FF Total Score
            labelFFTotalScore.Text = 0/*wins*/ + " - " + 12/*loses*/;
            //Best Game
            GenerateBanner(bestFFBanner, bestFFScore, bestButton, 1/*FFBest Week*/, 999/*FFBest Score*/, Properties.Resources.FF);
            GenerateBanner(bestOppBanner, bestOppScore, worstButton, 1/*OppBest Week*/, 999/*OppBest Score*/, Properties.Resources.Bears/*Opp banner*/);// opponeent
            
            //Worst Game
            GenerateBanner(worstFFBanner, worstFFScore, bestButton, 1/*FFBest Week*/, 999/*FFBest Score*/, Properties.Resources.FF);
            GenerateBanner(worstOppBanner, worstOppScore, worstButton, 1/*OppBest Week*/, 999/*OppBest Score*/, Properties.Resources.Bears/*Opp banner*/);// opponeent

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
