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
    public partial class frmInspectAdd : Form
    {
        List<InspectVO> inspects;
        int ro_id = 0;
        
        public frmInspectAdd()
        {
            InitializeComponent();
        }

        private void frmInspectAdd_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgv1);
            CommonUtil.AddGridTextColumn(dgv1, "대기번호", "ins_id", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgv1, "품명", "Item_Name", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgv1, "품번", "Item_ID", DataGridViewContentAlignment.MiddleCenter, colWidth: 100, visibility:false) ;                          
            CommonUtil.AddGridTextColumn(dgv1, "입고량", "ins_cnt", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgv1, "입고번호", "ins_id", DataGridViewContentAlignment.MiddleCenter, colWidth: 100, visibility:false);
            CommonUtil.AddGridTextColumn(dgv1, "입고일자", "ins_date", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgv1, "입고수량", "ins_cnt", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgv1, "불합격수", "insp_noCnt", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgv1, "합불여부", "insp_result", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);                       
            CommonUtil.AddGridTextColumn(dgv1, "ro_id", "Ro_id", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);                       
            CommonUtil.AddGridTextColumn(dgv1, "검사날짜", "inspect_date", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgv1, "검사자", "inspect_user", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);


            CommonUtil.SetInitGridView(dgv2);
            CommonUtil.AddGridTextColumn(dgv2, "품번", "Item_ID", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgv2, "품명", "Item_Name", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgv2, "평균", "Mean", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgv2, "USL", "USL", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgv2, "LSL", "LSL", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            



            LoadData();
            dgv1.ClearSelection();
        }

        private void LoadData()
        {
            RestockOrderDAC dac = new RestockOrderDAC();
            inspects = dac.GetAllInspect();
            dgv1.DataSource = inspects;
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // 규격 그리드뷰 바인딩
            int itemid = Convert.ToInt32(dgv1.Rows[e.RowIndex].Cells[2].Value);
            RestockOrderDAC dac = new RestockOrderDAC();
            List<InspectCriteriaVO> criteria = dac.GetInspectCriteriaByID(itemid);
            dgv2.DataSource = criteria;
            dgv2.ClearSelection();

            // 텍스트박스 바인딩
            txtinsid.Text = dgv1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtItemname.Text = dgv1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtInCnt.Text = dgv1.Rows[e.RowIndex].Cells[6].Value.ToString();
            ro_id = Convert.ToInt32(dgv1.Rows[e.RowIndex].Cells[9].Value);

        }

        private void dgv2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (!txt1.CheckNullOrEmptyOk("시료1측정값")) return;
            if (!txt1.CheckNullOrEmptyOk("시료2측정값")) return;
            if (!txt1.CheckNullOrEmptyOk("시료3측정값")) return;
            if (!txt1.CheckNullOrEmptyOk("시료4측정값")) return;
            if (!txt1.CheckNullOrEmptyOk("시료5측정값")) return;
            if (dgv2.SelectedRows.Count < 1)
            {
                MessageBox.Show("품질검사 기준을 선택하여 주세요");
            }

            // 시료 5개의 평균과 분산을 내어 표시
            List<double> data = new List<double>(new double[] { Convert.ToDouble(txt1.Text), Convert.ToDouble(txt2.Text), Convert.ToDouble(txt3.Text), Convert.ToDouble(txt4.Text), Convert.ToDouble(txt5.Text) });

            double mean = Average(data);
            double dev = getStandardDeviation(data);

            txtAvg.Text = mean.ToString();
            txtDev.Text = dev.ToString();

            // 판정
            double usl = Convert.ToDouble(dgv2.SelectedRows[0].Cells[3].Value);
            double lsl = Convert.ToDouble(dgv2.SelectedRows[0].Cells[4].Value);

            if (usl >= mean && mean >= lsl)
            {
                txtResult.Text = "합";
            }
            else
            {
                txtResult.Text = "불합";
            }
            if (txtResult.Text == "합")
            {
                txtResult.BackColor = Color.LightSkyBlue;
            }
            else if (txtResult.Text == "불합")
            {
                txtResult.BackColor = Color.OrangeRed;
            }
        }

        //평균함수
        public double Average(IEnumerable<double> source)
        {

            double sum = 0;
            double count = 0;
            
            foreach (double v in source)
            {
                sum += v;
                count++;
            }

            return sum/count;
            
            
        }

        // 분산구하기
        private double getStandardDeviation(List<double> doubleList)
        {
            double average = doubleList.Average();
            double sumOfDerivation = 0;
            foreach (double value in doubleList)
            {
                sumOfDerivation += (value) * (value);
            }
            double sumOfDerivationAverage = sumOfDerivation / doubleList.Count;
            return Math.Sqrt(sumOfDerivationAverage - (average * average));
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txt1.Text = txt2.Text = txt3.Text = txt4.Text = txt5.Text = txtAvg.Text = txtDev.Text = txtResult.Text = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 유저
            frmMain main = (frmMain)this.MdiParent;
            UserInfoVO user = main.User;

            RestockOrderDAC dac = new RestockOrderDAC();
            if (dac.InsertInspectData(Convert.ToInt32(txtinsid.Text), Convert.ToInt32(txtNoCnt.Text), txtResult.Text, user.user_name, ro_id))
            {
                MessageBox.Show("데이터가 성공적으로 삽입되었습니다.");
                LoadData();
                btnReset.PerformClick();
                dgv2.DataSource = null;
            }
            else
            {
                MessageBox.Show("다시시도해 주십시오");
            }
        }

        
    }
}
