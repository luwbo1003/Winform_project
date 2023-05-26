using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DA_Winform.DTO;

namespace DA_Winform.DAL
{
    public class KyCongDAL
    {
        public static List<KyCongDTO> KC_GetAll()
        {
            QLNVEntities data = new QLNVEntities();
            var truyvan = from nv in data.KyCongs

                          select nv;


            List<KyCongDTO> listKQ = new List<KyCongDTO>();
            foreach (KyCong nv in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<KyCong, KyCongDTO>());
                var mapper = new Mapper(config);
                KyCongDTO dto = mapper.Map<KyCongDTO>(nv);
                listKQ.Add(dto);
            }
            return listKQ;
        }


        public static bool KC_Add(KyCongDTO dto)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<KyCongDTO, KyCong>());
            var mapper = new Mapper(config);
            KyCong nv = mapper.Map<KyCong>(dto);
            QLNVEntities data = new QLNVEntities();
            data.KyCongs.Add(nv);
            return data.SaveChanges() > 0 ? true : false;
        }

        public static int demngaycongtrongthang(int thang, int nam)
        {
            int dem = 0;
            DateTime f = new DateTime(nam, thang, 01);
            int x = f.Month + 1;
            while (f.Month < x)
            {
                dem = dem + 1;
                if (f.DayOfWeek == DayOfWeek.Sunday)
                {
                    dem = dem - 1;
                }
                f = f.AddDays(1);
            }
            return dem;
        }

    }
}
