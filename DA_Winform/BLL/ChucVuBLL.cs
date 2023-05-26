using DA_Winform.DAL;
using DA_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_Winform.BLL
{
    public class ChucVuBLL
    {
        public static List<ChucVuDTO> CV_GetAll()
        {
            return ChucVuDAL.CV_GetAll();
        }
        public static bool CV_Add(ChucVuDTO dto)
        {
            return ChucVuDAL.CV_Add(dto);
        }
        public static int CV_Count()
        {
            return ChucVuDAL.CV_Count();
        }
    }
}
