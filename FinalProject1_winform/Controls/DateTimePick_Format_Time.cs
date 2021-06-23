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
    public partial class DateTimePick_Format_Time : DateTimePicker
    {
        public DateTimePick_Format_Time()
        {
            InitializeComponent();
            this.Font = new Font("AppleSDGothicNeoM00", 10);
            this.Format = DateTimePickerFormat.Custom;
            this.CustomFormat = "yyyy-MM-dd HH:mm";
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
