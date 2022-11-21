using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using Fantasy_Freaks.Models;
using Fantasy_Freaks.Interfaces;

namespace Fantasy_Freaks {
    public enum Sport {
        Football
    }
    public partial class FFWindow : Form {
        public static FFWindow instance;
        private Form activeForm;
        public Sport activeSport;

        private readonly IDefenseService _defenseService;
        private readonly IPreviousPlayerService _previousPlayerService;
        private readonly IPlayerService _playerService;

        public FFWindow(IDefenseService defenseService, IPreviousPlayerService previousPlayerService, IPlayerService playerService) {
            InitializeComponent();
            instance = this;
            _defenseService= defenseService;
            _previousPlayerService= previousPlayerService;
            _playerService = playerService;
            //activeForm = this;
        }

        private void FFWindow_Load(object sender, EventArgs e) {
            changePanel(new FormHomeScreen(_defenseService, _previousPlayerService, _playerService));
        }
        public void changePanel(Form newForm) {
            if (activeForm != null) {
                activeForm.Close();
            }
            activeForm = newForm;
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            newForm.ControlBox = false;
            newForm.Text = "";
            this.mainPanel.Controls.Add(newForm);
            this.mainPanel.Tag = newForm;
            newForm.BringToFront();
            newForm.Show();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
