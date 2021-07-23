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
    public partial class frmMateriaInspect : Basic3
    {
        List<InspectVO> inspects;
        public frmMateriaInspect()
        {
            InitializeComponent();
        }

        private void frmMateriaInspect_Load(object sender, EventArgs e)
        {
            CommonUtil.ComboBindingROID(cboROID);
            cboStatus.SelectedIndex = 0;
            cboResult.SelectedIndex = 0;

            dtpInspect.FromDate = DateTime.Now.AddDays(-7);
            dtpInspect.ToDate = DateTime.Now;



            CommonUtil.SetInitGridView(dgvInspect);
            CommonUtil.AddGridTextColumn(dgvInspect, "번호", "ins_id", DataGridViewContentAlignment.MiddleCenter, colWidth: 180);
            CommonUtil.AddGridTextColumn(dgvInspect, "품명", "Item_Name", DataGridViewContentAlignment.MiddleCenter, colWidth: 180);

            CommonUtil.AddGridTextColumn(dgvInspect, "입고량", "ins_cnt", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgvInspect, "입고일자", "ins_date", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgvInspect, "불합격수", "insp_noCnt", DataGridViewContentAlignment.MiddleCenter, colWidth: 180);
            CommonUtil.AddGridTextColumn(dgvInspect, "합불여부", "insp_result", DataGridViewContentAlignment.MiddleCenter, colWidth: 180);

            CommonUtil.AddGridTextColumn(dgvInspect, "검사날짜", "inspect_date", DataGridViewContentAlignment.MiddleCenter, colWidth: 170);
            CommonUtil.AddGridTextColumn(dgvInspect, "검사자", "inspect_user", DataGridViewContentAlignment.MiddleCenter, colWidth: 170);
            

            LoadData();
        }

        private void LoadData()
        {
            RestockOrderDAC dac = new RestockOrderDAC();
            inspects = dac.SearchInspectData(dtpInspect.FromDate.ToShortDateString(), dtpInspect.ToDate.ToShortDateString(), Convert.ToInt32(cboROID.Text), cboStatus.Text, cboResult.Text);
            dgvInspect.DataSource = inspects;
        }

        //조회
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        //검사 확인
        private void btnCheck_Click(object sender, EventArgs e)
        {
            frmMain frm = (frmMain)this.MdiParent;
            frm.OpenCreateForm("frmInspectAdd");
        }
    }
}
