using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProject1_winform
{
    public partial class frmRestockOrder : FinalProject1_winform.Basic3
    {
        public frmRestockOrder()
        {
            InitializeComponent();
        }

        private void frmRestockOrder_Load(object sender, EventArgs e)
        {
            dtp1.FromDate = DateTime.Now.AddDays(-7);
            dtp1.ToDate = DateTime.Now;
        }

        private void button_gudi1_Click(object sender, EventArgs e)
        {

        }

        private void dataLoad()
        {
            
        }

        
    }
}
