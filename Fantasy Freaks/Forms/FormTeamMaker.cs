using DataAccess.Interfaces;
using DataAccess.Models;
using DataAccess.Services;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DataAccess.GlobalConstants;

namespace Fantasy_Freaks {
    public partial class FormTeamMaker : Form {
        private readonly ITeamService _team;
        private readonly IDefenseService _defense;
        private readonly ICurrentPlayerService _currentPlayer;
        public FormTeamMaker(ITeamService teamService, IDefenseService defenseService, ICurrentPlayerService currentPlayer) {
            InitializeComponent();
            _team = teamService;
            _defense = defenseService;
            _currentPlayer = currentPlayer;
        }
        //int offScore = WinStat.instance.offScoreCalc(/*from table for off*/);

        private void FormTeamMaker_Load(object sender, EventArgs e) {
        
        }

        private void btnQB_Click(object sender, EventArgs e)
        {
            ChoosingPlayer(btnQB, PlayerTypes.Quarterback);
        }

        private void btnRB1_Click(object sender, EventArgs e)
        {
            ChoosingPlayer(btnRB1, PlayerTypes.RunningBack);
        }

        private void btnRB2_Click(object sender, EventArgs e)
        {
            ChoosingPlayer(btnRB2, PlayerTypes.RunningBackTwo);
        }

        private void btnWR1_Click(object sender, EventArgs e)
        {
            ChoosingPlayer(btnWR1, PlayerTypes.WideReceiver);
        }

        private void btnWR2_Click(object sender, EventArgs e)
        {
            ChoosingPlayer(btnWR2, PlayerTypes.WideReceiverTwo);
        }

        private void btnTE_Click(object sender, EventArgs e)
        {
            ChoosingPlayer(btnTE, PlayerTypes.TightEnd);
        }

        private void btnFlex_Click(object sender, EventArgs e)
        {
            ChoosingPlayer(btnFlex, PlayerTypes.Flex);
        }
        //---------------------------------Bench-------------------------------------------------
        private void btnBe1_Click(object sender, EventArgs e)
        {
            ChoosingPlayer(btnBe1, PlayerTypes.Bench);
        }

        private void btnBe2_Click(object sender, EventArgs e)
        {
            ChoosingPlayer(btnBe2, PlayerTypes.Bench);
        }

        private void btnBe3_Click(object sender, EventArgs e)
        {
            ChoosingPlayer(btnBe3, PlayerTypes.Bench);
        }

        private void btnBe4_Click(object sender, EventArgs e)
        {
            ChoosingPlayer(btnBe4, PlayerTypes.Bench);
        }

        private void btnBe5_Click(object sender, EventArgs e)
        {
            ChoosingPlayer(btnBe5, PlayerTypes.Bench);
        }

        private void btnBe6_Click(object sender, EventArgs e)
        {
            ChoosingPlayer(btnBe6, PlayerTypes.Bench);
        }

        private void btnBe7_Click(object sender, EventArgs e)
        {
            ChoosingPlayer(btnBe7, PlayerTypes.Bench);
        }

        private void btnBe8_Click(object sender, EventArgs e)
        {
            ChoosingPlayer(btnBe8, PlayerTypes.Bench);
        }

        private void btnSeason_Click(object sender, EventArgs e)
        {
            if (_team.AllPlayersInitialized())
            {
                FFWindow.instance.changePanel(new FormSeason(_team, _defense));
            }
            else
            {
                // TODO: Warn user they have players they still need to add
            }
        }
        private void ChoosingPlayer(Button button, string position) {
            if(position == PlayerTypes.Bench)
            {
                Form frmBS = new FormBenchSelection(_currentPlayer, _team, position);
                frmBS.Show();
                frmBS.FormClosed += new FormClosedEventHandler(BenchSelectionForm_Closed);
            } 
            else
            {
                Form frmPS = new FormPlayerSelection(_currentPlayer, _team, position);
                frmPS.Show();
                frmPS.FormClosed += new FormClosedEventHandler(PlayerSelectionForm_Closed);
            }
        }

        private void BenchSelectionForm_Closed(object sender, FormClosedEventArgs e)
        {
            if (_team.BenchedPlayers.Any())
            {
                List<Button> buttons = new List<Button>();
                foreach (var button in this.Controls.OfType<Button>())
                {
                    if (button.Name.StartsWith("btnBe"))
                    {
                        buttons.Add(button);
                    }
                }

                int index = 0;
                foreach (var player in _team.BenchedPlayers)
                {
                    buttons[index].Text = player.PlayerName;
                    index++;
                }
            }
        }

        private void PlayerSelectionForm_Closed(object sender, FormClosedEventArgs e)
        {
            if (_team.Quarterback != null)
                btnQB.Text = _team.Quarterback.PlayerName;
            if (_team.RunningBackOne != null)
                btnRB1.Text = _team.RunningBackOne.PlayerName;
            if (_team.RunningBackTwo != null)
                btnRB2.Text = _team.RunningBackTwo.PlayerName;
            if (_team.WideReceiverOne != null)
                btnWR1.Text = _team.WideReceiverOne.PlayerName;
            if (_team.WideReceiverTwo != null)
                btnWR2.Text = _team.WideReceiverTwo.PlayerName;
            if (_team.TightEnd != null)
                btnTE.Text = _team.TightEnd.PlayerName;
            if (_team.Flex != null)
                btnFlex.Text = _team.Flex.PlayerName;
        }
    }
}
