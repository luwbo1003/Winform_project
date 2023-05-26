using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_Winform.DTO
{
	public class NhanVienDTO
	{
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

		private DateTime _NgaySinh;
		public DateTime NgaySinh
		{
			get { return _NgaySinh; }
			set { _NgaySinh = value; }
		}

		private string _GioiTinh;
		public string GioiTinh
		{
			get { return _GioiTinh; }
			set { _GioiTinh = value; }
		}

		private string _DiaChi;
		public string DiaChi
		{
			get { return _DiaChi; }
			set { _DiaChi = value; }
		}
		

		private string _DienThoai;
		public string DienThoai
		{
			get { return _DienThoai; }
			set { _DienThoai = value; }
		}

		private string _CCCD;
		public string CCCD
		{
			get { return _CCCD; }
			set { _CCCD = value; }
		}

		private string _MaPB;
		public string MaPB
		{
			get { return _MaPB; }
			set { _MaPB = value; }
		}

		private string _MaCV;
		public string MaCV
		{
			get { return _MaCV; }
			set { _MaCV = value; }
		}

		private float _MaLuong;
		public float MaLuong
		{
			get { return _MaLuong; }
			set { _MaLuong = value; }
		}

		private string _TrangThai;
		public string TrangThai
		{
			get { return _TrangThai; }
			set { _TrangThai = value; }
		}
		public static NhanVienDTO KiemTra(string ten, string cmnd)
		{
			QLNVEntities data = new QLNVEntities();
			NhanVien nv = (from p in data.NhanViens
						   where p.TenNV.Trim().ToLower() == ten & p.CCCD.Trim() == cmnd
						   select p).DefaultIfEmpty().Single<NhanVien>();
			var config = new MapperConfiguration(cfg => cfg.CreateMap<NhanVien, NhanVienDTO>());
			var mapper = new Mapper(config); NhanVienDTO dto = mapper.Map<NhanVienDTO>(nv);
			return dto;
		}

		public NhanVienDTO(string MaNV_, string TenNV_, DateTime NgaySinh_, string GioiTinh_, string DiaChi_, string Email_, string SDT_, string CCCD_, string MaPB_, string MaCV_, float MaLuong_, string TrangThai_)
		{
			this.MaNV = MaNV_;
			this.TenNV = TenNV_;
			this.NgaySinh = NgaySinh_;
			this.GioiTinh = GioiTinh_;
			this.DiaChi = DiaChi_;
			this.DienThoai = SDT_;
			this.CCCD = CCCD_;
			this.MaPB = MaPB_;
			this.MaCV = MaCV_;
			this.MaLuong = MaLuong_;
			this.TrangThai = TrangThai_;
		}
		public NhanVienDTO()
		{
			this.MaNV = "";
			this.TenNV = "";
			this.NgaySinh = DateTime.Now;
			this.GioiTinh = "";
			this.DiaChi = "";
			this.DienThoai = "";
			this.CCCD = "";
			this.MaPB = "";
			this.MaCV = "";
			this.MaLuong = 0;
			this.TrangThai = "";
		}
	}
}
