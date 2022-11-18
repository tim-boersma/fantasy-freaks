using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fantasy_Freaks
{
    public partial class FormHelpScreen : Form
    {
        private readonly IContributerService _contributerService;

        public FormHelpScreen(IContributerService contributerService)
        {
            InitializeComponent();
            this._contributerService = contributerService;
            MessageBox.Show(_contributerService.SayHello());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FFWindow.instance.changePanel(new FormHomeScreen(_contributerService));
        }
    }
}
