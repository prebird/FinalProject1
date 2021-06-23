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
    public enum ButtonStyle { Highlight, Normal, Middle, Search }

    public partial class Button_gudi : Button
    {
        private ButtonStyle input;

        [DisplayName]
        public ButtonStyle ButtonType
        {
            get { return input; }
            set 
            { 
                input = value;
                RePaintWhenChangeSetting();
            }
        }

        public Button_gudi()
        {
            InitializeComponent();
            input = ButtonStyle.Normal;
            RePaintWhenChangeSetting();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void RePaintWhenChangeSetting()
        {
            if (input == ButtonStyle.Highlight)
            {
                this.BackColor = Color.FromArgb(92, 146, 209);
                this.ForeColor = Color.White;
                this.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
                this.FlatStyle = FlatStyle.Flat;

            }
            else if (input == ButtonStyle.Normal)
            {
                this.BackColor = Color.FromArgb(134, 142, 150);
                this.ForeColor = Color.White;
                this.FlatAppearance.BorderSize = 0;
                this.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
                this.FlatStyle = FlatStyle.Flat;
            }
            else if (input == ButtonStyle.Middle)
            {
                this.BackColor = Color.FromArgb(177, 191, 201);
                this.ForeColor = Color.Black;
                this.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
                this.FlatStyle = FlatStyle.Popup;
            }
            else if (input == ButtonStyle.Search)
            {
                this.BackColor = Color.FromArgb(12, 99, 191);
                this.ForeColor = Color.White;
                this.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
                this.FlatStyle = FlatStyle.Flat;
            }
        }
    }
}
