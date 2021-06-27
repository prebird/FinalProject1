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
    public partial class DateTimePicker_gudi : DateTimePicker
    {
        public DateTimePicker_gudi()
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
            this.Format = DateTimePickerFormat.Short;
        }
    }
}
