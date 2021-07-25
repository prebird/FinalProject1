using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject1_DAC;
using FinalProject1_VO;

namespace FinalProject1_winform
{
    public partial class frmNoticeDetail : Form
    {
        NoteDAC dac = new NoteDAC();
        int note_id = 0;
        public frmNoticeDetail(int note_id)
        {
            InitializeComponent();
            this.note_id = note_id;
        }

        private void frmNoticeDetail_Load(object sender, EventArgs e)
        {
            NoteVO note = dac.GetNoteInfo(note_id);
            txtTitle.Text = note.note_subject;
            txtContent.Text = note.note_contents;
            txtContent.Select(0, 0);
        }
    }
}
