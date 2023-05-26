using DA_Winform.DAL;
using DA_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_Winform.BLL
{
    public class PhongBanBLL
    {
        public static List<PhongBanDTO> EF_GetAll()
        {
            return PhongBanDAL.EF_GetAll();
        }

        public static bool EF_Add(PhongBanDTO dto)
        {
            return PhongBanDAL.EF_Add(dto);
        }
        public static int EF_Count()
        {
            return PhongBanDAL.EF_Count();
        }
        public static bool EF_Update(PhongBanDTO pb)
        {
            return PhongBanDAL.Updating(pb);
        }
        public static bool Delete(string pb)
        {
            return PhongBanDAL.Delete(pb);
        }
        public static List<PhongBanDTO> EF_GetAllActive()
        {
            return PhongBanDAL.EF_GetAllActive();
        }
    }
}
