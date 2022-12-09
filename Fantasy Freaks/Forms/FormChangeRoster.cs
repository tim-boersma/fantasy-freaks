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

namespace Fantasy_Freaks {
    public partial class FormChangeRoster : Form {
        private readonly ITeamService _teamService;
        private readonly IDefenseService _defenseService;
        private bool swapActive = false;
        private CurrentPlayerModel initialPlayer;
        public FormChangeRoster(ITeamService teamService, IDefenseService defenseService) {
            InitializeComponent();
            _teamService = teamService;
            _defenseService = defenseService;
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
            _teamService.BenchedPlayers.Where(x => x.PlayerName == btnBe1.Text);
        }

        private void btnBe2_Click(object sender, EventArgs e)
        {
            btnBe2.BackColor = Color.FromArgb(200, 200, 200);
            _teamService.BenchedPlayers.Where(x => x.PlayerName == btnBe2.Text);
        }

        private void btnBe3_Click(object sender, EventArgs e)
        {
            btnBe3.BackColor = Color.FromArgb(200, 200, 200);
            _teamService.BenchedPlayers.Where(x => x.PlayerName == btnBe3.Text);
        }

        private void btnBe4_Click(object sender, EventArgs e)
        {
            btnBe4.BackColor = Color.FromArgb(200, 200, 200);
            _teamService.BenchedPlayers.Where(x => x.PlayerName == btnBe4.Text);
        }

        private void btnBe5_Click(object sender, EventArgs e)
        {
            btnBe5.BackColor = Color.FromArgb(200, 200, 200);
            _teamService.BenchedPlayers.Where(x => x.PlayerName == btnBe5.Text);
        }

        private void btnBe6_Click(object sender, EventArgs e)
        {
            btnBe6.BackColor = Color.FromArgb(200, 200, 200);
            _teamService.BenchedPlayers.Where(x => x.PlayerName == btnBe6.Text);
        }

        private void btnBe7_Click(object sender, EventArgs e)
        {
            btnBe7.BackColor = Color.FromArgb(200, 200, 200);
            _teamService.BenchedPlayers.Where(x => x.PlayerName == btnBe7.Text);
        }

        private void btnBe8_Click(object sender, EventArgs e)
        {
            //playerbutton changes color
            btnBe8.BackColor = Color.FromArgb(200, 200, 200);
            _teamService.BenchedPlayers.Where(x => x.PlayerName == btnBe8.Text);
        }

        private void colorReset()
        {
            foreach (var button in this.Controls.OfType<Button>())
            {
                if(button.Name != "btnSeason")
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
                if(_teamService.BenchedPlayers.Contains(initialPlayer) && _teamService.BenchedPlayers.Contains(player))
                {
                    //let the user know they can't select two benched players or just deselect and don't do anything and they can figure it out
                    MessageBox.Show("You can't select two benched players, reselect players");
                }
                else if (initialPlayer.PlayerPosition != player.PlayerPosition)
                {
                    //let the user know they have to be the same position
                    MessageBox.Show("Players must share same position, reselect players");
                }
                else if (_teamService.BenchedPlayers.Contains(initialPlayer) && !_teamService.BenchedPlayers.Contains(player))
                {
                    _teamService.SwapPlayers(player, initialPlayer);
                }
                else
                {
                    _teamService.SwapPlayers(initialPlayer, player);
                }
                colorReset();
                swapActive = false;
            }
        }


        private void FormChangeRoster_Load(object sender, EventArgs e)
        {
            FFWindow.instance.setFont(this);
            btnQB.Text = _teamService.Quarterback.PlayerName;
            btnRB1.Text = _teamService.RunningBackOne.PlayerName;
            btnRB2.Text = _teamService.RunningBackTwo.PlayerName;
            btnTE.Text = _teamService.TightEnd.PlayerName;
            btnWR1.Text = _teamService.Quarterback.PlayerName;
            btnWR2.Text = _teamService.Quarterback.PlayerName;
            btnFlex.Text = _teamService.Quarterback.PlayerName;
            btnQB.Text = _teamService.Quarterback.PlayerName;

            int index = 0;
            foreach (var button in this.Controls.OfType<Button>())
            {
                if (button.Name.StartsWith("btnBe")) {
                    button.Text = _teamService.BenchedPlayers[index].PlayerName;
                    index++;
                }
            }
        }
    }
}
