﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject1_VO;

namespace FinalProject1_winform
{
    public partial class frmFactory : Basic3
    {
        List<FactoryVO> list;
        public frmFactory()
        {
            InitializeComponent();
        }

        private void frmFactory_Load(object sender, EventArgs e)
        {
            cboFactoryGrade.Text = "선택";
            FactoryVO factory = new FactoryVO();
            FactoryService bservice = new FactoryService();
            list = bservice.GetFactoryGrade();
            factory.factory_grade = "선택";
            factory.factory_code = "";
            list.Insert(0, factory);

            CommonUtil.ComboBinding<FactoryVO>(cboFactoryGrade, list, "factory_grade", "factory_code");

            CommonUtil.SetInitGridView(dgv_Factory);
            CommonUtil.AddGridTextColumn(dgv_Factory, "시설군", "factory_grade", DataGridViewContentAlignment.MiddleCenter, colWidth: 135);
            CommonUtil.AddGridTextColumn(dgv_Factory, "시설구분", "common_name", DataGridViewContentAlignment.MiddleCenter, colWidth: 180);
            CommonUtil.AddGridTextColumn(dgv_Factory, "시설타입", "factoty_type", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgv_Factory, "시설코드", "factory_code", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgv_Factory, "시설명", "factory_name", DataGridViewContentAlignment.MiddleCenter, colWidth: 200);
            CommonUtil.AddGridTextColumn(dgv_Factory, "상위시설", "factory_parent", DataGridViewContentAlignment.MiddleCenter, colWidth: 170);
            CommonUtil.AddGridTextColumn(dgv_Factory, "사용유무", "factory_yn", DataGridViewContentAlignment.MiddleCenter, colWidth: 170);
            CommonUtil.AddGridTextColumn(dgv_Factory, "시설설명", "factory_comment", DataGridViewContentAlignment.MiddleCenter, colWidth: 170);
            CommonUtil.AddGridTextColumn(dgv_Factory, "수정일자", "factory_uadmin", DataGridViewContentAlignment.MiddleCenter, colWidth: 170);
            
            LoadData();
        
        }

        private void LoadData()
        {
            FactoryService service = new FactoryService();
            list = service.GetAllFactory();
            dgv_Factory.DataSource = list;
            dgv_Factory.ClearSelection();
        }

        //검색 조건 조회
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string factoryCode = txtFactoryCode.Text;
            string factoryGrade = cboFactoryGrade.Text;

            if (cboFactoryGrade.Text == "선택")
                factoryGrade = "";

            FactoryService sservice = new FactoryService();
            list = sservice.SearchFactory(factoryCode, factoryGrade);
            dgv_Factory.DataSource = list;
            dgv_Factory.ClearSelection();
        }

        //공장 등록
        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmFactoryIns frm = new frmFactoryIns();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }

        }

        //공장 수정
        private void btmUpdate_Click(object sender, EventArgs e)
        {
            if (dgv_Factory.SelectedRows.Count < 1)
            {
                MessageBox.Show("수정할 행을 선택해 주십시오.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string factoryCode = (dgv_Factory.SelectedRows[0].Cells[3].Value).ToString();
            FactoryVO factoryInfo = list.Find((elem) => elem.factory_code == factoryCode);


            frmFactoryIns frm = new frmFactoryIns(factoryInfo);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        
        //공장 삭제
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv_Factory.SelectedRows.Count < 1)
            {
                MessageBox.Show("삭제할 행을 선택해 주십시오.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string factoryCode = (dgv_Factory.SelectedRows[0].Cells[4].Value).ToString();
            FactoryVO factoryInfo = list.Find((elem) => elem.factory_code == factoryCode);

            if (MessageBox.Show("삭제 하시겠습니까", "삭제 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FactoryService service = new FactoryService();
                bool result = service.DeleteFactory(factoryInfo.factory_id);

                if (result)
                {
                    MessageBox.Show("삭제 되었습니다.");
                    LoadData();
                }
                else
                    MessageBox.Show("처리중 오류가 발생했습니다.", "처리 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

    }
}
