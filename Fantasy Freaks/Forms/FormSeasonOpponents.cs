using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
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
            FFWindow.instance.setFont(this);
            if(_team.CurrentWeek <= 17)
                VerticalScroll.Value = scroll(_team.CurrentWeek);
        }

        private int scroll(int week)
        {
            int num = 9;
            num = num + ((week - 1) * 110);
            return num;
        }

        private void WeekGenerator(int weekNum) {
            var enemyTeam = _team.EnemyTeams[weekNum];
            var teamBanner = ResourceDictionaries.bannerSeason[enemyTeam.TeamName];
            Color colorTeam = ResourceDictionaries.labelSeason[enemyTeam.TeamName];
            double offScore = _team.UserPerformance.ElementAtOrDefault(weekNum) != null ? _team.UserPerformance[weekNum].UserScore : 0;
            double defScore = _team.UserPerformance.ElementAtOrDefault(weekNum) != null ? _team.UserPerformance[weekNum].OppScore : 0;

            WeekPanel week = new WeekPanel();
            GenerateBanner(weekNum, offScore, 12, 280, Properties.Resources.FF, Color.FromArgb(0, 163, 255), true);
            GenerateBanner(weekNum, defScore, 537, 547, teamBanner, colorTeam,false);

            CreateVersusBox(week, weekNum);
        }

        private void CreateVersusBox(WeekPanel week, int weekNum)
        {
            week.weekInfo = new Button();
            week.weekInfo.Location = new Point(396, 12 + weekNum * 110);
            week.weekInfo.Size = new Size(135, 99);
            week.weekInfo.Font = new Font("Segoe UI Variable Text", 19, FontStyle.Bold);
            week.weekInfo.ForeColor = Color.White;
            week.weekInfo.FlatStyle = FlatStyle.Flat;
            week.weekInfo.FlatAppearance.BorderSize = 4;
            week.weekInfo.Text = "WEEK " + (weekNum + 1) + "\nVS";

            if (weekNum + 1 == _team.CurrentWeek)
            {
                week.weekInfo.BackColor = Color.Gold;
            }
            else if (_team.UserPerformance.ElementAtOrDefault(weekNum) != null && !_team.UserPerformance[weekNum].UserWon)
            {//loss, ffScore < defScore
                week.weekInfo.BackColor = Color.Firebrick;
            }
            else if (_team.UserPerformance.ElementAtOrDefault(weekNum) != null && _team.UserPerformance[weekNum].UserWon)
            {
                week.weekInfo.BackColor = Color.ForestGreen;
            }
            else
            {
                week.weekInfo.BackColor = Color.DimGray;
            }

            week.weekInfo.FlatAppearance.MouseOverBackColor = week.weekInfo.BackColor;
            week.weekInfo.FlatAppearance.MouseDownBackColor = week.weekInfo.BackColor;

            Controls.Add(week.weekInfo);
            seasonWeek.Add(week);
        }

        private void GenerateBanner(int weekNum, double score, int xBanner, int xScore, Image bImg, Color colorTeam, bool ffteam) {
            var banner = new PictureBox();
            banner.Location = new Point(xBanner, 12 + weekNum * 110);
            banner.Size = new Size(378, 99);
            banner.BackgroundImageLayout = ImageLayout.Zoom;
            banner.BackgroundImage = bImg; //changes image 

            var scoreLabel = new Label();
            scoreLabel.Location = new Point(xScore, 30 + weekNum * 110);
            scoreLabel.Font = new Font("Segoe UI Variable Text", 36, FontStyle.Bold);
            scoreLabel.AutoSize = true;
            scoreLabel.ForeColor = Color.White;
            scoreLabel.BackColor = colorTeam;
            scoreLabel.Parent = banner;

            if (ffteam) {
                scoreLabel.AutoSize = false;
                scoreLabel.Size = new Size(100, 70);
                scoreLabel.TextAlign = ContentAlignment.MiddleRight;
            }

            scoreLabel.Text = score.ToString();

            Controls.Add(scoreLabel);
            Controls.Add(banner);
        }
    }
}
