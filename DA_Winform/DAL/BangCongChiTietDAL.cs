using AutoMapper;
using DA_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_Winform.DAL
{
    public class BangCongChiTietDAL
    {
        public static List<BangCongChiTietDTO> EF_GetAll()
        {
            QLNVEntities data = new QLNVEntities();
            var truyvan = from nv in data.BangCongChiTiets

                          select nv;


            List<BangCongChiTietDTO> listKQ = new List<BangCongChiTietDTO>();
            foreach (BangCongChiTiet nv in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<BangCongChiTiet, BangCongChiTietDTO>());
                var mapper = new Mapper(config);
                BangCongChiTietDTO dto = mapper.Map<BangCongChiTietDTO>(nv);
                listKQ.Add(dto);
            }
            return listKQ;
        }

        public static bool EF_Add(BangCongChiTietDTO dto)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BangCongChiTietDTO, BangCongChiTiet>());
            var mapper = new Mapper(config);
            BangCongChiTiet nv = mapper.Map<BangCongChiTiet>(dto);
            QLNVEntities data = new QLNVEntities();
            data.BangCongChiTiets.Add(nv);
            return data.SaveChanges() > 0 ? true : false;
        }

        public static int EF_Count()
        {
            int count;
            QLNVEntities db = new QLNVEntities();
            count = db.BangCongChiTiets.Count() + 1;
            return count;

        }


        public static bool EF_UpdateDiemDanh(string t1, string t2, int t3)
        {
            QLNVEntities data = new QLNVEntities();
            BangCongChiTiet sp = (from p in data.BangCongChiTiets
                                  where p.MaKC == t1.Trim() & p.MaNV == t2.Trim() & p.ngay.Value.Day == t3
                                  select p).Single<BangCongChiTiet>();
            sp.kyhieu = "X";
            sp.ngaycong = 1;
            sp.ngayphep = 0;
            return data.SaveChanges() > 0 ? true : false;
        }

        public static int Tongngayphep(string t1, string t2)
        {
            int i = 0;
            QLNVEntities data = new QLNVEntities();
            i = data.BangCongChiTiets.Where(x => x.MaKC == t1 && x.MaNV == t2 && x.ngayphep != null).Sum(pp => pp.ngayphep.Value);
            return i;
        }

    }
}
