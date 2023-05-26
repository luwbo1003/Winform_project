using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_Winform
{
    class PhanQuyenBLL
    {
        public static List<PhanQuyenDTO> EF_GetAll()
        {
            return PhanQuyenDAL.EF_GetAll();
        }
    }
}
