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
    public partial class PictureBox_gudi : PictureBox
    {
        public PictureBox_gudi()
        {
            InitializeComponent();
            this.SizeMode = PictureBoxSizeMode.Zoom;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
