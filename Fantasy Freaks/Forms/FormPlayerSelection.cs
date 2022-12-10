using DataAccess.Interfaces;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using static DataAccess.GlobalConstants;
using System.Linq;

namespace Fantasy_Freaks {
    public partial class FormPlayerSelection : Form {

        private readonly ICurrentPlayerService _currentPlayer;
        private readonly ITeamService _team;
        private IEnumerable<CurrentPlayerModel> players;
        private readonly string _playerSelection;
        public FormPlayerSelection(ICurrentPlayerService currentPlayer, ITeamService teamService, string playerSelection) {
            InitializeComponent();
            _currentPlayer = currentPlayer;
            _playerSelection = playerSelection;
            _team = teamService;
        }

        private async void FormPlayerSelection_Load(object sender, EventArgs e)
        {
            FFWindow.instance.setFont(this);
            dgvPlayers.ColumnHeadersDefaultCellStyle.Font = FFWindow.instance.getFont(dgvPlayers);
            dgvPlayers.DefaultCellStyle.Font = FFWindow.instance.getFont(dgvPlayers);
            dgvPlayers.RowsDefaultCellStyle.Font = FFWindow.instance.getFont(dgvPlayers);

            // TODO: This line of code loads data into the 'fantasyFreaksDataSet.NewSeasonPlayer' table. You can move, or remove it, as needed.
            //this.newSeasonPlayerTableAdapter.Fill(this.fantasyFreaksDataSet.NewSeasonPlayer);
            players = await _currentPlayer.GetSelectedPlayers(_playerSelection);

            dgvPlayers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPlayers.DataSource = players;

            lblSelection.Text = "Select your " + PlayerTypes.fullPlayerTypeNames[_playerSelection];
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var selectedPlayer = (CurrentPlayerModel)dgvPlayers.SelectedRows[0].DataBoundItem;
            var activePlayers = _team.GetActivePlayerIDs();
            if (!activePlayers.Contains(selectedPlayer.PlayerID))
            {
                _team.SetPosition(_playerSelection, selectedPlayer);
                this.Close();
            } else
            {
                MessageBox.Show("You already have that player on your team");
            }
        }

        private void textBoxPlayerSearch_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxPlayerSearch.Text;
            var searchResult = players.Where(x => x.PlayerName.ToLower().Contains(text.ToLower())).ToList();
            dgvPlayers.DataSource = searchResult;
        }
    }
}
