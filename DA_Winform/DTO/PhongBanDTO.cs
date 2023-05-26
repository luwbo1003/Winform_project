using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_Winform.DTO
{
    public class PhongBanDTO
    {
		private string _MaPB;
		public string MaPB
		{
			get { return _MaPB; }
			set { _MaPB = value; }
		}

		private string _TenPB;
		public string TenPB
		{
			get { return _TenPB; }
			set { _TenPB = value; }
		}

		private string _Matrphong;
		public string Matrphong
		{
			get { return _Matrphong; }
			set { _Matrphong = value; }
		}

		private DateTime _NgayNhamChuc;
		public DateTime NgayNhamChuc
		{
			get { return _NgayNhamChuc; }
			set { _NgayNhamChuc = value; }
		}

		private string _TrangThai;
		public string TrangThai
		{
			get { return _TrangThai; }
			set { _TrangThai = value; }
		}


		public PhongBanDTO(string MaPB_, string TenPB_, string Matrphong_, DateTime NgayNhamChuc_, string TrangThai_)
		{
			this.MaPB = MaPB_;
			this.TenPB = TenPB_;
			this.Matrphong = Matrphong_;
			this.NgayNhamChuc = NgayNhamChuc_;
			this.TrangThai = TrangThai_;
		}
		public PhongBanDTO()
		{
			this.MaPB = "";
			this.TenPB = "";
			this.Matrphong = "";
			this.NgayNhamChuc = DateTime.Now;
			this.TrangThai = "";
		}
	}
}
