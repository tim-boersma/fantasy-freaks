using DataAccess.Interfaces;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DataAccess.GlobalConstants;

namespace Fantasy_Freaks {
    public partial class FormChangeRoster : Form
    {
        private readonly ITeamService _teamService;
        private readonly IDefenseService _defenseService;
        private bool swapActive = false;
        private CurrentPlayerModel initialPlayer;
        private Dictionary<string, Label> benchLabel;
        private List<int> activePlayers;
        public FormChangeRoster(ITeamService teamService, IDefenseService defenseService)
        {
            InitializeComponent();
            _teamService = teamService;
            _defenseService = defenseService;
            foreach (var button in this.Controls.OfType<Button>())
            {
                _teamService.WaitSomeTime(button, 1500);
            }

            benchLabel = new Dictionary<string, Label>
            {
                { "btnBe1", labelBtnBe1},
                { "btnBe2", labelBtnBe2},
                { "btnBe3", labelBtnBe3},
                { "btnBe4", labelBtnBe4},
                { "btnBe5", labelBtnBe5},
                { "btnBe6", labelBtnBe6},
                { "btnBe7", labelBtnBe7},
                { "btnBe8", labelBtnBe8}
            };
        }

        private void btnSeason_Click(object sender, EventArgs e)
        {
            FFWindow.instance.changePanel(new FormSeason(_teamService, _defenseService));
        }

        private void btnQB_Click(object sender, EventArgs e)
        {
            btnQB.BackColor = Color.FromArgb(200, 200, 200);
            PlayerSelected(_teamService.Quarterback);
        }

        private void btnRB1_Click(object sender, EventArgs e)
        {
            btnRB1.BackColor = Color.FromArgb(200, 200, 200);
            PlayerSelected(_teamService.RunningBackOne);
        }

        private void btnRB2_Click(object sender, EventArgs e)
        {
            btnRB2.BackColor = Color.FromArgb(200, 200, 200);
            PlayerSelected(_teamService.RunningBackTwo);
        }

        private void btnWR1_Click(object sender, EventArgs e)
        {
            btnWR1.BackColor = Color.FromArgb(200, 200, 200);
            btnWR1.Update();
            PlayerSelected(_teamService.WideReceiverOne);

        }

        private void btnWR2_Click(object sender, EventArgs e)
        {
            btnWR2.BackColor = Color.FromArgb(200, 200, 200);
            PlayerSelected(_teamService.WideReceiverTwo);
        }

        private void btnTE_Click(object sender, EventArgs e)
        {
            btnTE.BackColor = Color.FromArgb(200, 200, 200);
            PlayerSelected(_teamService.TightEnd);
        }

        private void btnFlex_Click(object sender, EventArgs e)
        {
            btnFlex.BackColor = Color.FromArgb(200, 200, 200);
            PlayerSelected(_teamService.Flex);
        }

        private void btnBe1_Click(object sender, EventArgs e)
        {
            btnBe1.BackColor = Color.FromArgb(200, 200, 200);
            PlayerSelected(_teamService.BenchedPlayers.Where(x => x.PlayerName == btnBe1.Text).First());
        }

        private void btnBe2_Click(object sender, EventArgs e)
        {
            btnBe2.BackColor = Color.FromArgb(200, 200, 200);
            PlayerSelected(_teamService.BenchedPlayers.Where(x => x.PlayerName == btnBe2.Text).First());
        }

        private void btnBe3_Click(object sender, EventArgs e)
        {
            btnBe3.BackColor = Color.FromArgb(200, 200, 200);
            PlayerSelected(_teamService.BenchedPlayers.Where(x => x.PlayerName == btnBe3.Text).First());
        }

        private void btnBe4_Click(object sender, EventArgs e)
        {
            btnBe4.BackColor = Color.FromArgb(200, 200, 200);
            PlayerSelected(_teamService.BenchedPlayers.Where(x => x.PlayerName == btnBe4.Text).First());
        }

        private void btnBe5_Click(object sender, EventArgs e)
        {
            btnBe5.BackColor = Color.FromArgb(200, 200, 200);
            PlayerSelected(_teamService.BenchedPlayers.Where(x => x.PlayerName == btnBe5.Text).First());
        }

        private void btnBe6_Click(object sender, EventArgs e)
        {
            btnBe6.BackColor = Color.FromArgb(200, 200, 200);
            PlayerSelected(_teamService.BenchedPlayers.Where(x => x.PlayerName == btnBe6.Text).First());
        }

        private void btnBe7_Click(object sender, EventArgs e)
        {
            btnBe7.BackColor = Color.FromArgb(200, 200, 200);
            PlayerSelected(_teamService.BenchedPlayers.Where(x => x.PlayerName == btnBe7.Text).First());
        }

        private void btnBe8_Click(object sender, EventArgs e)
        {
            btnBe8.BackColor = Color.FromArgb(200, 200, 200);
            PlayerSelected(_teamService.BenchedPlayers.Where(x => x.PlayerName == btnBe8.Text).First());
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
                if (_teamService.BenchedPlayers.Contains(initialPlayer) && !_teamService.BenchedPlayers.Contains(player) && validSelection)
                {
                    _teamService.SwapPlayers(player, initialPlayer);
                    RenderPlayerNames();
                }
                else if (validSelection)
                {
                    _teamService.SwapPlayers(initialPlayer, player);
                    RenderPlayerNames();
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
            else if (initialPlayer.PlayerPosition != player.PlayerPosition)
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
            TransparentLabelonButton(labelBtnQB, btnQB);
            TransparentLabelonButton(labelBtnRB1, btnRB1);
            TransparentLabelonButton(labelBtnRB2, btnRB2);
            TransparentLabelonButton(labelBtnWR1, btnWR1);
            TransparentLabelonButton(labelBtnWR2, btnWR2);
            TransparentLabelonButton(labelBtnTE, btnTE);
            TransparentLabelonButton(labelBtnFlex, btnFlex);
            TransparentLabelonButton(labelBtnBe1, btnBe1);
            TransparentLabelonButton(labelBtnBe2, btnBe2);
            TransparentLabelonButton(labelBtnBe3, btnBe3);
            TransparentLabelonButton(labelBtnBe4, btnBe4);
            TransparentLabelonButton(labelBtnBe5, btnBe5);
            TransparentLabelonButton(labelBtnBe6, btnBe6);
            TransparentLabelonButton(labelBtnBe7, btnBe7);
            TransparentLabelonButton(labelBtnBe8, btnBe8);
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
            btnFlex.Text = _teamService.Flex.PlayerName;

            int index = 0;
            foreach (var button in this.Controls.OfType<Button>())
            {
                if (button.Name.StartsWith("btnBe"))
                {
                    button.Text = _teamService.BenchedPlayers[index].PlayerName;
                    var label = benchLabel[button.Name];
                    label.Text = _teamService.BenchedPlayers[index].PlayerPosition;
                    index++;
                }
            }
        }
        private void TransparentLabelonButton(Label l, Button b)
        {
            l.BackColor = Color.Transparent;
            l.Location = b.PointToClient(l.Parent.PointToScreen(l.Location));
            l.Parent = b;
        }
    }
}
