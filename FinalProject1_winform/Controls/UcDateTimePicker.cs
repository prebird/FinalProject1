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
    public partial class UcDateTimePicker : UserControl
    {
        public DateTime FromDate 
        {
            get { return dateTimePicker_gudi1.Value; }
            set { dateTimePicker_gudi1.Value = value; } 
        }
        public DateTime ToDate 
        {
            get { return dateTimePicker_gudi2.Value; }
            set { dateTimePicker_gudi2.Value = value; }
        }

        public UcDateTimePicker()
        {
            InitializeComponent();
        }
    }
}
