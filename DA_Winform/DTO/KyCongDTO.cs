using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_Winform.DTO
{
	public class KyCongDTO
	{
		private string _MaKC;
		public string MaKC
		{
			get { return _MaKC; }
			set { _MaKC = value; }
		}

		private int _thang;
		public int thang
		{
			get { return _thang; }
			set { _thang = value; }
		}

		private int _nam;
		public int nam
		{
			get { return _nam; }
			set { _nam = value; }
		}

		private DateTime _ngaytinhcong;
		public DateTime ngaytinhcong
		{
			get { return _ngaytinhcong; }
			set { _ngaytinhcong = value; }
		}

		private int _ngaycongtrongthang;
		public int ngaycongtrongthang
		{
			get { return _ngaycongtrongthang; }
			set { _ngaycongtrongthang = value; }
		}

		private bool _trangthai;
		public bool trangthai
		{
			get { return _trangthai; }
			set { _trangthai = value; }
		}


		public KyCongDTO(string MaKC_, int thang_, int nam_,  DateTime ngaytinhcong_, int ngaycongtrongthang_, bool trangthai_)
		{
			this.MaKC = MaKC_;
			this.thang = thang_;
			this.nam = nam_;
			this.ngaytinhcong = ngaytinhcong_;
			this.ngaycongtrongthang = ngaycongtrongthang_;
			this.trangthai = trangthai_;
		}

		public KyCongDTO()
		{
			this.MaKC = "";
			this.thang = 0;
			this.nam = 0;
			this.ngaytinhcong = DateTime.Now;
			this.ngaycongtrongthang = 0;
			this.trangthai = false;
		}

	}
}
