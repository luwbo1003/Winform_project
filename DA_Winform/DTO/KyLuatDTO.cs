using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_Winform.DTO
{
	public class KyLuatDTO
	{
		private string _MaKL;
		public string MaKL
		{
			get { return _MaKL; }
			set { _MaKL = value; }
		}

		private DateTime _NgayKyLuat;
		public DateTime NgayKyLuat
		{
			get { return _NgayKyLuat; }
			set { _NgayKyLuat = value; }
		}

		private string _MaNV;
		public string MaNV
		{
			get { return _MaNV; }
			set { _MaNV = value; }
		}

		private string _TenNV;
		public string TenNV
		{
			get { return _TenNV; }
			set { _TenNV = value; }
		}

		private string _NoiDungKL;
		public string NoiDungKL
		{
			get { return _NoiDungKL; }
			set { _NoiDungKL = value; }
		}

		private string _HinhThuc;
		public string HinhThuc
		{
			get { return _HinhThuc; }
			set { _HinhThuc = value; }
		}

		private int _TienKL;
		public int TienKL
		{
			get { return _TienKL; }
			set { _TienKL = value; }
		}

		private string _TrangThai;
		public string TrangThai
		{
			get { return _TrangThai; }
			set { _TrangThai = value; }
		}


		public KyLuatDTO(string MaKL_, DateTime NgayKyLuat_, string MaNV_, string TenNV_, string NoiDungKL_, string HinhThuc_, int TienKL_, string TrangThai_)
		{
			this.MaKL = MaKL_;
			this.NgayKyLuat = NgayKyLuat_;
			this.MaNV = MaNV_;
			this.TenNV = TenNV_;
			this.NoiDungKL = NoiDungKL_;
			this.HinhThuc = HinhThuc_;
			this.TienKL = TienKL_;
			this.TrangThai = TrangThai_;
		}
		public KyLuatDTO()
		{
			this.MaKL = "";
			this.NgayKyLuat = DateTime.Now;
			this.MaNV = "";
			this.TenNV = "";
			this.NoiDungKL = "";
			this.HinhThuc = "";
			this.TienKL = 0;
			this.TrangThai = "";
		}
	}	
}
