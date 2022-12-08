﻿using Fantasy_Freaks.Models;
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
    struct Week {
        public PictureBox ffBanner;
        public Label ffScore;
        public PictureBox defBanner;
        public Label defScore;
        public Button weekInfo;
    }
    public partial class FormSeasonOpponents : Form {
        private List<Week> seasonWeek = new List<Week>();
        public FormSeasonOpponents() {
            InitializeComponent();
        }


        private void FormSeasonOpponents_Load(object sender, EventArgs e) {
            for (int i = 0; i < 17; i++) {
                WeekGenerator(i);
                this.Size = new Size(this.Size.Width, this.Size.Height + 100);
            }
            this.Size = new Size(this.Size.Width, this.Size.Height + 100);
        }
        private void WeekGenerator(int weekNum) {
            Week week = new Week();
            GenerateBanner(week.ffBanner, week.ffScore, weekNum, 999, 12, 269, Properties.Resources.FF); //999 is your score
            GenerateBanner(week.defBanner, week.defScore, weekNum, 999, 537, 547, Properties.Resources.Bears); //999 is defscore, last parameter is def banner

            week.weekInfo = new Button();
            week.weekInfo.Location = new Point(396, 12 + weekNum * 110);
            week.weekInfo.Size = new Size(135, 99);
            week.weekInfo.Font = new Font("Segoe UI Variable Text", 19, FontStyle.Bold);
            week.weekInfo.ForeColor = Color.White;
            week.weekInfo.FlatStyle = FlatStyle.Flat;
            week.weekInfo.FlatAppearance.BorderSize = 4;
            week.weekInfo.Text = "WEEK " + (weekNum + 1) + "\nVS";

            //change this
            if (true) {//week == current week
                week.weekInfo.BackColor = Color.Gold;
            } else if(true) {//loss, ffScore < defScore
                week.weekInfo.BackColor = Color.Firebrick;
            } else {//win
                week.weekInfo.BackColor = Color.ForestGreen;
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

        private void GenerateBanner(PictureBox banner, Label scoreLabel, int weekNum, int score, int xBanner, int xScore, Image bImg) {
            banner = new PictureBox();
            banner.Location = new Point(xBanner, 12 + weekNum * 110);
            banner.Size = new Size(378, 99);
            banner.BackgroundImageLayout = ImageLayout.Zoom;
            banner.BackgroundImage = bImg; //change image 

            scoreLabel = new Label();
            scoreLabel.Location = new Point(xScore, 30 + weekNum * 110);
            scoreLabel.Font = new Font("Segoe UI Variable Text", 36, FontStyle.Bold);
            scoreLabel.AutoSize = true;
            scoreLabel.ForeColor = Color.White;
            scoreLabel.BackColor = Color.FromArgb(0, 163, 255);
            scoreLabel.Parent = banner;

            scoreLabel.Text = score.ToString();

            Controls.Add(scoreLabel);
            Controls.Add(banner);
        }
    }

}
