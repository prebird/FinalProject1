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
    public partial class Label_gudi : Label
    {


        public Label_gudi()
        {
            InitializeComponent();
            RepaintWhenChangeSetting();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void RepaintWhenChangeSetting()
        {
            this.Font = new Font("AppleSDGothicNeoM00", 10);
        }
    }
}
