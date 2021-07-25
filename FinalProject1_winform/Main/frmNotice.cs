using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject1_VO;
using FinalProject1_DAC;

namespace FinalProject1_winform
{
    public partial class frmNotice : Form
    {
        NoteDAC dac = new NoteDAC();
        public frmNotice()
        {
            InitializeComponent();
            CommonUtil.SetInitGridView(dgv1);
            CommonUtil.AddGridTextColumn(dgv1, "번호", "note_id", colWidth:70);
            CommonUtil.AddGridTextColumn(dgv1, "제목", "note_subject", colWidth:100);
            CommonUtil.AddGridTextColumn(dgv1, "내용", "note_contents", colWidth:300);
            CommonUtil.AddGridTextColumn(dgv1, "일자", "note_date", colWidth:100);
        }

        private void frmNotice_Load(object sender, EventArgs e)
        {
            List<NoteVO> notes = dac.GetAllList();
            dgv1.DataSource = notes;
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmNoticeDetail frm = new frmNoticeDetail(Convert.ToInt32(dgv1.Rows[e.RowIndex].Cells[0].Value));
            frm.ShowDialog();
        }

        
    }
}
