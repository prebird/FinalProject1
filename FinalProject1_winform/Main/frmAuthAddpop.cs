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

namespace FinalProject1_winform
{
    public partial class frmAuthAddpop : Form
    {
        MenuDAC db = new MenuDAC();
        DataTable dtMenuAuth;
        int sel_menu_id;

        public frmAuthAddpop()
        {
            InitializeComponent();
        }

        private void frmAuthAddpop_Load(object sender, EventArgs e)
        {
            MenuBinding(); //트리뷰 컨트롤에 메뉴 바인딩
            AuthBinding(); //리스트박스 컨트롤에 권한 바인딩
            MenuAuthBinding(); //메뉴별 권한정보를 데이터테이블에 저장

            lstSelect.Enabled = lstAll.Enabled = false;
        }

        private void MenuAuthBinding()
        {
            dtMenuAuth = db.GetMenuAuthList();
        }

        private void MenuBinding()
        {
            DataTable dtMenu = db.GetMenuList();
            DataView dv0 = new DataView(dtMenu);
            dv0.RowFilter = "MenuLevel = 1";
            dv0.Sort = "sortorder";
            for (int i = 0; i < dv0.Count; i++)
            {
                TreeNode node = new TreeNode(dv0[i]["MenuName"].ToString());
                node.Tag = $"{dv0[i]["MenuLevel"].ToString()}|{dv0[i]["MenuID"].ToString()}";
                treeView1.Nodes.Add(node);

                DataView dv1 = new DataView(dtMenu);
                dv1.RowFilter = "MenuLevel = 2 and refMenuID=" + dv0[i]["MenuID"].ToString();
                dv1.Sort = "menu_sort";
                for (int k = 0; k < dv1.Count; k++)
                {
                    TreeNode c_node = new TreeNode(dv1[k]["MenuName"].ToString());
                    c_node.Tag = $"{dv1[k]["MenuLevel"].ToString()}|{dv1[k]["MenuID"].ToString()}";
                    node.Nodes.Add(c_node);
                }
            }
            treeView1.ExpandAll();
        }

        private void AuthBinding()
        {
            DataTable dtAuth = db.GetAuthList();

            lstAll.Items.Clear();
            foreach (DataRow dr in dtAuth.Rows)
            {
                lstAll.Items.Add($"{dr["AuthID"].ToString()}|{dr["AuthName"].ToString()}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //이미 리스트박스에 있는 권한이 아니라면 추가
            foreach (var item in lstAll.SelectedItems)
            {
                if (lstSelect.Items.IndexOf(item.ToString()) < 0)
                {
                    lstSelect.Items.Add(item.ToString());
                }
            }

            for (int i = 0; i < lstAll.Items.Count; i++)
            {
                lstAll.SetSelected(i, false);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstSelect.Items.Remove(lstSelect.SelectedItem);
        }

        private void button_gudi1_Click(object sender, EventArgs e)
        {
            List<int> authList = new List<int>();
            foreach (var item in lstSelect.Items)
            {
                string[] temp = item.ToString().Split('|');
                if (temp.Length == 2)
                {
                    authList.Add(int.Parse(temp[0]));
                }
            }

            bool result = db.SaveMenuAuth(sel_menu_id, authList);
            if (result)
            {
                MessageBox.Show("저장 완료 되었습니다.");
                MenuAuthBinding();
                ClearBackColor();
                lstSelect.Items.Clear();
                lstSelect.Enabled = lstAll.Enabled = false;
            }
            else
                MessageBox.Show("다시 저장하여 주십시오.");
        }
    

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // $"{dv0[i]["menu_level"].ToString()}|{dv0[i]["menu_id"].ToString()}";
            TreeNode node = e.Node;
            string[] arrMenu = node.Tag.ToString().Split('|');
            if (arrMenu.Length != 2) return;

            if (arrMenu[0] == "1")
            {
                lstSelect.Items.Clear();
                lstSelect.Enabled = lstAll.Enabled = false;
            }
            else
            {
                node.BackColor = Color.Yellow;
                sel_menu_id = int.Parse(arrMenu[1]);

                //현재 메뉴권한 정보를 바인딩
                if (dtMenuAuth == null)
                    dtMenuAuth = db.GetMenuAuthList();

                DataTable dt = dtMenuAuth.Copy();
                DataRow[] rows = dt.Select("MenuID=" + arrMenu[1]);

                lstSelect.Items.Clear();
                foreach (DataRow dr in rows)
                {
                    lstSelect.Items.Add($"{dr["AuthID"].ToString()}|{dr["AuthName"].ToString()}");
                }

                lstSelect.Enabled = lstAll.Enabled = true;
            }
        }

        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            ClearBackColor();
        }

        private void ClearBackColor()
        {
            foreach (TreeNode n in treeView1.Nodes)
            {
                ClearRecursive(n);
            }
        }

        private void ClearRecursive(TreeNode node)
        {
            foreach (TreeNode n in node.Nodes)
            {
                n.BackColor = Color.White;
                ClearRecursive(n);
            }
        }
    }
}
