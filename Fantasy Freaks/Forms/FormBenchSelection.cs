using DataAccess.Interfaces;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using static DataAccess.GlobalConstants;

namespace Fantasy_Freaks {
    public partial class FormBenchSelection : Form {

        private readonly ICurrentPlayerService _currentPlayer;
        private readonly ITeamService _team;
        private IEnumerable<CurrentPlayerModel> players;
        private readonly string _playerSelection;
        public FormBenchSelection(ICurrentPlayerService currentPlayer, ITeamService teamService, string playerSelection) {
            InitializeComponent();
            _currentPlayer = currentPlayer;
            _playerSelection = playerSelection;
            _team = teamService;
        }

        private async void FormPlayerSelection_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fantasyFreaksDataSet.NewSeasonPlayer' table. You can move, or remove it, as needed.
            //this.newSeasonPlayerTableAdapter.Fill(this.fantasyFreaksDataSet.NewSeasonPlayer);
            players = await GetSelectedPlayers();

            dgvPlayers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPlayers.DataSource = players;

            lblSelection.Text = "Select your " + _playerSelection;
        }

        private async Task<IEnumerable<CurrentPlayerModel>> GetSelectedPlayers()
        {
            switch (_playerSelection)
            {
                case PlayerTypes.Quarterback:
                    return await _currentPlayer.GetAllQuarterbacks();
                case PlayerTypes.RunningBack:
                    return await _currentPlayer.GetAllRunningbacks();
                case PlayerTypes.RunningBackTwo:
                    return await _currentPlayer.GetAllRunningbacks();
                case PlayerTypes.TightEnd:
                    return await _currentPlayer.GetAllTightEnds();
                case PlayerTypes.WideReceiver:
                    return await _currentPlayer.GetAllWideReceivers();
                case PlayerTypes.WideReceiverTwo:
                    return await _currentPlayer.GetAllWideReceivers();
                default:
                    return await _currentPlayer.GetAllPlayers();
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            var selectedPlayer = (CurrentPlayerModel)dgvPlayers.SelectedRows[0].DataBoundItem;
            _team.SetPosition(_playerSelection, selectedPlayer);
            this.Close();
        }
    }
}
