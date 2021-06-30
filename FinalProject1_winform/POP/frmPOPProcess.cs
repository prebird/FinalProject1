using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject1_winform.POP
{
    public partial class frmPOPProcess : Form
    {
        public frmPOPProcess()
        {
            InitializeComponent();
        }

        private void frmPOPProcess_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 50;
            lblPprocess.Text = progressBar1.Value.ToString();
        }
    }
}
