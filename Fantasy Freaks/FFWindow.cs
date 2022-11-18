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

namespace Fantasy_Freaks {
    public enum Sport {
        Football
    }
    public partial class FFWindow : Form {
        public static FFWindow instance;
        private Form activeForm;
        public Sport activeSport;
        private readonly IContributerService _contributerService;

        public FFWindow(IContributerService contributerService) {
            InitializeComponent();
            instance = this;
            this._contributerService = contributerService;
            MessageBox.Show(_contributerService.SayHello());
        }

        private void FFWindow_Load(object sender, EventArgs e) {
            changePanel(new FormHomeScreen(_contributerService));
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
