using System;
using DA_Winform.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace DA_Winform.DAL
{
    internal class KyLuatDAL
    {
        public static List<KyLuatDTO> KL_GetAll()
        {
            QLNVEntities data = new QLNVEntities();
            var truyvan = from kl in data.KyLuats
                          select kl;
            List<KyLuatDTO> listKQ = new List<KyLuatDTO>();
            foreach (KyLuat kl in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<KyLuat, KyLuatDTO>());
                var mapper = new Mapper(config);
                KyLuatDTO dto = mapper.Map<KyLuatDTO>(kl);

                var nvv = data.NhanViens.FirstOrDefault(n => n.MaNV == kl.MaNV);
                dto.TenNV= nvv.TenNV;
                listKQ.Add(dto);
            }
            return listKQ;
        }
        public static bool KL_AddNew(KyLuatDTO dto)
        {
            //chuyển đổi tự động
            var config = new MapperConfiguration(cfg => cfg.CreateMap<KyLuatDTO, KyLuat>());
            var mapper = new Mapper(config);
            KyLuat kl = mapper.Map<KyLuat>(dto);

            QLNVEntities data = new QLNVEntities();
            data.KyLuats.Add(kl);
            return data.SaveChanges() > 0 ? true : false;
        }
        public static bool KL_Edit(string makl, DateTime ngay, string manvkl, string tennvkl,  string noidungkl, string hinhthuckl, int tienkl, string trangthai)
        {
            QLNVEntities data = new QLNVEntities();
            KyLuat sp = (from p in data.KyLuats
                         where p.MaKL == makl.Trim()
                         select p).First<KyLuat>();
            //sp.MaKL = t1;
            sp.NgayKyLuat = ngay;
            sp.MaNV = manvkl;
            sp.TenNV = tennvkl;
            sp.NoiDungKL = noidungkl;
            sp.HinhThuc = hinhthuckl;
            sp.TienKL = tienkl;
            sp.TrangThai = trangthai;

            return data.SaveChanges() > 0 ? true : false;
        }
        public static bool KL_Delete(string t1)
        {
            QLNVEntities data = new QLNVEntities();
            NhanVien sp = (from p in data.NhanViens
                           join k in data.KyLuats on p.MaNV equals k.MaNV
                           where p.MaNV == t1.Trim()
                           select p).Single<NhanVien>();
            //sp.MaKL = t1;1
            sp.TrangThai = "Đã nghỉ việc";

            return data.SaveChanges() > 0 ? true : false;
        }
        public static int KL_Count()
        {
            int count;
            QLNVEntities db = new QLNVEntities();
            count = db.KyLuats.Count() + 1;
            return count;
        }
        public static List<object> KL_GetAllStaffBYName(string name)
        {
            QLNVEntities data = new QLNVEntities();
            var staff = from kl in data.KyLuats
                        join nv in data.NhanViens
                        on kl.TenNV equals nv.TenNV
                        where kl.TenNV.Contains(name)
                        select new
                        {
                            kl.MaKL,
                            kl.NgayKyLuat,
                            kl.MaNV,
                            kl.TenNV,
                            kl.NoiDungKL,
                            kl.HinhThuc,
                            kl.TienKL,
                            kl.TrangThai,
                        };
            List<object> KyLuatDTOs = new List<object>();
            foreach (var st in staff)
            {
                KyLuatDTOs.Add(st);
            }
            return KyLuatDTOs;
        }
    }
}
