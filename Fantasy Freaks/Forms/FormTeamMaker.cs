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
        private IEnumerable<CurrentPlayerModel> allPlayers;
        private bool selecting = false;
        private Dictionary<Button, Label> labelDict;
        public FormTeamMaker(ITeamService teamService, IDefenseService defenseService, ICurrentPlayerService currentPlayer) {
            InitializeComponent();
            _team = teamService;
            _defense = defenseService;
            _currentPlayer = currentPlayer;
            labelDict = new Dictionary<Button, Label>()
            {
                { btnQB, labelQB}, { btnRB1, labelRB1}, { btnRB2, labelRB2}, {btnWR1, labelWR1}, { btnWR2, labelWR2},
                { btnTE, labelTE}, { btnFL, labelFlex}, { btnBe1, labelBe1}, { btnBe2, labelBe2}, { btnBe3, labelBe3},
                { btnBe4, labelBe4}, { btnBe5, labelBe5}, { btnBe6, labelBe6}, { btnBe7, labelBe7}, { btnBe8, labelBe8},
            };

            foreach (var button in this.Controls.OfType<Button>())
            {
                _team.WaitSomeTime(button, 1500);
            }
         }

        private async void FormTeamMaker_Load(object sender, EventArgs e) {
            FFWindow.instance.setFont(this);

            foreach(var keyValuePair in labelDict)
            {
                TransparentLabelOnButton(keyValuePair.Value, keyValuePair.Key);
            }

            allPlayers = await _currentPlayer.GetAllPlayers();
        }

        private void Bench_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            ChoosingPlayer(btn, PlayerTypes.Bench);
        }

        private void ActiveRoster_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var position = btn.Name.Replace("btn", "");
            if (PlayerTypes.AllTypes.Contains(position))
            {
                ChoosingPlayer(btn, position);
            }
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
            if (selecting)
            {
                return;
            }
            selecting = true;
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
            selecting = false;
        }

        private void PlayerSelectionForm_Closed(object sender, FormClosedEventArgs e)
        {
            RefreshPlayerSelection();
            selecting = false;
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
                btnFL.Text = _team.Flex.PlayerName;
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.Enabled = false;
            }
            _team.Quarterback = GetRandomPlayer(allPlayers, PlayerTypes.Quarterback);
            _team.WideReceiverOne = GetRandomPlayer(allPlayers, PlayerTypes.WideReceiver);
            _team.WideReceiverTwo = GetRandomPlayer(allPlayers, PlayerTypes.WideReceiver);
            _team.RunningBackOne = GetRandomPlayer(allPlayers, PlayerTypes.RunningBack);
            _team.RunningBackTwo = GetRandomPlayer(allPlayers, PlayerTypes.RunningBack);
            _team.TightEnd = GetRandomPlayer(allPlayers, PlayerTypes.TightEnd);
            _team.Flex = GetRandomPlayer(allPlayers, PlayerTypes.Flex);
            var bench = GetRandomBench(allPlayers);
            _team.BenchedPlayers = bench.ToList();
            RefreshPlayerSelection();
            RefreshBenchSelection();
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.Enabled = true;
            }
        }

        private CurrentPlayerModel GetRandomPlayer(IEnumerable<CurrentPlayerModel> players, string playerType)
        {
            if (!PlayerTypes.AllTypes.Contains(playerType))
            {
                return null;
            }
            CurrentPlayerModel selectedPlayer;
            var allPlayers = _team.GetAllPlayerIDs();
            var playerPool = players.ToList();
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            do
            {
                var playerNum = rand.Next(0, playerPool.Count);
                selectedPlayer = playerPool[playerNum];
            } while ((selectedPlayer.PlayerPosition != playerType || allPlayers.Contains(selectedPlayer.PlayerID))
                   && playerType != PlayerTypes.Flex);

            return selectedPlayer;
        }

        private IEnumerable<CurrentPlayerModel> GetRandomBench(IEnumerable<CurrentPlayerModel> players)
        {
            List<CurrentPlayerModel> selectedPlayers = new List<CurrentPlayerModel>();
            var playerPool = players.ToList();
            var allPlayers = _team.GetAllPlayerIDs();
            CurrentPlayerModel selectedPlayer;
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            for(int i = 0; i < 8; i++)
            {
                do
                {
                    var playerNum = rand.Next(0, playerPool.Count);
                    selectedPlayer = playerPool[playerNum];
                } while (selectedPlayers.Contains(selectedPlayer) || allPlayers.Contains(selectedPlayer.PlayerID));
                selectedPlayers.Add(selectedPlayer);
            }
            return selectedPlayers;
        }
        private void TransparentLabelOnButton(Label l, Button b) {
            l.BackColor = Color.Transparent;
            l.Location = b.PointToClient(l.Parent.PointToScreen(l.Location));
            l.Parent = b;
        }
    }
}
