using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DA_Winform.DTO;
using DA_Winform.DAL;


namespace DA_Winform.BLL
{
    public class BonusBLL
    {
        public static List<BonusDTO> BN_GetAll()
        {
            return BonusDAL.BN_GetAll();
        }

        public static bool BN_Add(BonusDTO dto)
        {
            return BonusDAL.BN_Add(dto);
        }

        public static bool BN_Update(string makt, DateTime ngay, string manv, string tennv,  string noidungkt, string hinhthuc, int tienkt, string trangthai)
        {
            return BonusDAL.BN_Update(makt, ngay, manv, tennv, noidungkt, hinhthuc, tienkt, trangthai);
        }

        public static int BN_Count()
        {
            return BonusDAL.BN_Count();
        }
        public static List<object> BN_GetAllStaffByName(string name)
        {
            return BonusDAL.BN_GetAllStaffBYID(name);
        }
        //public static bool Delete(string manv)
        //{
        //    return BonusDAL.Delete(manv);
        //}
    }
}
