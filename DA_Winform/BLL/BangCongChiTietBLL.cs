using DA_Winform.DAL;
using DA_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_Winform.BLL
{
    public class BangCongChiTietBLL
    {
        public static List<BangCongChiTietDTO> EF_GetAll()
        {
            return BangCongChiTietDAL.EF_GetAll();
        }

        public static bool EF_Add(BangCongChiTietDTO dto)
        {
            return BangCongChiTietDAL.EF_Add(dto);
        }

        public static int EF_Count()
        {
            return BangCongChiTietDAL.EF_Count();
        }

        public static bool EF_UpdateDiemDanh(string t1, string t2, int t3)
        {
            return BangCongChiTietDAL.EF_UpdateDiemDanh(t1, t2, t3);
        }

        public static int Tongngayphep(string t1, string t2)
        {
            return BangCongChiTietDAL.Tongngayphep(t1, t2);
        }
    }
}
