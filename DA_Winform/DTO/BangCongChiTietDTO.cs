using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_Winform.DTO
{
	public class BangCongChiTietDTO
	{
		private int _ID;
		public int ID
		{
			get { return _ID; }
			set { _ID = value; }
		}

		private string _MaKC;
		public string MaKC
		{
			get { return _MaKC; }
			set { _MaKC = value; }
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

		private DateTime _ngay;
		public DateTime ngay
		{
			get { return _ngay; }
			set { _ngay = value; }
		}

		private string _thu;
		public string thu
		{
			get { return _thu; }
			set { _thu = value; }
		}

		private string _giovao;
		public string giovao
		{
			get { return _giovao; }
			set { _giovao = value; }
		}

		private int _ngaycong;
		public int ngaycong
		{
			get { return _ngaycong; }
			set { _ngaycong = value; }
		}

		private int _ngayphep;
		public int ngayphep
		{
			get { return _ngayphep; }
			set { _ngayphep = value; }
		}

		private string _kyhieu;
		public string kyhieu
		{
			get { return _kyhieu; }
			set { _kyhieu = value; }
		}


		public BangCongChiTietDTO(int ID_, string MaKC_, string MaNV_, string TenNV_, DateTime ngay_, string thu_, string giovao_, int ngaycong_, int ngayphep_, string kyhieu_)
		{
			this.ID = ID_;
			this.MaKC = MaKC_;
			this.MaNV = MaNV_;
			this.TenNV = TenNV_;
			this.ngay = ngay_;
			this.thu = thu_;
			this.giovao = giovao_;
			this.ngaycong = ngaycong_;
			this.ngayphep = ngayphep_;
			this.kyhieu = kyhieu_;
		}
		public BangCongChiTietDTO()
		{
			this.ID =		0;
			this.MaKC =		"";
			this.MaNV =		"";
			this.TenNV =	"";
			this.ngay =		DateTime.Now;
			this.thu =		"";
			this.giovao =	"";
			this.ngaycong = 0;
			this.ngayphep = 0;
			this.kyhieu = "";
		}
	}
}

