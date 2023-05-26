using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_Winform
{
    class PhanQuyenDAL
    {
        public static List<PhanQuyenDTO> EF_GetAll()
        {
            QLNVEntities data = new QLNVEntities();
            var truyvan = from pb in data.PhanQuyens
                          select pb;


            List<PhanQuyenDTO> listKQ = new List<PhanQuyenDTO>();
            foreach (PhanQuyen pb in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<PhanQuyen, PhanQuyenDTO>());
                var mapper = new Mapper(config);
                PhanQuyenDTO dto = mapper.Map<PhanQuyenDTO>(pb);
                listKQ.Add(dto);
            }
            return listKQ;
        }
    }
}
