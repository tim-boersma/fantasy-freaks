using Fantasy_Freaks.Interfaces;
using Fantasy_Freaks.Models;
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
        private bool swapActive = false;
        private CurrentPlayerModel initialPlayer;
        public FormChangeRoster(ITeamService teamService) {
            InitializeComponent();
            _teamService = teamService;
        }

        //int pointsAllowed = WinStat.TYscore(/*ty value*/);
        //int yardsAllowed = WinStat.Tpscore(/*tp value*/);
        //int offScore = WinStat.offScoreCalc(/*from table for off*/);
        //double defScore = WinStat.defScoreCalc(/*from table for def, pointsAllowed, yardsAllowed*/);


        private void btnSeason_Click(object sender, EventArgs e)
        {
            FFWindow.instance.changePanel(new FormSeason());
        }

        private void btnQB_Click(object sender, EventArgs e)
        {

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
            //playerbutton changes color
            PlayerSelected(_teamService.BenchedPlayers[7]);
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
                }
                else if (initialPlayer.PlayerPosition != player.PlayerPosition)
                {
                    //let the user know they have to be the same position
                }
                else if (_teamService.BenchedPlayers.Contains(initialPlayer) && !_teamService.BenchedPlayers.Contains(player))
                {
                    _teamService.SwapPlayers(player, initialPlayer);
                }
                else
                {
                    _teamService.SwapPlayers(initialPlayer, player);
                }
                swapActive = false;
            }
        }



        private void FormChangeRoster_Load(object sender, EventArgs e)
        {
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
