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
    public partial class Fm_Main : Form
    {

        public static string quyenhan = null;
        bool sidebarExpand;
        public Fm_Main()
        {
            InitializeComponent();
            customizeDesing(); //(submnenu)

        }


        //__________________________________FORM CON____________________________________________________
        private Form currentFormChild;
        private void OpenFormChild(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_bodynhanvien.Controls.Add(childForm);
            panel_bodynhanvien.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void OpenFormChild1(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_cong.Controls.Add(childForm);
            panel_cong.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        //________________________________________________________________________________________________

        private void menu_bt_Click(object sender, EventArgs e)
        {
            timer_sidebar.Start();
        }
        private void customizeDesing()
        {
            panel_manage.Visible = false;
            panel_user.Visible = false;
        }
        private void hidesubMenu()
        {
            if (panel_manage.Visible == true)
                panel_manage.Visible = false;
            if (panel_user.Visible == true)
                panel_user.Visible = false;
        }
        private void showsubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hidesubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void bt_manage_Click_1(object sender, EventArgs e)
        {
            showsubMenu(panel_manage);
        }
        private void bt_user_Click(object sender, EventArgs e)
        {
            showsubMenu(panel_user);
        }
        //-------------------------------------------------------------
        private void timer_sidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    timer_sidebar.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    timer_sidebar.Stop();
                }
            }
        }
        //_____________________________FORM LOAD________________________________________________________

        private void Fm_Main_Load(object sender, EventArgs e)
        {      
            Load_GridView_KL();
            txt_manvKL.ReadOnly = true;
            txt_maKL.ReadOnly = true;

            Load_Data_GridView_KT();
            txt_MaNVKT.ReadOnly = true;
            txt_MaKT.ReadOnly = true;

            Load_Data_GridView_PB1();
            txt_mapb.ReadOnly = true;

            Load_Data_GridView_CV();
            txt_macv.ReadOnly = true;

        

        }

        //________________________________________________________________________________

        private void bt_dangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fm_Login fm = new Fm_Login();
            fm.Show();
           
            
        }

        private void bt_info_Click(object sender, EventArgs e)
        {
            page.SetPage("Thông tin");
        }

        private void bt_taotaikhoan_Click(object sender, EventArgs e)
        {
            page.SetPage("Tạo TK");
        }

        private void bt_nhanvien_Click(object sender, EventArgs e)
        {
            page.SetPage("Nhân viên");
            OpenFormChild(new Fm_infoNhanVien());
        }

        private void bt_phongban_Click(object sender, EventArgs e)
        {
            page.SetPage("Phòng ban");
        }
        private void bt_chucvu_Click(object sender, EventArgs e)
        {
            page.SetPage("Chức vụ");
        }

        private void bt_chamcong_Click(object sender, EventArgs e)
        {
            page.SetPage("Chấm công");
            OpenFormChild1(new Fm_KyCong());
        }

        private void bt_salary_Click(object sender, EventArgs e)
        {
            page.SetPage("Lương");
        }

        private void bt_bonus_Click(object sender, EventArgs e)
        {
            page.SetPage("Thưởng");
        }

        private void bt_kyluat_Click(object sender, EventArgs e)
        {
            page.SetPage("Kỷ luật");
        }

        private void bt_doimatkhau_Click(object sender, EventArgs e)
        {
            page.SetPage("Đổi mật khẩu");
        }

        //______________________________KHEN THƯỞNG___________________________________________
        private void bt_addkt_Click(object sender, EventArgs e)
        {
            BonusDTO kt = new BonusDTO();
            kt.MaKT = "KT" + BonusBLL.BN_Count().ToString("00");
            kt.NgayKhenThuong = DateTime.Parse(datepickerKT.Value.ToString("dd/MM/yyyy"));
            kt.MaNV = cbb_tennv.SelectedValue.ToString();
            kt.TenNV = cbb_tennv.Text;
            kt.NoiDungKT = txt_noidungKT.Text;
            kt.HinhThuc = txt_hinhthuckt.Text;
            kt.TienThuong = int.Parse(txt_tienthuong.Text);
            kt.TrangThai = cbb_trangthaikt.Text;

            bool result = BonusBLL.BN_Add(kt);
            if (result)
            {
                MessageBox.Show("Thêm quyết định mới thành công");
            }
            else MessageBox.Show("Thêm quyết định mới không thành công");
            Load_Data_GridView_KT();
        }

        private void bt_editkt_Click(object sender, EventArgs e)
        {
            string makt = txt_MaKT.Text;
            DateTime ngay = DateTime.Parse(datepickerKT.Value.ToString("dd/MM/yyyy"));
            string manv = txt_MaNVKT.Text;
            string tennv = cbb_tenKL.SelectedValue.ToString();
            string noidungkt = txt_noidungKT.Text;
            string hinhthuc = txt_hinhthuckt.Text;
            int tienkt = Convert.ToInt32(txt_tienthuong.Text);
            string trangthai = cbb_trangthaikt.Text;
            bool result = BonusBLL.BN_Update(makt, ngay, manv, tennv, noidungkt, hinhthuc, tienkt, trangthai);
            if (result)
            {
                MessageBox.Show("Sửa quyết định thành công");
            }
            else MessageBox.Show("Sửa quyết định không thành công");
            Load_Data_GridView_KT();
        }
        
        private void Load_Data_GridView_KT()
        {
            List<BonusDTO> listkt = BonusBLL.BN_GetAll();
            gridview_bonus.DataSource = listkt;


            using (QLNVEntities db = new QLNVEntities())
            {
                nhanVienBindingSource.DataSource = db.NhanViens.ToList();
                AutoCompleteStringCollection ac = new AutoCompleteStringCollection();

                foreach (NhanVien nv in nhanVienBindingSource.DataSource as List<NhanVien>)
                {
                        ac.Add(nv.MaNV);
                }
                txt_MaNVKT.AutoCompleteCustomSource = ac;
            }
          
            List<NhanVienDTO> listnv = NhanVienBLL.EF_GetAll();
            //Khenthuong
            cbb_tennv.DataSource = listnv;
            cbb_tennv.DisplayMember = "TenNV";
            cbb_tennv.ValueMember = "MaNV";
        }

        private void gridview_bonus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = gridview_bonus.CurrentRow.Index;
            txt_MaKT.Text = gridview_bonus.Rows[i].Cells[0].Value.ToString().Trim();
            datepickerKT.Value = DateTime.Parse(gridview_bonus.Rows[i].Cells[1].Value.ToString());
            txt_MaNVKT.Text = gridview_bonus.Rows[i].Cells[2].Value.ToString().Trim();
            cbb_tennv.Text = gridview_bonus.Rows[i].Cells[3].Value.ToString().Trim();
            txt_noidungKT.Text = gridview_bonus.Rows[i].Cells[4].Value.ToString().Trim();
            txt_hinhthuckt.Text = gridview_bonus.Rows[i].Cells[5].Value.ToString().Trim();
            txt_tienthuong.Text = gridview_bonus.Rows[i].Cells[6].Value.ToString().Trim();
            cbb_trangthaikt.Text = gridview_bonus.Rows[i].Cells[7].Value.ToString().Trim();
        }

        private void txt_searchName_TextChange(object sender, EventArgs e)
        {
            try
            {
                gridview_bonus.DataSource = BonusBLL.BN_GetAllStaffByName(txt_searchName.Text);
                gridview_bonus.Columns[0].HeaderText = "Mã khen thưởng";
                gridview_bonus.Columns[1].HeaderText = "Ngày khen thưởng";
                gridview_bonus.Columns[2].HeaderText = "Mã nhân viên";
                gridview_bonus.Columns[3].HeaderText = "Tên nhân viên";
                gridview_bonus.Columns[4].HeaderText = "Nội dung";
                gridview_bonus.Columns[5].HeaderText = "Hình thức";
                gridview_bonus.Columns[6].HeaderText = "Tiền thưởng";
                gridview_bonus.Columns[7].HeaderText = "Trạng thái";
            }
            catch (Exception) { }
        }
        private void bt_deletekt_Click(object sender, EventArgs e)
        {

            //string ma = txt_manv.Text;
            //if (BonusBLL.Delete(ma))
            //{
            //    MessageBox.Show("Xóa thành công");
            //    Load_Data_GridView_KT();
            //}
            //else
            //{
            //    MessageBox.Show("Không thể xóa");
            //}
        }
        //________________________________KỶ LUẬT________________________________________

        private void bt_addKL_Click(object sender, EventArgs e)
        {
            KyLuatDTO kl = new KyLuatDTO();
            kl.MaKL = "KL" + KyLuatBLL.KL_Count().ToString("00");
            kl.MaNV = cbb_tenKL.SelectedValue.ToString();
            kl.TenNV = cbb_tenKL.Text;
            kl.NgayKyLuat = DateTime.Parse(datepickerKT.Value.ToString("dd/MM/yyyy"));
            kl.NoiDungKL = txt_noidungKL.Text;
            kl.HinhThuc = txt_hinhthucKL.Text;
            kl.TienKL = int.Parse(txt_mucKL.Text);
            kl.TrangThai = txt_trangthaiKL.Text;

            bool result = KyLuatBLL.KL_AddNew(kl);
            if (result)
            {
                MessageBox.Show("Thêm quyết định mới thành công");
            }
            else MessageBox.Show("Thêm quyết định mới không thành công");
            Load_GridView_KL();
        }
        private void bt_editKL_Click(object sender, EventArgs e)
        {
            string makl = txt_maKL.Text;
            string manvkl = txt_manvKL.Text;
            string tennvkl = cbb_tenKL.Text;
            DateTime ngay = DateTime.Parse(datepicker_KL.Value.ToString("dd/MM/yyyy"));
            string noidungkl = txt_noidungKL.Text;
            string hinhthuckl = txt_hinhthucKL.Text;
            int tienkl = Convert.ToInt32(txt_mucKL.Text);
            string trangthai = txt_trangthaiKL.Text;
            bool result = KyLuatBLL.KL_Edit(makl, ngay, manvkl, tennvkl,  noidungkl, hinhthuckl, tienkl, trangthai);
            if (result)
            {
                MessageBox.Show("Sửa quyết định thành công");
            }
            else MessageBox.Show("Sửa quyết định không thành công");
            Load_GridView_KL();
        }
        private void gridview_KyLuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n;
            n = gridview_KyLuat.CurrentRow.Index;
            txt_maKL.Text = gridview_KyLuat.Rows[n].Cells[0].Value.ToString().Trim();
            datepicker_KL.Value = DateTime.Parse(gridview_KyLuat.Rows[n].Cells[1].Value.ToString());
            txt_manvKL.Text = gridview_KyLuat.Rows[n].Cells[2].Value.ToString().Trim();
            cbb_tenKL.Text = gridview_KyLuat.Rows[n].Cells[3].Value.ToString().Trim();
            txt_noidungKL.Text = gridview_KyLuat.Rows[n].Cells[4].Value.ToString().Trim();
            txt_hinhthucKL.Text = gridview_KyLuat.Rows[n].Cells[5].Value.ToString().Trim();
            txt_mucKL.Text = gridview_KyLuat.Rows[n].Cells[6].Value.ToString().Trim();
            txt_trangthaiKL.Text = gridview_KyLuat.Rows[n].Cells[7].Value.ToString().Trim();
        }
        private void Load_GridView_KL()
        {
            List<KyLuatDTO> listkl = KyLuatBLL.KL_GetAll();
            gridview_KyLuat.DataSource = listkl;

            using (QLNVEntities data = new QLNVEntities())
            {
                nhanVienBindingSource.DataSource = data.NhanViens.ToList();
                AutoCompleteStringCollection bc = new AutoCompleteStringCollection();

                foreach (NhanVien st in nhanVienBindingSource.DataSource as List<NhanVien>)
                {
                    bc.Add(st.MaNV);
                }
                txt_manvKL.AutoCompleteCustomSource = bc;
            }
            List<NhanVienDTO> listnv = NhanVienBLL.EF_GetAll();
            cbb_tenKL.DataSource = listnv;
            cbb_tenKL.DisplayMember = "TenNV";
            cbb_tenKL.ValueMember = "MaNV";
        }
        private void bunifuTextBox2_TextChange_1(object sender, EventArgs e)
        {
            try
            {
                gridview_KyLuat.DataSource = KyLuatBLL.KL_GetAllStaffByName(bunifuTextBox2.Text);
                gridview_KyLuat.Columns[0].HeaderText = "Mã kỷ luật";
                gridview_KyLuat.Columns[1].HeaderText = "Ngày kỷ luật";
                gridview_KyLuat.Columns[2].HeaderText = "Mã nhân viên";
                gridview_KyLuat.Columns[3].HeaderText = "Tên nhân viên";
                gridview_KyLuat.Columns[4].HeaderText = "Nội dung";
                gridview_KyLuat.Columns[5].HeaderText = "Hình thức";
                gridview_KyLuat.Columns[6].HeaderText = "Tiền kỷ luật";
                gridview_KyLuat.Columns[7].HeaderText = "Trạng thái";
            }
            catch (Exception) { }
        }
        //______________________________PHÂN QUYỀN___________________________________________
        //private void PhanQuyen(string quyen)
        //{
        //    if (quyen == "Nhân Viên")
        //    {
        //        bt_taotaikhoan.Enabled = false;
        //        bt_phongban.Enabled = false;
        //        bt_chamcong.Enabled = false;
        //        bt_chucvu.Enabled = false;
        //        bt_bonus.Enabled = false;
        //        bt_kyluat.Enabled = false;
        //        bt_salary.Enabled = false;
        //    }
        //    if (quyen == "Phó Trưởng Phòng")
        //    {
        //        bt_taotaikhoan.Enabled = false;
        //        bt_salary.Enabled = false;
        //    }
        //    if (quyen == "Trưởng Phòng")
        //    {
        //        bt_taotaikhoan.Enabled = true;
        //        bt_phongban.Enabled = true;
        //        bt_chamcong.Enabled = true;
        //        bt_chucvu.Enabled = true;
        //        bt_bonus.Enabled = true;
        //        bt_kyluat.Enabled = true;
        //        bt_salary.Enabled = true;
        //    }
        //}

        //____________________________________PHÒNG BAN______________________________________________
        List<PhongBanDTO> listPhongban = new List<PhongBanDTO>();
        private void Load_Data_GridView_PB1()
        {
            List<PhongBanDTO> listpb = PhongBanBLL.EF_GetAllActive();
            gridview_phongban.DataSource = listpb;
        }
        private void Load_Data_GridView_PB2()
        {
            List<PhongBanDTO> listpb = PhongBanBLL.EF_GetAll();
            gridview_phongban.DataSource = listpb;
        }

        private void bt_xoapb_Click(object sender, EventArgs e)
        {
            string ma = txt_mapb.Text;
            if (PhongBanBLL.Delete(ma))
            {
                MessageBox.Show("Xóa thành công"); 
                Load_Data_GridView_PB1();
            }
            else
            {
                MessageBox.Show("Không thể xóa");
            }
        }

        private void bt_themPB_Click(object sender, EventArgs e)
        {
            PhongBanDTO sp = new PhongBanDTO();
            sp.TenPB = txt_tenpb.Text;
            sp.Matrphong = txt_matrphong.Text.Trim();
            sp.NgayNhamChuc = datepicker_PB.Value;
            sp.TrangThai = cbb_trangthaiPB.SelectedItem.ToString();
            sp.MaPB = "PB" + PhongBanBLL.EF_Count().ToString("00");
            if (PhongBanBLL.EF_Add(sp))
            {
                MessageBox.Show("Thêm phòng ban thành công!");
                Load_Data_GridView_PB1();
            }
            else
            {
                MessageBox.Show("Không thể thêm phòng ban!");
            }
            Load_Data_GridView_PB1();
        }

        private void bt_suaPB_Click(object sender, EventArgs e)
        {
            PhongBanDTO sp = new PhongBanDTO();
            sp.TenPB = txt_tenpb.Text;
            sp.Matrphong = txt_matrphong.Text.Trim();
            sp.NgayNhamChuc = datepicker_PB.Value;
            sp.MaPB = txt_mapb.Text;
            if (PhongBanBLL.EF_Update(sp))
            {
                MessageBox.Show("Sửa thông tin phòng ban thành công ");
                Load_Data_GridView_PB1();
            }
            else
            {
                MessageBox.Show("Không thể thay đổi thông tin ");
            }
            Load_Data_GridView_PB1();
        }

        private void bt_hienthitatcapb_Click(object sender, EventArgs e)
        {
            Load_Data_GridView_PB2();
        }

        private void gridview_phongban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridview_phongban.Rows[e.RowIndex];
                txt_mapb.Text = row.Cells[0].Value.ToString();
                txt_tenpb.Text = row.Cells[1].Value.ToString();
                txt_matrphong.Text = row.Cells[2].Value.ToString();
                datepicker_PB.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                cbb_trangthaiPB.SelectedItem = row.Cells[4].Value.ToString();

                //comboBox1.Text = row.Cells[4].Value.ToString();
            }
        }

        //____________________________________CHỨC VỤ______________________________________________
        private void bt_themcv_Click(object sender, EventArgs e)
        {
            ChucVuDTO sp = new ChucVuDTO();
            sp.MaCV = "CV" + ChucVuBLL.CV_Count().ToString("00");
            sp.TenCV = txt_tencv.Text;
            if (ChucVuBLL.CV_Add(sp))
            {
                MessageBox.Show("Thêm chức vụ thành công ");
                Load_Data_GridView_CV();
            }
            else
            {
                MessageBox.Show("Không thể thêm chức vụ");
            }
            Load_Data_GridView_CV();
        }

        private void Load_Data_GridView_CV()
        {
            List<ChucVuDTO> listcv = ChucVuBLL.CV_GetAll();
            gridview_CV.DataSource = listcv;
        }

        private void gridview_CV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridview_CV.Rows[e.RowIndex];
                txt_macv.Text = row.Cells[0].Value.ToString();
                txt_tencv.Text = row.Cells[1].Value.ToString();
            }
        }

        private void bunifuGroupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void bt_baocaocong_Click(object sender, EventArgs e)
        {
            Fm_ReportBangCong frm = new Fm_ReportBangCong();
            frm.ShowDialog();
        }

       
        //_______________________________________________________________________
       

       
    }
}
