using FinalProject1_VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject1_POP
{
    public partial class POPMain : Form
    {
        POPVO User;
        public POPMain(POPVO user)
        {
            InitializeComponent();
            User = user;
        }
        

        private void POPMain_Load(object sender, EventArgs e)
        {
           
        }
    }
}
