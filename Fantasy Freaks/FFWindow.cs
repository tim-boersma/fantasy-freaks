﻿using System;
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

        private readonly ITeamService _teamService;

        public FFWindow(ITeamService teamService) {
            InitializeComponent();
            instance = this;
            _teamService = teamService;
            //activeForm = this;
        }

        private void FFWindow_Load(object sender, EventArgs e) {
            changePanel(new FormHomeScreen(_teamService));
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
