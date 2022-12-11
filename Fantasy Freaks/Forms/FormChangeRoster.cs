using DataAccess.Interfaces;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Fantasy_Freaks {
    public partial class FormChangeRoster : Form
    {
        private readonly ITeamService _teamService;
        private readonly IDefenseService _defenseService;
        private bool swapActive = false;
        private CurrentPlayerModel initialPlayer;
        private List<int> activePlayers;
        private Dictionary<Button, Label> buttonLabelPairs;
        private Dictionary<string, CurrentPlayerModel> positionPlayerPairs;

        public FormChangeRoster(ITeamService teamService, IDefenseService defenseService)
        {
            InitializeComponent();
            _teamService = teamService;
            _defenseService = defenseService;

            foreach (var button in this.Controls.OfType<Button>())
            {
                _teamService.WaitSomeTime(button, 300);
            }

            buttonLabelPairs = new Dictionary<Button, Label>()
            {
                { btnQB, labelBtnQB}, { btnRB1, labelBtnRB1}, { btnRB2, labelBtnRB2}, {btnWR1, labelBtnWR1}, { btnWR2, labelBtnWR2},
                { btnTE, labelBtnTE}, { btnFL, labelBtnFlex}, { btnBe1, labelBtnBe1}, { btnBe2, labelBtnBe2}, { btnBe3, labelBtnBe3},
                { btnBe4, labelBtnBe4}, { btnBe5, labelBtnBe5}, { btnBe6, labelBtnBe6}, { btnBe7, labelBtnBe7}, { btnBe8, labelBtnBe8},
            };

            SetPlayerPositionDictionary();
        }

        private void SetPlayerPositionDictionary()
        {
            positionPlayerPairs = new Dictionary<string, CurrentPlayerModel>()
            {
                { "QB", _teamService.Quarterback},
                { "WR1", _teamService.WideReceiverOne},
                { "WR2", _teamService.WideReceiverTwo},
                { "RB1", _teamService.RunningBackOne},
                { "RB2", _teamService.RunningBackTwo},
                { "TE", _teamService.TightEnd},
                { "FL", _teamService.Flex},
            };
        }

        private void btnSeason_Click(object sender, EventArgs e)
        {
            FFWindow.instance.changePanel(new FormSeason(_teamService, _defenseService));
        }

        private void Bench_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            btn.BackColor = Color.FromArgb(200, 200, 200);
            PlayerSelected(_teamService.BenchedPlayers.Where(x => x.PlayerName == btn.Text).First());
        }

        private void ActiveRoster_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var position = btn.Name.Replace("btn", "");
            if (positionPlayerPairs.ContainsKey(position))
            {
                btn.BackColor = Color.FromArgb(200, 200, 200);
                var selectedPlayer = positionPlayerPairs[position];
                PlayerSelected(selectedPlayer);
            }
        }

        private void colorReset()
        {
            foreach (var button in this.Controls.OfType<Button>())
            {
                if (button.Name != "btnSeason")
                    button.BackColor = Color.FromArgb(204, 239, 254);
            }
        }

        private void PlayerSelected(CurrentPlayerModel player)
        {
            if (!swapActive)
            {
                initialPlayer = player;
                swapActive = true;
            }
            else
            {
                bool validSelection = ValidatePlayerSwap(player);

                if (validSelection)
                {
                    if (_teamService.BenchedPlayers.Contains(initialPlayer) && !_teamService.BenchedPlayers.Contains(player))
                        _teamService.SwapPlayers(player, initialPlayer);
                    else
                        _teamService.SwapPlayers(initialPlayer, player);

                    RenderPlayerNames();
                    SetPlayerPositionDictionary();
                }
                colorReset();
                swapActive = false;
            }
        }

        private bool ValidatePlayerSwap(CurrentPlayerModel player)
        {
            if (player.PlayerID == initialPlayer.PlayerID)
            {
                initialPlayer = null;
                return false;
            }
            else if (_teamService.BenchedPlayers.Contains(initialPlayer) && _teamService.BenchedPlayers.Contains(player))
            {
                MessageBox.Show("You can't select two benched players");
                return false;
            }
            else if (activePlayers.Contains(initialPlayer.PlayerID) && activePlayers.Contains(player.PlayerID))
            {
                MessageBox.Show("You can't select two active players");
                return false;
            }
            else if (initialPlayer.PlayerPosition != player.PlayerPosition 
                 && initialPlayer.PlayerID != _teamService.Flex.PlayerID && player.PlayerID != _teamService.Flex.PlayerID)
            {
                MessageBox.Show("Players must share same position");
                return false;
            }
            return true;
        }

        private void FormChangeRoster_Load(object sender, EventArgs e)
        {
            FFWindow.instance.setFont(this);
            RenderPlayerNames();
            foreach (var keyValuePair in buttonLabelPairs)
            {
                TransparentLabelOnButton(keyValuePair.Value, keyValuePair.Key);
            }
        }

        private void RenderPlayerNames()
        {
            activePlayers = _teamService.GetActivePlayerIDs().ToList();
            btnQB.Text = _teamService.Quarterback.PlayerName;
            btnRB1.Text = _teamService.RunningBackOne.PlayerName;
            btnRB2.Text = _teamService.RunningBackTwo.PlayerName;
            btnWR1.Text = _teamService.WideReceiverOne.PlayerName;
            btnWR2.Text = _teamService.WideReceiverTwo.PlayerName;
            btnTE.Text = _teamService.TightEnd.PlayerName;
            btnFL.Text = _teamService.Flex.PlayerName;

            int index = 0;
            foreach (var button in this.Controls.OfType<Button>())
            {
                if (button.Name.StartsWith("btnBe"))
                {
                    button.Text = _teamService.BenchedPlayers[index].PlayerName;
                    var label = buttonLabelPairs[button];
                    label.Text = _teamService.BenchedPlayers[index].PlayerPosition;
                    index++;
                }
            }
        }

        private void TransparentLabelOnButton(Label l, Button b)
        {
            l.BackColor = Color.Transparent;
            l.Location = b.PointToClient(l.Parent.PointToScreen(l.Location));
            l.Parent = b;
        }
    }
}
