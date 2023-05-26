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
    public partial class Fm_infoNhanVien : Form
    {
        int i;
        List<NhanVienDTO> listnv;
        List<PhongBanDTO> listpb;
        List<ChucVuDTO> listcv;
        List<string> manv = new List<string>();
        List<string> tennv = new List<string>();
        List<string> diachi = new List<string>();
        List<string> gioitinh = new List<string>();
        List<string> sdt = new List<string>();
        List<string> cccd = new List<string>();
        public Fm_infoNhanVien()
        {
            InitializeComponent();
            dataGridView_NV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_NV.ReadOnly = true;
            txt_manv.ReadOnly = true;
        }
       
        public void Load_Data_Gridview()
        {
            List<NhanVienDTO> listnv = NhanVienBLL.EF_GetAll();
            dataGridView_NV.DataSource = listnv;
        }

        private void Fm_infoNhanVien_Load(object sender, EventArgs e)
        {
            
            Load_Data_Gridview();

            listpb = PhongBanBLL.EF_GetAll();
            cbb_phongban.DataSource = listpb;
            cbb_phongban.DisplayMember = "TenPB";
            cbb_phongban.ValueMember = "MaPB";

            listcv = ChucVuBLL.CV_GetAll();
            cbb_chucvu.DataSource = listcv;
            cbb_chucvu.DisplayMember = "TenCV";
            cbb_chucvu.ValueMember = "MaCV";

            
            List<NhanVienDTO> listTK = NhanVienBLL.EF_GetAll();
          

            foreach (NhanVienDTO nv in listTK)
            {
                manv.Add(nv.MaNV);
                tennv.Add(nv.TenNV);
                diachi.Add(nv.DiaChi);
                gioitinh.Add(nv.GioiTinh);
                sdt.Add(nv.DienThoai);
                cccd.Add(nv.CCCD);
            }

          


            Load_Data_Gridview1();
            cbb_tt.Text = null;
        }

        private void bt_suanv_Click(object sender, EventArgs e)
        {
            string manv = txt_manv.Text;
            string tennv = txt_tennhanvien.Text;
            DateTime ngaysinh = DateTime.Parse(datepicker_ngaysinh.Value.ToString("dd/MM/yyyy"));
            string gioitinh = "";
            if (rad_male.Checked == true) { gioitinh = "Nam"; }
            if (rad_female.Checked == true) { gioitinh = "Nữ"; }
            string diachi = txt_diachi.Text;
            string sdt = txt_sodienthoai.Text;
            string cccd = txt_cccd.Text;
            string mapb = cbb_phongban.SelectedValue.ToString();
            string macv = cbb_chucvu.SelectedValue.ToString();
            float maluong = float.Parse(txt_maluong.Text);
            string trangthai = cbb_trangthai.Text;
            bool result = NhanVienBLL.EF_Update(manv, tennv, ngaysinh, gioitinh, diachi, sdt, cccd, mapb, macv, maluong, trangthai);
            if (result)
            {
                MessageBox.Show("Sửa thông tin nhân viên thành công");
            }
            else MessageBox.Show("Sửa thông tin nhân viên không thành công");
            Load_Data_Gridview();
        }

        public static void autocomp(TextBox a, List<string> b)
        {
            AutoCompleteStringCollection allowedTypes = new AutoCompleteStringCollection();

            foreach (string nvv in b)
            {
                allowedTypes.Add(nvv);
            }
            a.AutoCompleteMode = AutoCompleteMode.Suggest;
            a.AutoCompleteSource = AutoCompleteSource.CustomSource;
            a.AutoCompleteCustomSource = allowedTypes;
        }

        private void bt_xoanv_Click(object sender, EventArgs e)
        {
            string manv = txt_manv.Text;
            bool result = NhanVienBLL.EF_Delete(manv);
            if (result)
            {
                MessageBox.Show("Xóa nhân viên thành công");
            }
            else MessageBox.Show("Xóa nhân viên không thành công");
            Load_Data_Gridview();
        }

        private void bt_themnv_Click(object sender, EventArgs e)
        {
            NhanVienDTO _nv = new NhanVienDTO();
            _nv.MaNV = "NV" + NhanVienBLL.EF_Count().ToString("00");
            _nv.TenNV = txt_tennhanvien.Text;
            _nv.NgaySinh = datepicker_ngaysinh.Value;
            if (rad_male.Checked == true) { _nv.GioiTinh = rad_male.Text; }
            if (rad_female.Checked == true) { _nv.GioiTinh = rad_female.Text; }
            _nv.DiaChi = txt_diachi.Text;
            _nv.DienThoai = txt_sodienthoai.Text;
            _nv.CCCD = txt_cccd.Text;
            _nv.MaPB = cbb_phongban.SelectedValue.ToString();
            _nv.MaCV = cbb_chucvu.SelectedValue.ToString();
            _nv.MaLuong = float.Parse(txt_maluong.Text);
            _nv.TrangThai = "đang công tác";
            bool result = NhanVienBLL.EF_Add(_nv);
            if (result)
            {
                MessageBox.Show("Thêm nhân viên mới thành công");
            }
            else MessageBox.Show("Nhân viên đã tồn tại");
            Load_Data_Gridview();
        }

        private void dataGridView_NV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView_NV.Rows[e.RowIndex];
                txt_manv.Text = row.Cells[0].Value.ToString();
                txt_tennhanvien.Text = row.Cells[1].Value.ToString();
                datepicker_ngaysinh.Value = DateTime.Parse(row.Cells[2].Value.ToString());
                if (row.Cells[3].Value.ToString() == "Nữ") { rad_female.Checked = true; rad_male.Checked = false; }
                if (row.Cells[3].Value.ToString() == "Nam") { rad_male.Checked = true; rad_female.Checked = false; }
                txt_diachi.Text = row.Cells[4].Value.ToString();
                txt_sodienthoai.Text = row.Cells[5].Value.ToString();
                txt_cccd.Text = row.Cells[6].Value.ToString();
                foreach (PhongBanDTO item in listpb)
                {
                    if (item.MaPB == row.Cells[7].Value.ToString())
                    {
                        cbb_phongban.Text = item.TenPB;
                    }
                }
                foreach (ChucVuDTO item in listcv)
                {
                    if (item.MaCV == row.Cells[8].Value.ToString())
                    {
                        cbb_chucvu.Text = item.TenCV;
                    }
                }
                txt_maluong.Text = row.Cells[9].Value.ToString();
                cbb_trangthai.Text = row.Cells[10].Value.ToString();
            }
        }

        public void Load_Data_Gridview1()
        {
            List<NhanVienDTO> listnv = NhanVienBLL.EF_GetAll();
            dataGridView_NV.DataSource = listnv;
        }
        private void bt_timnv_Click(object sender, EventArgs e)
        {
            if (cbb_ChucNang.SelectedIndex == 0 || cbb_ChucNang.SelectedIndex == 1 || cbb_ChucNang.SelectedIndex == 2 ||
                cbb_ChucNang.SelectedIndex == 4 || cbb_ChucNang.SelectedIndex == 5)
            {
                dataGridView_NV.DataSource = null;
                dataGridView_NV.DataBindings.Clear();
                dataGridView_NV.Refresh();
                string manv = textBox1.Text;
                string tennv = textBox1.Text;
                string sdt = textBox1.Text;
                string cc = textBox1.Text;
                string dchi = textBox1.Text;
                string mapb = textBox1.Text;
                string macv = textBox1.Text;
                listnv = NhanVienBLL.EF_Find(manv, tennv, sdt, cc, dchi, mapb, macv);
                dataGridView_NV.DataSource = listnv;
            }
            else if (cbb_ChucNang.SelectedIndex == 6 ||
                cbb_ChucNang.SelectedIndex == 7)
            {
                dataGridView_NV.DataSource = null;
                dataGridView_NV.DataBindings.Clear();
                dataGridView_NV.Refresh();
                string manv = "";
                string ten = "";
                string sdt = "";
                string cc = "";
                string dchi = "";
                string mapb = cbb_tt.SelectedValue.ToString();
                string macv = cbb_tt.SelectedValue.ToString();
                listnv = NhanVienBLL.EF_Find(manv, ten, sdt, cc, dchi, mapb, macv);
                dataGridView_NV.DataSource = listnv;
            }
            else if (cbb_ChucNang.SelectedIndex == 3)
            {
                dataGridView_NV.DataSource = null;
                dataGridView_NV.DataBindings.Clear();
                dataGridView_NV.Refresh();
                string gtinh = cbb_tt.Text;
                if (cbb_tt.SelectedIndex == 0) { listnv = NhanVienBLL.EF_FindBoy(gtinh); }
                if (cbb_tt.SelectedIndex == 1) { listnv = NhanVienBLL.EF_FindGirl(gtinh); }
                dataGridView_NV.DataSource = listnv;
            }
            else if (cbb_ChucNang.SelectedIndex == 8)
            {
                dataGridView_NV.DataSource = null;
                dataGridView_NV.DataBindings.Clear();
                dataGridView_NV.Refresh();
                string tt = cbb_tt.Text;
                if (cbb_tt.SelectedIndex == 0) { listnv = NhanVienBLL.EF_TrangThai1(tt); }
                if (cbb_tt.SelectedIndex == 1) { listnv = NhanVienBLL.EF_TrangThai2(tt); }
                dataGridView_NV.DataSource = listnv;
            }
        }
        private void cbb_chontt_SelectedIndexChanged(object sender, EventArgs e)
        {
            i = cbb_ChucNang.SelectedIndex;
            if (i == 0)
            {
                cbb_tt.Hide();
                textBox1.Show();
                //Autocomplete Mã NV
                autocomp(textBox1, manv);
                
            }
            else if (i == 1)
            {
                cbb_tt.Hide();
                textBox1.Show();
                //Autocomplete Họ tên NV               
                autocomp(textBox1, tennv);
            }
            else if (i == 2)
            {
                cbb_tt.Hide();
                textBox1.Show();
                //Autocomplete Địa chỉ
                autocomp(textBox1, diachi);
            }
            else if (i == 3)
            {
                cbb_tt.Show();
                textBox1.Hide();
                cbb_tt.DataSource = null;
                cbb_tt.Items.Clear();
                cbb_tt.Items.Add("Nam");
                cbb_tt.Items.Add("Nữ");
                //Autocomplete Giới tính
                autocomp(textBox1, gioitinh);
            }
            else if (i == 4)
            {
                cbb_tt.Hide();
                textBox1.Show();
                //Autocomplete SDT
                autocomp(textBox1, sdt);
            }
            else if (i == 5)
            {
                cbb_tt.Hide();
                textBox1.Show();
                //Autocomplete CCCD
                autocomp(textBox1, cccd);
            }
            else if (i == 6)
            {
                List<PhongBanDTO> listpb = PhongBanBLL.EF_GetAll();
                cbb_tt.DataSource = null;
                cbb_tt.DataSource = listpb;
                cbb_tt.DisplayMember = "TenPB";
                cbb_tt.ValueMember = "MaPB";
                cbb_tt.Show();
                textBox1.Hide();
                //Autocomplete Phòng ban
                using (QLNVEntities db = new QLNVEntities())
                {
                    phongBanBindingSource.DataSource = db.PhongBans.ToList();
                    AutoCompleteStringCollection ac = new AutoCompleteStringCollection();

                    foreach (PhongBan pb in phongBanBindingSource.DataSource as List<PhongBan>)
                        ac.Add(pb.TenPB);
                    textBox1.AutoCompleteCustomSource = ac;
                }
            }
            else if (i == 7)
            {
                List<ChucVuDTO> listcv = ChucVuBLL.CV_GetAll();
                cbb_tt.DataSource = null;
                cbb_tt.DataSource = listcv;
                cbb_tt.DisplayMember = "TenCV";
                cbb_tt.ValueMember = "MaCV";
                cbb_tt.Show();
                textBox1.Hide();
                //Autocomplete Chức vụ
                using (QLNVEntities db = new QLNVEntities())
                {
                    chucVuBindingSource.DataSource = db.ChucVus.ToList();
                    AutoCompleteStringCollection ac = new AutoCompleteStringCollection();

                    foreach (ChucVu pb in chucVuBindingSource.DataSource as List<ChucVu>)
                        ac.Add(pb.TenCV);
                    textBox1.AutoCompleteCustomSource = ac;
                }
            }
            else if (i == 8)
            {
                cbb_tt.DataSource = null;
                cbb_tt.Show();
                textBox1.Hide();
                cbb_tt.Items.Clear();
                cbb_tt.Items.Add("Đang công tác");
                cbb_tt.Items.Add("Đã nghỉ việc");
                //Autocomplete Trạng thái
                using (QLNVEntities db = new QLNVEntities())
                {
                    nhanVienBindingSource.DataSource = db.NhanViens.ToList();
                    AutoCompleteStringCollection ac = new AutoCompleteStringCollection();

                    foreach (NhanVien nv in nhanVienBindingSource.DataSource as List<NhanVien>)
                        ac.Add(nv.TrangThai);
                    textBox1.AutoCompleteCustomSource = ac;
                }
            }
        }

        private void cbb_tt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
