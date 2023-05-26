using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_Winform.DTO
{
	public class BonusDTO
	{
		private string _MaKT;
		public string MaKT
		{
			get { return _MaKT; }
			set { _MaKT = value; }
		}

		private DateTime _NgayKhenThuong;
		public DateTime NgayKhenThuong
		{
			get { return _NgayKhenThuong; }
			set { _NgayKhenThuong = value; }
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

		private string _NoiDungKT;
		public string NoiDungKT
		{
			get { return _NoiDungKT; }
			set { _NoiDungKT = value; }
		}

		private string _HinhThuc;
		public string HinhThuc
		{
			get { return _HinhThuc; }
			set { _HinhThuc = value; }
		}

		private int _TienThuong;
		public int TienThuong
		{
			get { return _TienThuong; }
			set { _TienThuong = value; }
		}

		private string _TrangThai;
		public string TrangThai
		{
			get { return _TrangThai; }
			set { _TrangThai = value; }
		}

		public BonusDTO(string MaKT_, DateTime NgayKhenThuong_, string MaNV_, string TenNV_, string NoiDungKT_, string HinhThuc_, int TienThuong_, string TrangThai_)
		{
			this.MaKT = MaKT_;
			this.NgayKhenThuong = NgayKhenThuong_;
			this.MaNV = MaNV_;
			this.TenNV = TenNV_;
			this.NoiDungKT = NoiDungKT_;
			this.HinhThuc = HinhThuc_;
			this.TienThuong = TienThuong_;
			this.TrangThai = TrangThai_;
		}
	public BonusDTO()
		{
			MaKT = "";
			NgayKhenThuong = DateTime.Now;
			MaNV = "";
			TenNV = "";
			NoiDungKT = "";
			HinhThuc = "";
			TienThuong = 0;
			TrangThai = "";
			
		}
	}

}

