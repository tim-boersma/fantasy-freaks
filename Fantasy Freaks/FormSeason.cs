﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fantasy_Freaks {
    public partial class FormSeason : Form {
        public FormSeason() {
            InitializeComponent();
        }

        private void btnWeekResults_Click(object sender, EventArgs e)
        {
            FFWindow.instance.changePanel(new FormWeekResults());
        }
    }
}