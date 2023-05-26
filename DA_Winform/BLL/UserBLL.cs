using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA_Winform.DAL;
using DA_Winform.DTO;

namespace DA_Winform
{
    internal class UserBLL
    {
        public static bool DangNhap(string tk, string mk)
        {
            return UserDAL.DangNhap(tk, mk);
        }
        public static string MaHoa(string password)
        {
            return UserDAL.MaHoa(password);
        }

        public static bool AddTaiKhoan(UserDTO dto)
        {
            return UserDAL.AddTaiKhoan(dto);
        }
        public static bool DoiMatKhau(string manv, string mk)
        {
            return UserDAL.DoiMatKhau(manv, mk);
        }
        public static bool NVCoTK(string tk)
        {
            return UserDAL.NVCoTK(tk);
        }
        public static NhanVienDTO KiemTra(string ten, string cmnd)
        {
            return UserDAL.KiemTra(ten, cmnd);
        }
    }
}
