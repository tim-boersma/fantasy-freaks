using DataAccess.Interfaces;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Fantasy_Freaks.GlobalConstants;

namespace Fantasy_Freaks {
    public partial class FormPlayerSelection : Form {

        private readonly ICurrentPlayerService _currentPlayer;
        private IEnumerable<CurrentPlayerModel> players;
        private readonly string _playerSelection;
        public FormPlayerSelection(ICurrentPlayerService currentPlayer, string playerSelection) {
            InitializeComponent();
            _currentPlayer = currentPlayer;
            _playerSelection = playerSelection;
        }

        private async void FormPlayerSelection_Load(object sender, EventArgs e)
        {
            players = await GetSelectedPlayers();
            int btnTop = 10;

            foreach (var player in players)
            {
                Button button = new Button();
                button.Left = 25;
                button.Top = btnTop;
                this.Controls.Add(button);
                button.Text = player.PlayerName;
                btnTop += button.Height + 2;
            }
        }

        private async Task<IEnumerable<CurrentPlayerModel>> GetSelectedPlayers()
        {
            switch (_playerSelection)
            {
                case PlayerTypes.Quarterback:
                    return await _currentPlayer.GetAllQuarterbacks();
                case PlayerTypes.RunningBack:
                    return await _currentPlayer.GetAllRunningbacks();
                case PlayerTypes.TightEnd:
                    return await _currentPlayer.GetAllTightEnds();
                case PlayerTypes.WideReceiver:
                    return await _currentPlayer.GetAllWideReceivers();
                default:
                    return await _currentPlayer.GetAllPlayers();
            }
        }
    }
}
