using DataAccess.Interfaces;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fantasy_Freaks {
    public partial class FormTeamMaker : Form {
        private readonly ITeamService _teamService;
        private readonly IDefenseService _defenseService;
        public FormTeamMaker(ITeamService teamService, IDefenseService defenseService) {
            InitializeComponent();
            _teamService = teamService;
            _defenseService = defenseService;
        }
        //int offScore = WinStat.instance.offScoreCalc(/*from table for off*/);

        private void FormTeamMaker_Load(object sender, EventArgs e) {
            FFWindow.instance.setFont(this);
            new WinStat();
        }

        private void btnQB_Click(object sender, EventArgs e)
        {
            choosingPlayer(btnQB);
        }

        private void btnRB1_Click(object sender, EventArgs e)
        {

        }

        private void btnRB2_Click(object sender, EventArgs e)
        {

        }

        private void btnWR1_Click(object sender, EventArgs e)
        {

        }

        private void btnWR2_Click(object sender, EventArgs e)
        {

        }

        private void btnTE_Click(object sender, EventArgs e)
        {

        }

        private void btnFlex_Click(object sender, EventArgs e)
        {

        }
        //---------------------------------Bench-------------------------------------------------
        private void btnBe1_Click(object sender, EventArgs e)
        {

        }

        private void btnBe2_Click(object sender, EventArgs e)
        {

        }

        private void btnBe3_Click(object sender, EventArgs e)
        {

        }

        private void btnBe4_Click(object sender, EventArgs e)
        {

        }

        private void btnBe5_Click(object sender, EventArgs e)
        {

        }

        private void btnBe6_Click(object sender, EventArgs e)
        {

        }

        private void btnBe7_Click(object sender, EventArgs e)
        {

        }

        private void btnBe8_Click(object sender, EventArgs e)
        {

        }

        private void btnSeason_Click(object sender, EventArgs e)
        {
            FFWindow.instance.changePanel(new FormSeason(_teamService, _defenseService));
        }
        private void choosingPlayer(Button button) {//position parameter too Ex: Postion pos
            button.Enabled = false;
            Form fPS = new FormPlayerSelection(button);
            fPS.Show();
        }
    }
}
