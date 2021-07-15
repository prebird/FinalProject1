using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject1_winform
{
    public partial class frmRestockOrderPopUP : Form
    {
        DataView dvRO = new DataView();
        public frmRestockOrderPopUP(DataView dv)
        {
            InitializeComponent();
            dvRO = dv;
        }

        private void frmRestockOrderPopUP_Load(object sender, EventArgs e)
        {

        }

        //닫기
        private void button_gudi1_Click(object sender, EventArgs e)
        {

        }
    }
}
