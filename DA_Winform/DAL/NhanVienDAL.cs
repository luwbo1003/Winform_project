using AutoMapper;
using DA_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_Winform.DAL
{
    public class NhanVienDAL
    {

        public static List<NhanVienDTO> EF_GetAll()
        {
            QLNVEntities data = new QLNVEntities();
            var truyvan = from nv in data.NhanViens
                          select nv;
            List<NhanVienDTO> listkq = new List<NhanVienDTO>();
            foreach (NhanVien kl in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<NhanVien, NhanVienDTO>());

                var mapper = new Mapper(config);
                NhanVienDTO dt = mapper.Map<NhanVienDTO>(kl);
                listkq.Add(dt);
            }
            return listkq;
        }

        public static List<NhanVienDTO> EF_Find(string manv, string tennv, string sdt, string diachi, string gioitinh, string mapb, string macv)
        {
            QLNVEntities data = new QLNVEntities();
            var truyvan = from nv in data.NhanViens
                          where nv.TrangThai == "Đang công tác" & (nv.MaNV == manv.Trim() || nv.TenNV == tennv.Trim() || nv.DienThoai == sdt.Trim() || nv.DiaChi == diachi.Trim() || nv.GioiTinh == gioitinh.Trim() || nv.MaPB == mapb.Trim() || nv.MaCV == macv.Trim())
                          select nv;


            List<NhanVienDTO> listKQ = new List<NhanVienDTO>();
            foreach (NhanVien nv in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<NhanVien, NhanVienDTO>());
                var mapper = new Mapper(config);
                NhanVienDTO dto = mapper.Map<NhanVienDTO>(nv);
                listKQ.Add(dto);
            }
            return listKQ;
        }
        public static List<NhanVienDTO> EF_FindBoy(string gtinh)
        {
            QLNVEntities data = new QLNVEntities();
            var truyvan = from nv in data.NhanViens
                          where (nv.GioiTinh == "Nam")
                          select nv;
            List<NhanVienDTO> listKQ = new List<NhanVienDTO>();
            foreach (NhanVien nv in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<NhanVien, NhanVienDTO>());
                var mapper = new Mapper(config);
                NhanVienDTO dto = mapper.Map<NhanVienDTO>(nv);
                listKQ.Add(dto);
            }
            return listKQ;
        }
        public static List<NhanVienDTO> EF_FindGirl(string gtinh)
        {
            QLNVEntities data = new QLNVEntities();
            var truyvan = from nv in data.NhanViens
                          where (nv.GioiTinh == "Nữ")
                          select nv;
            List<NhanVienDTO> listKQ = new List<NhanVienDTO>();
            foreach (NhanVien nv in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<NhanVien, NhanVienDTO>());
                var mapper = new Mapper(config);
                NhanVienDTO dto = mapper.Map<NhanVienDTO>(nv);
                listKQ.Add(dto);
            }
            return listKQ;
        }
        public static List<NhanVienDTO> EF_TrangThai1(string tt)
        {
            QLNVEntities data = new QLNVEntities();
            var truyvan = from nv in data.NhanViens
                          where (nv.TrangThai == "Đang công tác")
                          select nv;
            List<NhanVienDTO> listKQ = new List<NhanVienDTO>();
            foreach (NhanVien nv in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<NhanVien, NhanVienDTO>());
                var mapper = new Mapper(config);
                NhanVienDTO dto = mapper.Map<NhanVienDTO>(nv);
                listKQ.Add(dto);
            }
            return listKQ;
        }
        public static List<NhanVienDTO> EF_TrangThai2(string tt)
        {
            QLNVEntities data = new QLNVEntities();
            var truyvan = from nv in data.NhanViens
                          where (nv.TrangThai == "Đã nghỉ việc")
                          select nv;
            List<NhanVienDTO> listKQ = new List<NhanVienDTO>();
            foreach (NhanVien nv in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<NhanVien, NhanVienDTO>());
                var mapper = new Mapper(config);
                NhanVienDTO dto = mapper.Map<NhanVienDTO>(nv);
                listKQ.Add(dto);
            }
            return listKQ;
        }
        public static bool EF_Add(NhanVienDTO dto)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<NhanVienDTO, NhanVien>());
            var mapper = new Mapper(config);
            NhanVien nv = mapper.Map<NhanVien>(dto);
            QLNVEntities data = new QLNVEntities();
            data.NhanViens.Add(nv);
            return data.SaveChanges() > 0 ? true : false;
        }
        public static bool EF_Update(string manv, string tennv, DateTime ngaysinh, string gioitinh, string diachi, string sdt, string cccd, string mapb, string macv, float maluong, string trangthai)
        {
            QLNVEntities data = new QLNVEntities();
            NhanVien sp = (from p in data.NhanViens
                           where p.MaNV == manv.Trim()
                           select p).Single<NhanVien>();
            //sp.MaNV = t1;
            sp.TenNV = tennv;
            sp.NgaySinh = ngaysinh;
            sp.GioiTinh = gioitinh;
            sp.DiaChi = diachi;
            sp.DienThoai = sdt;
            sp.CCCD = cccd;
            sp.MaPB = mapb;
            sp.MaCV = macv;
            sp.MaLuong = maluong;
            sp.TrangThai = trangthai;
            return data.SaveChanges() > 0 ? true : false;
        }
        public static bool EF_Delete(string manv)
        {
            QLNVEntities data = new QLNVEntities();
            NhanVien sp = (from p in data.NhanViens
                           where p.MaNV == manv.Trim()
                           select p).Single<NhanVien>();
            //sp.MaNV = t1;            
            sp.TrangThai = "Đã nghỉ việc";
            return data.SaveChanges() > 0 ? true : false;
        }

        public static int EF_Count()
        {
            int count;
            QLNVEntities db = new QLNVEntities();
            count = db.NhanViens.Count() + 1;
            return count;

        }

        public static List<NhanVienDTO> EF_FindWithPB(string mapb, string macv)
        {
            QLNVEntities data = new QLNVEntities();
            var truyvan = from nv in data.NhanViens
                          where nv.TrangThai == "Đang công tác" & (nv.MaPB == mapb.Trim()) & (nv.MaCV == macv.Trim())
                          select nv;


            List<NhanVienDTO> listKQ = new List<NhanVienDTO>();
            foreach (NhanVien nv in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<NhanVien, NhanVienDTO>());
                var mapper = new Mapper(config);
                NhanVienDTO dto = mapper.Map<NhanVienDTO>(nv);
                listKQ.Add(dto);
            }
            return listKQ;
        }


    }
}
