using AutoMapper;
using DA_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_Winform.DAL
{
    public class PhongBanDAL
    {
        public static List<PhongBanDTO> EF_GetAll()
        {
            QLNVEntities data = new QLNVEntities();
            var truyvan = from pb in data.PhongBans
                          select pb;


            List<PhongBanDTO> listKQ = new List<PhongBanDTO>();
            foreach (PhongBan pb in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<PhongBan, PhongBanDTO>());
                var mapper = new Mapper(config);
                PhongBanDTO dto = mapper.Map<PhongBanDTO>(pb);
                listKQ.Add(dto);
            }
            return listKQ;
        }

        public static bool EF_Add(PhongBanDTO dto)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<PhongBanDTO, PhongBan>());
            var mapper = new Mapper(config);
            PhongBan nv = mapper.Map<PhongBan>(dto);
            QLNVEntities data = new QLNVEntities();
            data.PhongBans.Add(nv);
            return data.SaveChanges() > 0 ? true : false;
        }
        //_____________________________________________________________________________________________
        public static List<PhongBanDTO> EF_GetAllActive()
        {
            QLNVEntities data = new QLNVEntities();
            var truyvan = from pb in data.PhongBans
                          where pb.TrangThai == "Đang hoạt động ".Trim()
                          select pb;


            List<PhongBanDTO> listKQ = new List<PhongBanDTO>();
            foreach (PhongBan pb in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<PhongBan, PhongBanDTO>());
                var mapper = new Mapper(config);
                PhongBanDTO dto = mapper.Map<PhongBanDTO>(pb);
                listKQ.Add(dto);
            }
            return listKQ;
        }
        public static int EF_Count()
        {
            int c;
            QLNVEntities pb = new QLNVEntities();
            c = pb.PhongBans.Count() + 1;
            return c;

        }
        public static bool Updating(PhongBanDTO pb)
        {
            QLNVEntities data = new QLNVEntities();
            var sp = (from p in data.PhongBans
                      where p.MaPB == pb.MaPB.Trim()
                      select p).Single();
            //var config = new MapperConfiguration(cfg => cfg.CreateMap<PhongBanDTO, PhongBan>());
            //var mapper = new Mapper(config);
            sp.TenPB = pb.TenPB;
            sp.Matrphong = pb.Matrphong;
            sp.NgayNhamChuc = pb.NgayNhamChuc;

            //sp.NgayNhamChuc = pb.NgayNhamChuc;

            return data.SaveChanges() > 0 ? true : false;
        }
        public static bool Delete(string ma)
        {
            QLNVEntities data = new QLNVEntities();
            PhongBan truyvan = (from pb in data.PhongBans
                                where pb.MaPB == ma.Trim()
                                select pb).DefaultIfEmpty().Single<PhongBan>();
            truyvan.TrangThai = "Dừng hoạt động";
            return data.SaveChanges() > 0 ? true : false;
        }
    }
}
