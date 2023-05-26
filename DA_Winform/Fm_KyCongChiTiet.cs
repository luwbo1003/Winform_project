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
    public partial class Fm_KyCongChiTiet : Form
    {
        KyCongChiTietBLL _kcct;
        public int _thang;
        public int _nam;
        public string _makycong;
        public bool _trangthai;
        public Fm_KyCongChiTiet()
        {
            InitializeComponent();
        }

        private void Fm_KyCongChiTiet_Load(object sender, EventArgs e)
        {
            _kcct = new KyCongChiTietBLL();
            int i;
            for (i = 0; i <= KyCongChiTietBLL.GetDayNumber(_thang, _nam); i++)
            {

            }
            while (i <= 31)
            {
                gridview_kcct.Columns[i + 2].Visible = false;
                i++;
            }

            txt_thangkcct.Text = _nam.ToString();
            txt_namkcct.Text = _thang.ToString();

            Load_Data_GridView_KCCT();
        }
        public void Load_Data_GridView_KCCT()
        {
            List<KyCongChiTietDTO> listb = KyCongChiTietBLL.EF_GetWith(_makycong.Trim());
            gridview_kcct.DataSource = listb;

        }

        private void bt_phatsinhkicong_Click(object sender, EventArgs e)
        {
            List<NhanVienDTO> listnv = NhanVienBLL.EF_GetAll();
            foreach (NhanVienDTO nv in listnv)
            {
                for (int i = 1; i <= KyCongChiTietBLL.GetDayNumber(_thang, _nam); i++)
                {
                    BangCongChiTietDTO bcct = new BangCongChiTietDTO();
                    bcct.ID = BangCongChiTietBLL.EF_Count();
                    bcct.MaNV = nv.MaNV;
                    bcct.MaKC = _makycong;
                    bcct.TenNV = nv.TenNV;
                    bcct.giovao = "8:00";
                    bcct.ngay = DateTime.Parse(_nam.ToString() + "-" + _thang.ToString() + "-" + i.ToString());
                    bcct.thu = KyCongChiTietBLL.laythutrongtuan(_nam, _thang, i);
                    bcct.ngayphep = 1;

                    if (bcct.thu == "Chủ nhật")
                    {
                        bcct.kyhieu = "CN";
                        bcct.ngayphep = 0;
                    }
                    else bcct.kyhieu = "P";
                    BangCongChiTietBLL.EF_Add(bcct);
                }
            }
            bool result = KyCongChiTietBLL.EF_UpdateTrangThai(_makycong);

            if (_trangthai)
            {
                MessageBox.Show("Kỳ công đã được phát sinh!");
            }
            else
            {
                _kcct.phatSinhKyCongChiTiet(_thang, _nam);
                MessageBox.Show("Phát sinh kỳ công thành công!");
            }
            Load_Data_GridView_KCCT();
        }

        private void gridview_kcct_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuGroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
