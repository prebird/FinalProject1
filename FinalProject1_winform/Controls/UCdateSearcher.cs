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
    public partial class UCdateSearcher : UserControl
    {
        #region prop
        public enum bColor { White, Gray}
        private bColor ucbackColor;
        public bColor UcBackColor 
        { 
            get { return ucbackColor; } 
            set 
            { 
                ucbackColor = value; 
            }
        }

        public DateTime FromDate
        {
            get { return dateTimePicker1.Value; }
            set { dateTimePicker1.Value = value; }
        }

        public DateTime ToDate
        {
            get { return dateTimePicker2.Value; }
            set { dateTimePicker2.Value = value; }
        }
        #endregion

        public UCdateSearcher()
        {
            InitializeComponent();
        }

        private void setBackColor()
        {
            if (ucbackColor == bColor.White)
            {
                this.BackColor = Color.White;
            }
            else if (ucbackColor == bColor.Gray)
            {
                this.BackColor = Color.Gray;
            }
        }


        #region event
        private void UCdateSearcher_Load(object sender, EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker1.Value = DateTime.Now;
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value = DateTime.Now;
        }

        private void btnWeek_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker2.Value.AddDays(-7);
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker2.Value.AddMonths(-1);
        }

        private void btn3month_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker2.Value.AddMonths(-3);
        }

        private void btn6month_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker2.Value.AddMonths(-6);
        }

        #endregion


    }
}
