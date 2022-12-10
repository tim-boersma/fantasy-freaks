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
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace Fantasy_Freaks {
    public partial class FormBenchSelection : Form {

        private readonly ICurrentPlayerService _currentPlayer;
        private readonly ITeamService _team;
        private IEnumerable<CurrentPlayerModel> players;
        private List<CurrentPlayerModel> selectedPlayers = new List<CurrentPlayerModel>();
        private readonly string _playerSelection;
        private int playerLabelTopStart;
        private int removeButtonTopStart;
        public FormBenchSelection(ICurrentPlayerService currentPlayer, ITeamService teamService, string playerSelection) {
            InitializeComponent();
            _currentPlayer = currentPlayer;
            _playerSelection = playerSelection;
            _team = teamService;
        }

        private async void FormPlayerSelection_Load(object sender, EventArgs e)
        {
            //
            // : This line of code loads data into the 'fantasyFreaksDataSet.NewSeasonPlayer' table. You can move, or remove it, as needed.
            //this.newSeasonPlayerTableAdapter.Fill(this.fantasyFreaksDataSet.NewSeasonPlayer);

            players = await GetSelectedPlayers();

            dgvPlayers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPlayers.DataSource = players;



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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (selectedPlayers.Count() == 8)
            {
                _team.BenchedPlayers = selectedPlayers;
                this.Close();
            }
            else
            {
                MessageBox.Show("You must have a full bench before submitting");
            }
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            
        }

        private void RenderPlayerList()
        {
            playerLabelTopStart = 92;
            removeButtonTopStart = 92;
            foreach(var player in selectedPlayers)
            {
                AddPlayerLabel(player);
                AddPlayerRemovalButton(player);
            }
        }

        private void RemoveSelectedPlayerButtons()
        {
            var playerIDs = selectedPlayers.Select(x => x.PlayerID).ToList();
            var buttons = this.Controls.OfType<Button>().ToList();
            var tags = buttons.Select(x => x.Tag).ToList();
            foreach (var button in buttons)
            {
                if (button.Tag != null && playerIDs.Contains((int)button.Tag))
                {
                    this.Controls.Remove(button);
                }
            }
        }

        private void RemoveSelectedPlayerLabels()
        {
            var playerIDs = selectedPlayers.Select(x => x.PlayerID).ToList();
            foreach (var label in this.Controls.OfType<Label>())
            {
                if (label.Tag != null && playerIDs.Contains((int)label.Tag))
                {
                    this.Controls.Remove(label);
                }
            }
        }

        private void btnRemovePlayer_Click(object sender, EventArgs e)
        {
            if(sender is Button)
            {
                var btn = (Button)sender;
                var removedPlayer = selectedPlayers.Where(x => x.PlayerID == (int)btn.Tag).FirstOrDefault();
                RemoveSelectedPlayerLabels();
                RemoveSelectedPlayerButtons();
                selectedPlayers.Remove(removedPlayer);
                RenderPlayerList();
            }
        }

        private void AddPlayerRemovalButton(CurrentPlayerModel player)
        {
            Button btn = new Button();
            btn.Location = new Point(524, removeButtonTopStart);
            btn.Size = new Size(57, 20);
            btn.Text = "Remove";
            btn.Tag = player.PlayerID;
            btn.Click += btnRemovePlayer_Click;
            this.Controls.Add(btn);

            removeButtonTopStart += 28;
        }

        private void AddPlayerLabel(CurrentPlayerModel player)
        {
            Label label = new Label();
            label.Location = new Point(372, playerLabelTopStart);
            label.Size = new Size(148, 20);
            label.Text = player.PlayerName;
            label.Font = new Font("Microsoft YaHei", 11);
            label.AutoEllipsis = true;
            label.Tag = player.PlayerID;
            this.Controls.Add(label);

            playerLabelTopStart += 28;
        }

        private void dgvPlayers_SelectionChanged(object sender, EventArgs e)
        {
            var selectedPlayer = (CurrentPlayerModel)dgvPlayers.SelectedRows[0].DataBoundItem;
            if (selectedPlayers.Count >= 8)
            {
                MessageBox.Show("You can only have eight players on your team");
            }
            else if (selectedPlayers.Contains(selectedPlayer))
            {
                MessageBox.Show("Player is already on the bench");
            }
            else
            {
                selectedPlayers.Add(selectedPlayer);
                RemoveSelectedPlayerLabels();
                RemoveSelectedPlayerButtons();
                RenderPlayerList();
            }
        }
    }
}
