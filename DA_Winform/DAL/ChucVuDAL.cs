using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DA_Winform.DTO;
using AutoMapper;

namespace DA_Winform.DAL
{
    public class ChucVuDAL
    {
        public static List<ChucVuDTO> CV_GetAll()
        {
            QLNVEntities data = new QLNVEntities();
            var truyvan = from cv in data.ChucVus
                          select cv;

            List<ChucVuDTO> listKQ = new List<ChucVuDTO>();
            foreach (ChucVu cv in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<ChucVu, ChucVuDTO>());
                var mapper = new Mapper(config);
                ChucVuDTO dto = mapper.Map<ChucVuDTO>(cv);
                listKQ.Add(dto);
            }
            return listKQ;
        }
        public static bool CV_Add(ChucVuDTO dto)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ChucVuDTO, ChucVu>());
            var mapper = new Mapper(config);
            ChucVu cv = mapper.Map<ChucVu>(dto);
            QLNVEntities data = new QLNVEntities();
            if (Bi_LapCV(dto) == false)
            {
                data.ChucVus.Add(cv);
            }
            return data.SaveChanges() > 0 ? true : false;
        }
        public static bool Bi_LapCV(ChucVuDTO dto)
        {
            QLNVEntities data = new QLNVEntities();
            ChucVu cv = (from p in data.ChucVus
                         where p.MaCV == dto.MaCV | p.TenCV == dto.TenCV
                         select p).DefaultIfEmpty().Single<ChucVu>();
            return cv != null ? true : false;
        }
        public static int CV_Count()
        {
            int c;
            QLNVEntities pb = new QLNVEntities();
            c = pb.ChucVus.Count() + 1;
            return c;
        }
    }
}
