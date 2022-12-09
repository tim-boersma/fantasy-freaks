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
            _team.WaitSomeTime(btnQB);
            _team.WaitSomeTime(btnRB1);
            _team.WaitSomeTime(btnRB2);
            _team.WaitSomeTime(btnWR1);
            _team.WaitSomeTime(btnWR2);
            _team.WaitSomeTime(btnTE);
            _team.WaitSomeTime(btnFlex);
            _team.WaitSomeTime(btnBe1);
            _team.WaitSomeTime(btnBe2);
            _team.WaitSomeTime(btnBe3);
            _team.WaitSomeTime(btnBe4);
            _team.WaitSomeTime(btnBe5);
            _team.WaitSomeTime(btnBe6);
            _team.WaitSomeTime(btnBe7);
            _team.WaitSomeTime(btnBe8);
            _team.WaitSomeTime(btnSeason);
            _team.WaitSomeTime(btnRandom);
        }
        //int offScore = WinStat.instance.offScoreCalc(/*from table for off*/);

        private void FormTeamMaker_Load(object sender, EventArgs e) {
            FFWindow.instance.setFont(this);

            TransparentLabelonButton(labelQB, btnQB);
            TransparentLabelonButton(labelRB1, btnRB1);
            TransparentLabelonButton(labelRB2, btnRB2);
            TransparentLabelonButton(labelWR1, btnWR1);
            TransparentLabelonButton(labelWR2, btnWR2);
            TransparentLabelonButton(labelTE, btnTE);
            TransparentLabelonButton(labelFlex, btnFlex);
            TransparentLabelonButton(labelBe1, btnBe1);
            TransparentLabelonButton(labelBe2, btnBe2);
            TransparentLabelonButton(labelBe3, btnBe3);
            TransparentLabelonButton(labelBe4, btnBe4);
            TransparentLabelonButton(labelBe5, btnBe5);
            TransparentLabelonButton(labelBe6, btnBe6);
            TransparentLabelonButton(labelBe7, btnBe7);
            TransparentLabelonButton(labelBe8, btnBe8);
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
                MessageBox.Show("You must have a full rooster before continuing");
            }
        }
        private void ChoosingPlayer(Button button, string position) {
            if (position == PlayerTypes.Bench)
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
            RefreshBenchSelection();
        }

        private void RefreshBenchSelection()
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
            RefreshPlayerSelection();
        }

        private void RefreshPlayerSelection()
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


        private async void btnRandom_Click(object sender, EventArgs e)
        {
            _team.Quarterback = await GetRandomPlayer(PlayerTypes.Quarterback);
            _team.WideReceiverOne = await GetRandomPlayer(PlayerTypes.WideReceiver);
            _team.WideReceiverTwo = await GetRandomPlayer(PlayerTypes.WideReceiver);
            _team.RunningBackOne = await GetRandomPlayer(PlayerTypes.RunningBack);
            _team.RunningBackTwo = await GetRandomPlayer(PlayerTypes.RunningBack);
            _team.TightEnd = await GetRandomPlayer(PlayerTypes.TightEnd);
            _team.Flex = await GetRandomPlayer(PlayerTypes.Flex);
            var bench = await GetRandomBench();
            _team.BenchedPlayers = bench.ToList();
            RefreshPlayerSelection();
            RefreshBenchSelection();
        }

        private async Task<CurrentPlayerModel> GetRandomPlayer(string playerType)
        {
            var result = await _currentPlayer.GetSelectedPlayers(playerType);
            var players = result.ToList();
            CurrentPlayerModel selectedPlayer;
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            do
            {
                var playerNum = rand.Next(0, players.Count);
                selectedPlayer = players[playerNum];
            //TODO: break loop if position isn't valid
            
            } while (selectedPlayer.PlayerPosition != playerType && playerType != PlayerTypes.Flex);

            return selectedPlayer;
        }

        private async Task<IEnumerable<CurrentPlayerModel>> GetRandomBench()
        {
            List<CurrentPlayerModel> selectedPlayers = new List<CurrentPlayerModel>();

            var result = await _currentPlayer.GetSelectedPlayers(PlayerTypes.Bench);
            var players = result.ToList();
            CurrentPlayerModel selectedPlayer;
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            for(int i = 0; i < 8; i++)
            {
                do
                {
                    var playerNum = rand.Next(0, players.Count);
                    selectedPlayer = players[playerNum];
                } while (selectedPlayers.Contains(selectedPlayer));
                selectedPlayers.Add(selectedPlayer);
            }
            return selectedPlayers;
        }
        private void TransparentLabelonButton(Label l, Button b) {
            l.BackColor = Color.Transparent;
            l.Location = b.PointToClient(l.Parent.PointToScreen(l.Location));
            l.Parent = b;
        }
    }
}
