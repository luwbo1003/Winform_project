using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_Winform.DTO
{
    public class ChucVuDTO
    {
		private string _MaCV;
		public string MaCV
		{
			get { return _MaCV; }
			set { _MaCV = value; }
		}

		private string _TenCV;
		public string TenCV
		{
			get { return _TenCV; }
			set { _TenCV = value; }
		}

		private string _MaQuyen;
		public string MaQuyen
		{
			get { return _MaQuyen; }
			set { _MaQuyen = value; }
		}


		public ChucVuDTO(string MaCV_, string TenCV_, string MaQuyen_)
		{
			this.MaCV = MaCV_;
			this.TenCV = TenCV_;
			this.MaQuyen = MaQuyen_;
		}

		public ChucVuDTO()
        {
            this.MaCV = "";
            this.TenCV = "";
			this.MaQuyen = "";
		}
    }
}
