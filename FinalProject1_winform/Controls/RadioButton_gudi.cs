﻿using System;
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
    public partial class RadioButton_gudi : RadioButton
    {
        public RadioButton_gudi()
        {
            InitializeComponent();
            this.Font = new Font("AppleSDGothicNeoM00", 10);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
