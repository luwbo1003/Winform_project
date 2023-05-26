using DA_Winform.BLL;
using DA_Winform.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_Winform
{
    public partial class Fm_KyCong : Form
    {
        public string _makycong;
        public Fm_KyCong()
        {
            InitializeComponent();
        }
        public void Load_Data_Gridview_KC()
        {
            List<KyCongDTO> listkq = KyCongBLL.KC_GetAll();
            gridview_KC.DataSource = listkq;
        }

        private void Fm_KyCong_Load(object sender, EventArgs e)
        {
            Load_Data_Gridview_KC();
        }

        private void bt_themkycong_Click(object sender, EventArgs e)
        {
            KyCongDTO kc = new KyCongDTO();
            kc.MaKC = (int.Parse(cbb_namKC.SelectedItem.ToString()) * 100 + int.Parse(cbb_thangKC.SelectedItem.ToString())).ToString();
            kc.nam = int.Parse(cbb_namKC.SelectedItem.ToString());
            kc.thang = int.Parse(cbb_thangKC.SelectedItem.ToString());
            kc.trangthai = false;
            kc.ngaytinhcong = DateTime.Now;
            kc.ngaycongtrongthang = KyCongBLL.demngaycongtrongthang(int.Parse(cbb_thangKC.SelectedItem.ToString()), int.Parse(cbb_namKC.SelectedItem.ToString()));
            bool result = KyCongBLL.KC_Add(kc);
            if (result)
            {
                MessageBox.Show("Thành công!");
            }
            else { MessageBox.Show("Thất bại!"); }
            Load_Data_Gridview_KC();
        }

        private void bt_xemcongchitiet_Click(object sender, EventArgs e)
        {
            int i;
            i = gridview_KC.CurrentRow.Index;
            Fm_KyCongChiTiet frm = new Fm_KyCongChiTiet();
            frm._makycong = _makycong;
            frm._nam = int.Parse(cbb_namKC.Text);
            frm._thang = int.Parse(cbb_thangKC.Text);
            frm._trangthai = bool.Parse(gridview_KC.Rows[i].Cells[5].Value.ToString().Trim());
            frm.ShowDialog();
        }

        private void gridview_KC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = gridview_KC.CurrentRow.Index;
            _makycong = gridview_KC.Rows[i].Cells[0].Value.ToString().Trim();
            cbb_namKC.Text = gridview_KC.Rows[i].Cells[1].Value.ToString().Trim();
            cbb_thangKC.Text = gridview_KC.Rows[i].Cells[2].Value.ToString().Trim();
        }

        private void bunifuGroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
