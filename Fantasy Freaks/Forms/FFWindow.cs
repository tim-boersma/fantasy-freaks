using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Text;
using DataAccess.Models;
using DataAccess.Interfaces;
using System.Runtime.InteropServices;

namespace Fantasy_Freaks {
    public enum Sport {
        Football
    }
    public partial class FFWindow : Form {
        private PrivateFontCollection pfc;
        public static FFWindow instance;
        private Form activeForm;
        public Sport activeSport;

        private readonly ITeamService _teamService;
        private readonly IDefenseService _defenseService;
        private readonly ICurrentPlayerService _currentPlayerService;

        public FFWindow(ITeamService teamService, IDefenseService defenseService, ICurrentPlayerService currentPlayerService)
        {
            InitializeComponent();
            instance = this;
            _teamService = teamService;
            _defenseService = defenseService;
            _currentPlayerService = currentPlayerService;
        }

        private void FFWindow_Load(object sender, EventArgs e) {
            loadFont();
            changePanel(new FormHomeScreen(_teamService, _defenseService, _currentPlayerService));
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

        private void loadFont() {
            pfc = new PrivateFontCollection();
            int fontLength = Properties.Resources.SEGUIVAR.Length;
            byte[] fontdata = Properties.Resources.SEGUIVAR;
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);
        }

        public Font getFont(Control c) {
            return new Font(pfc.Families[0], c.Font.Size, FontStyle.Bold);
        }

        public void setFont(Form form) {
            foreach(Control c in form.Controls) {
                c.Font = getFont(c);
            }
        }
    }
}
