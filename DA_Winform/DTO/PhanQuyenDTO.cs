using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_Winform
{
	public class PhanQuyenDTO
	{
		private string _MaQuyen;
		public string MaQuyen
		{
			get { return _MaQuyen; }
			set { _MaQuyen = value; }
		}

		private string _TenQuyen;
		public string TenQuyen
		{
			get { return _TenQuyen; }
			set { _TenQuyen = value; }
		}

		public PhanQuyenDTO(string MaQuyen_, string TenQuyen_)
		{
			this.MaQuyen = MaQuyen_;
			this.TenQuyen = TenQuyen_;
		}
		public PhanQuyenDTO()
        {
			this.MaQuyen = "";
			this.TenQuyen = "";
        }
	}
}
