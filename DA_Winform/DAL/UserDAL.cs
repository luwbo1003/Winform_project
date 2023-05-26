using AutoMapper;
using DA_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DA_Winform
{
    internal class UserDAL
    {
        private byte[] key;
        private byte[] iv;
        public UserDAL()
        {
            //khóa 24 ký tự
            key = UnicodeEncoding.UTF8.GetBytes("19£@37qP*l46o$5y#hg%&z82");
            //khởi tạo initialization vector (IV) bằng 8 ký tự
            iv = UnicodeEncoding.UTF8.GetBytes("123#E*g@");
        }
        public UserDAL(string keya, string iva)
        {
            key = UnicodeEncoding.UTF8.GetBytes(keya);
            iv = UnicodeEncoding.UTF8.GetBytes(iva);
        }
        public static bool DangNhap(string tk, string mk)
        {
            //------------------Mã hóa----------------------
            string hashpass = MaHoa(mk);
            QLNVEntities data = new QLNVEntities();
            Taikhoan sp = data.Taikhoans.SingleOrDefault(p => p.TenDangNhap == tk.Trim() && p.MatKhau == hashpass.Trim());
            if (sp != null)
            {
                return true;
            }
            else
                return false;
            //    return data.SaveChanges() > 0 ? true : false;
        }
        public static string MaHoa(string password)
        {
            byte[] key = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] iv = new MD5CryptoServiceProvider().ComputeHash(key);
            string hashpass = "";
            foreach (byte item in iv)
            {
                hashpass += item;
            }
            return hashpass;
        }

        public static bool AddTaiKhoan(UserDTO dto)
        {
            //chuyển đổi tự động
            var config = new MapperConfiguration(cfg => cfg.CreateMap<UserDTO, Taikhoan>());
            var mapper = new Mapper(config);
            Taikhoan kl = mapper.Map<Taikhoan>(dto);
            QLNVEntities data = new QLNVEntities();
            if (KiemTraTK(dto))
            {
                data.Taikhoans.Add(kl);
                data.SaveChanges();
                return true;
            }
            else
                return false;
        }
        
        public static bool KiemTraTK(UserDTO dto)
        {
            QLNVEntities data = new QLNVEntities();
            Taikhoan tk = (from p in data.Taikhoans
                           where p.MaNV.Trim().ToLower() == dto.MaNV.Trim().ToLower() ||
                           p.TenDangNhap.Trim() == dto.TenDangNhap.Trim()
                           select p).DefaultIfEmpty().Single<Taikhoan>();
            return tk == null ? true : false;
        }

        public static bool DoiMatKhau(string manv, string mk)
        {
            QLNVEntities data = new QLNVEntities();
            Taikhoan sp = (from p in data.Taikhoans
                           where p.MaNV.ToLower().Trim() == manv
                           select p).DefaultIfEmpty().Single<Taikhoan>();
            if (sp != null) sp.MatKhau = mk;

            return data.SaveChanges() > 0 ? true : false;
        }

        /*public static bool NVCoTK(string tk)
        {
            QLNVENtities data = new QLNVENtities();
            Taikhoan sp = (from p in data.Taikhoans
                           where p.MaNV == tk.Trim()
                           select p).Single<Taikhoan>();

            sp.TenDangNhap = tk;

            return data.SaveChanges() > 0 ? true : false;
        }*/
        public static bool NVCoTK(string tk)
        {
            QLNVEntities data = new QLNVEntities();
            Taikhoan sp = (from p in data.Taikhoans
                           where p.MaNV == tk.Trim()
                           select p).DefaultIfEmpty().Single<Taikhoan>();

            return sp != null ? true : false;

        }
        public static NhanVienDTO KiemTra(string ten, string cmnd)
        {
            QLNVEntities data = new QLNVEntities();
            NhanVien nv = (from p in data.NhanViens
                           where p.TenNV.Trim().ToLower() == ten & p.CCCD.Trim() == cmnd
                           select p).DefaultIfEmpty().Single<NhanVien>();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<NhanVien, NhanVienDTO>());
            var mapper = new Mapper(config); NhanVienDTO dto = mapper.Map<NhanVienDTO>(nv);
            return dto;
        }
    }
}
