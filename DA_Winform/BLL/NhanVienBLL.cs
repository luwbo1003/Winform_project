using DA_Winform.DAL;
using DA_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_Winform.BLL
{
    public class NhanVienBLL
    {
        public static List<NhanVienDTO> EF_GetAll()
        {
            return NhanVienDAL.EF_GetAll();
        }

        public static List<NhanVienDTO> EF_Find(string manv, string tennv, string sdt, string diachi, string gioitinh, string mapb, string macv)
        {
            return NhanVienDAL.EF_Find(manv, tennv, sdt, diachi, gioitinh, mapb, macv);
        }
        public static List<NhanVienDTO> EF_FindBoy(string gtinh)
        {
            return NhanVienDAL.EF_FindBoy(gtinh);
        }

        public static List<NhanVienDTO> EF_FindGirl(string gtinh)
        {
            return NhanVienDAL.EF_FindGirl(gtinh);
        }

        public static List<NhanVienDTO> EF_TrangThai1(string tt)
        {
            return NhanVienDAL.EF_TrangThai1(tt);
        }

        public static List<NhanVienDTO> EF_TrangThai2(string tt)
        {
            return NhanVienDAL.EF_TrangThai2(tt);
        }
        public static bool EF_Add(NhanVienDTO dto)
        {
            return NhanVienDAL.EF_Add(dto);
        }

        public static bool EF_Update(string manv, string tennv, DateTime ngaysinh, string gioitinh, string diachi, string sdt, string cccd, string mapb, string macv, float maluong, string trangthai)
        {
            return NhanVienDAL.EF_Update(manv, tennv, ngaysinh, gioitinh, diachi, sdt, cccd, mapb, macv, maluong, trangthai);
        }

        public static bool EF_Delete(string manv)
        {
            return NhanVienDAL.EF_Delete(manv);
        }

        public static int EF_Count()
        {
            return NhanVienDAL.EF_Count();
        }

        //public static NhanVien Them(NhanVien nv)
        //{
        //    return NhanVienDAL.Them(nv);
        //}

        //public static NhanVien Sua(NhanVien nv)
        //{
        //    return NhanVienDAL.Sua(nv);
        //}

        public static List<NhanVienDTO> EF_FindWithPB(string mapb, string macv)
        {
            return NhanVienDAL.EF_FindWithPB(mapb, macv);
        }


    }
}
