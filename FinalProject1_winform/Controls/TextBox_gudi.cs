using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject1_winform.Controls
{
    public enum validType { Common, Numeric, Required, RequiredNumeric, Money_Won };

    public partial class TextBox_gudi : TextBox
    {
        private validType input;
        public validType InputType
        {
            get { return input; }
            set
            {
                input = value;
                if (input == validType.Required || input == validType.RequiredNumeric)
                {
                    this.BackColor = Color.Aqua;
                }
            }
        }

        public TextBox_gudi()
        {
            InitializeComponent();
            this.Font = new Font("AppleSDGothicNeoM00", 10);
            Initialize();

        }

        private void Initialize()
        {
            this.TextChanged += new EventHandler(ThisTextChanged);
        }

        private void ThisTextChanged(object sender, EventArgs e)
        {
            //If the text of the textbox is not empty
            if (this.TextLength > 0)
            {
                SettingWhenMoneyType(sender);
            }
            else
            {
                
            }
        }

        private void SettingWhenMoneyType(object sender)
        {
            // 숫자에 천단위 구분자 찍기
            TextBox txtbox = (TextBox)sender;
            if (this.InputType == validType.Money_Won && !string.IsNullOrEmpty(txtbox.Text))
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("ko-KR");
                int valueBefore = Int32.Parse(txtbox.Text, System.Globalization.NumberStyles.AllowThousands);
                txtbox.Text = string.Format(culture, "{0:N0}", valueBefore);
                txtbox.Select(txtbox.Text.Length, 0);

            }
        }

        public override string Text
        {
            get
            {
                string text = base.Text;
                if (this.InputType == validType.Money_Won)
                {
                    text = text.Replace(",", "");
                }
                return text;
            }
            set => base.Text = value;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (input == validType.Numeric || input == validType.RequiredNumeric || input == validType.Money_Won)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            if (input == validType.Required || input == validType.RequiredNumeric)
            {
                if (string.IsNullOrWhiteSpace(this.Text.Trim()))
                {
                    MessageBox.Show($"{this.Tag} 필수입력항목입니다. ");
                    this.Focus();
                }
            }
        }
    }
}
