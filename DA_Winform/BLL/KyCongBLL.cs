using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA_Winform.DTO;
using DA_Winform.DAL;

namespace DA_Winform.BLL
{
    public class KyCongBLL
    {

        public static List<KyCongDTO> KC_GetAll()
        {
            return KyCongDAL.KC_GetAll();
        }

        public static bool KC_Add(KyCongDTO dto)
        {
            return KyCongDAL.KC_Add(dto);
        }

        public static int demngaycongtrongthang(int thang, int nam)
        {
            return KyCongDAL.demngaycongtrongthang(thang, nam);
        }
    }
}
