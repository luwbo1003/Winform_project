using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DA_Winform.BLL;

namespace DA_Winform
{
    public partial class Fm_Login : Form
    {
        public string _makycong;
        public string _ngay;
        public string tk;

        public Fm_Login()
        {
            InitializeComponent();
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fm_Login_Load(object sender, EventArgs e)
        {
            txt_matkhau.PasswordChar = '*';
        }
        public int a;
        public bool b = false;
        private void Fm_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (b == true && a != null)
            {
                System.Diagnostics.Process.GetProcessById(a).Kill();
                b = false;
            } 
        }

        private void bt_signin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_tentaikhoan.Text))
            {
                if (!string.IsNullOrEmpty(txt_matkhau.Text))
                {
                    string tk = txt_tentaikhoan.Text.Trim();
                    string mk = txt_matkhau.Text.Trim();
                    bool result = UserBLL.DangNhap(tk, mk);
                    if (result)
                    {
                        Fm_Main fm_main = new Fm_Main();
                        fm_main.Show();
                        this.Hide();

                        // 

                        //_makycong = (DateTime.Now.Year * 100 + DateTime.Now.Month).ToString();
                        //_ngay = DateTime.Now.Day.ToString();
                        //int _tongngayphep = BangCongChiTietBLL.Tongngayphep(_makycong, tk);
                        //bool result1 = KyCongChiTietBLL.EF_UpdateDiemDanh(_ngay, _makycong, tk);
                        //bool result2 = BangCongChiTietBLL.EF_UpdateDiemDanh(_makycong, tk, int.Parse(_ngay));
                        //if (result2 & result1)
                        //{
                        //    MessageBox.Show("Điểm danh thành công");
                        //    _tongngayphep = _tongngayphep - 1;
                        //    KyCongChiTietBLL.EF_UpdateNgayPhep(_makycong, tk, _tongngayphep, _tongngayphep);
                        //}
                    }
                    else
                    {
                        MessageBox.Show("Lỗi!! Sai tài khoản hoặc mật khẩu");
                        txt_tentaikhoan.Clear();
                        txt_matkhau.Clear();
                        txt_tentaikhoan.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi!! nhập mật khẩu");
                    txt_matkhau.Focus();
                }
            }
            else
            {
                MessageBox.Show("Lỗi!! Nhập tài khoản của bạn");
                txt_tentaikhoan.Focus();
            }
        }

        private void Fm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát chương trình", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.Cancel)
                e.Cancel = true;
        }
    }
}
