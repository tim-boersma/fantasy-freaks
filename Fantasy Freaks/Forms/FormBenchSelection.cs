using DataAccess.Interfaces;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;

namespace Fantasy_Freaks {
    public partial class FormBenchSelection : Form {

        private readonly ICurrentPlayerService _currentPlayer;
        private readonly ITeamService _team;
        private IEnumerable<CurrentPlayerModel> players;
        private List<CurrentPlayerModel> selectedPlayers = new List<CurrentPlayerModel>();
        private readonly string _playerSelection;
        private int playerLabelTopStart;
        private int removeButtonTopStart;
        public bool userIsSearching = false;
        public FormBenchSelection(ICurrentPlayerService currentPlayer, ITeamService teamService, string playerSelection) {
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

            players = await _currentPlayer.GetSelectedPlayers(_playerSelection);

            dgvPlayers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPlayers.DataSource = players;
            dgvPlayers.ClearSelection();
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

        private void RenderPlayerList()
        {
            playerLabelTopStart = 125;
            removeButtonTopStart = 125;
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
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.Firebrick;
            btn.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btn.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn.Font = FFWindow.instance.getFont(btn);
            btn.ForeColor = Color.White;
            btn.Size = new Size(57, 20);
            btn.Text = "Remove";
            btn.Tag = player.PlayerID;
            btn.Click += btnRemovePlayer_Click;
            this.Controls.Add(btn);
            btn.BringToFront();

            removeButtonTopStart += 28;
        }

        private void AddPlayerLabel(CurrentPlayerModel player)
        {
            Label label = new Label();
            label.Location = new Point(365, playerLabelTopStart);
            label.Size = new Size(148, 20);
            label.Text = player.PlayerName;
            label.Font = FFWindow.instance.getFont(label);
            label.BackColor = Color.FromArgb(217, 217, 217);
            label.AutoEllipsis = true;
            label.Tag = player.PlayerID;
            this.Controls.Add(label);
            label.BringToFront();

            playerLabelTopStart += 28;
        }

        private void dgvPlayers_SelectionChanged(object sender, EventArgs e)
        {
            if (userIsSearching)
                return;

            if(dgvPlayers.SelectedRows.Count == 0)
            {
                RemoveSelectedPlayerLabels();
                RemoveSelectedPlayerButtons();
                selectedPlayers.Clear();
                RenderPlayerList();
                return;
            }

            var selectedPlayer = (CurrentPlayerModel)dgvPlayers.SelectedRows[0].DataBoundItem;
            AddPlayerToBench(selectedPlayer);
        }

        private void AddPlayerToBench(CurrentPlayerModel selectedPlayer)
        {
            bool selectionIsValid = ValidateBenchSelection(selectedPlayer);

            if (selectionIsValid)
            {
                selectedPlayers.Add(selectedPlayer);
                RemoveSelectedPlayerLabels();
                RemoveSelectedPlayerButtons();
                RenderPlayerList();
            }
        }

        private bool ValidateBenchSelection(CurrentPlayerModel selectedPlayer)
        {
            if (selectedPlayers.Count >= 8)
            {
                MessageBox.Show("You can only have eight players on your team");
                return false;
            }
            else if (selectedPlayers.Contains(selectedPlayer))
            {
                MessageBox.Show("Player is already on the bench");
                return false;
            }
            return true;
        }

        private void textBoxBenchSearch_TextChanged(object sender, EventArgs e)
        {
            userIsSearching = true;
            string text = textBoxBenchSearch.Text;
            var searchResult = players.Where(x => x.PlayerName.ToLower().Contains(text.ToLower())).ToList();
            dgvPlayers.DataSource = searchResult;
            dgvPlayers.ClearSelection();
            userIsSearching = false;
        }
    }
}
