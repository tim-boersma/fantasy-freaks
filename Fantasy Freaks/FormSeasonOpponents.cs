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
    struct WeekPanel {
        public PictureBox ffBanner;
        public Label ffScore;
        public PictureBox defBanner;
        public Label defScore;
        public Button weekInfo;
    }

    public partial class FormSeasonOpponents : Form {
        private List<WeekPanel> seasonWeek = new List<WeekPanel>();
        private readonly ITeamService _team;
        public FormSeasonOpponents(ITeamService teamService) {
            _team = teamService;
            InitializeComponent();
        }


        private void FormSeasonOpponents_Load(object sender, EventArgs e) {
            for (int i = 0; i < 17; i++) {
                WeekGenerator(i);
                this.Size = new Size(this.Size.Width, this.Size.Height + 100);
            }
            this.Size = new Size(this.Size.Width, this.Size.Height + 100);
        }
        private async void WeekGenerator(int weekNum) {
            var enemyTeam = _team.EnemyTeams[weekNum];

            var teamBanner = teamDictionary.bannerSeason[enemyTeam.TeamName];

            Color colorTeam = teamDictionary.labelSeason[enemyTeam.TeamName];

            WeekPanel week = new WeekPanel();
            GenerateBanner(week.ffBanner, week.ffScore, weekNum, 999, 12, 269, Properties.Resources.FF, Color.FromArgb(0, 163, 255)); //999 is your score
            GenerateBanner(week.defBanner, week.defScore, weekNum, 999, 537, 547, teamBanner, colorTeam); //999 is defscore, last parameter is def banner

            week.weekInfo = new Button();
            week.weekInfo.Location = new Point(396, 12 + weekNum * 110);
            week.weekInfo.Size = new Size(135, 99);
            week.weekInfo.Font = new Font("Segoe UI Variable Text", 19, FontStyle.Bold);
            week.weekInfo.ForeColor = Color.White;
            week.weekInfo.FlatStyle = FlatStyle.Flat;
            week.weekInfo.FlatAppearance.BorderSize = 4;
            week.weekInfo.Text = "WEEK " + (weekNum + 1) + "\nVS";

            if (weekNum == _team.CurrentWeek) {
                week.weekInfo.BackColor = Color.Gold;
            } else if(_team.PlayerPerformance.ElementAtOrDefault(weekNum) != null && !_team.PlayerPerformance[weekNum].UserWon) {//loss, ffScore < defScore
                week.weekInfo.BackColor = Color.Firebrick;
            } else if (_team.PlayerPerformance.ElementAtOrDefault(weekNum) != null && _team.PlayerPerformance[weekNum].UserWon) {
                week.weekInfo.BackColor = Color.ForestGreen;
            } else {
                week.weekInfo.BackColor = Color.Black;
            }

            week.weekInfo.FlatAppearance.MouseOverBackColor = week.weekInfo.BackColor;
            week.weekInfo.FlatAppearance.MouseDownBackColor = week.weekInfo.BackColor;

            Controls.Add(week.weekInfo);
            seasonWeek.Add(week);
        }
        //gap = 110
        //ffBanner x,y = 12, 12
        //ffScore x,y = 269, 30
        //defBanner x,y = 537,12
        //defScore x,y = 547, 30

        private void GenerateBanner(PictureBox banner, Label scoreLabel, int weekNum, int score, int xBanner, int xScore, Image bImg, Color colorTeam) {
            banner = new PictureBox();
            banner.Location = new Point(xBanner, 12 + weekNum * 110);
            banner.Size = new Size(378, 99);
            banner.BackgroundImageLayout = ImageLayout.Zoom;
            banner.BackgroundImage = bImg; //changes image 

            scoreLabel = new Label();
            scoreLabel.Location = new Point(xScore, 30 + weekNum * 110);
            scoreLabel.Font = new Font("Segoe UI Variable Text", 36, FontStyle.Bold);
            scoreLabel.AutoSize = true;
            scoreLabel.ForeColor = Color.White;
            scoreLabel.BackColor = colorTeam; //Color.FromArgb(0, 163, 255); //change the label color here
            scoreLabel.Parent = banner;

            scoreLabel.Text = score.ToString();

            Controls.Add(scoreLabel);
            Controls.Add(banner);
        }
    }

}
