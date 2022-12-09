using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fantasy_Freaks {
    public partial class FormPlayerSelection : Form {
        Button pos;
        public FormPlayerSelection(Button button) {
            InitializeComponent();
            this.pos = button;
        }
        private void FormPlayerSelection_Unload(object sender, EventArgs e) {
            pos.Enabled = true;
        }
    }
}
