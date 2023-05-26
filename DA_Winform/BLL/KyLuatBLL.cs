using DA_Winform.DAL;
using DA_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_Winform.BLL
{
    public class KyLuatBLL
    {
        public static List<KyLuatDTO> KL_GetAll()
        {
            return KyLuatDAL.KL_GetAll();
        }
        public static bool KL_AddNew(KyLuatDTO dto)
        {
            return KyLuatDAL.KL_AddNew(dto);
        }
        public static bool KL_Edit(string makl, DateTime ngay, string manvkl, string tennvkl,  string noidungkl, string hinhthuckl, int tienkl, string trangthai)
        {
            return KyLuatDAL.KL_Edit(makl, ngay, manvkl, tennvkl,noidungkl, hinhthuckl, tienkl, trangthai);
        }
        public static bool KL_Delete(string t1)
        {
            return KyLuatDAL.KL_Delete(t1);
        }
        public static int KL_Count()
        {
            return KyLuatDAL.KL_Count();
        }
        public static List<object> KL_GetAllStaffByName(string name)
        {
            return KyLuatDAL.KL_GetAllStaffBYName(name);
        }
    }
}
