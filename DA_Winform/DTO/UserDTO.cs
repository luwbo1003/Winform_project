using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_Winform
{
    class UserDTO
    {
		private string _MaNV;
		public string MaNV
		{
			get { return _MaNV; }
			set { _MaNV = value; }
		}

		private string _TenDangNhap;
		public string TenDangNhap
		{
			get { return _TenDangNhap; }
			set { _TenDangNhap = value; }
		}

		private string _MatKhau;
		public string MatKhau
		{
			get { return _MatKhau; }
			set { _MatKhau = value; }
		}

		private string _MaQuyen;
		public string MaQuyen
		{
			get { return _MaQuyen; }
			set { _MaQuyen = value; }
		}

		public UserDTO(string MaNV_, string TenDangNhap_, string MatKhau_, string MaQuyen_)
		{
			this.MaNV = MaNV_;
			this.TenDangNhap = TenDangNhap_;
			this.MatKhau = MatKhau_;
			this.MaQuyen = MaQuyen_;
		}
		public UserDTO()
		{
			this.MaNV = "";
			this.TenDangNhap = "";
			this.MatKhau = "";
			this.MaQuyen = "";
		}
	}
}
