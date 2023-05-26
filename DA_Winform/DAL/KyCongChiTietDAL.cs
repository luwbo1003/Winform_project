using AutoMapper;
using DA_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_Winform.DAL
{
	public class KyCongChiTietDAL
	{


		public static List<KyCongChiTietDTO> EF_GetWith(String t1)
		{
			QLNVEntities data = new QLNVEntities();
			var truyvan = from nv in data.KyCongChiTiets
						  join qv in data.NhanViens on nv.MaNV equals qv.MaNV
						  where nv.MaKC.Trim() == t1.Trim() & qv.TrangThai == "Đang công tác"
						  select nv;



			List<KyCongChiTietDTO> listKQ = new List<KyCongChiTietDTO>();
			foreach (KyCongChiTiet nv in truyvan)
			{
				var config = new MapperConfiguration(cfg => cfg.CreateMap<KyCongChiTiet, KyCongChiTietDTO>());
				var mapper = new Mapper(config);
				KyCongChiTietDTO dto = mapper.Map<KyCongChiTietDTO>(nv);

				listKQ.Add(dto);
			}
			return listKQ;
		}

		public static List<KyCongChiTietDTO> EF_GetWithSpecial(string t1, int t2, int t3)
		{
			QLNVEntities data = new QLNVEntities();
			var truyvan = from nv in data.KyCongChiTiets
						  join qv in data.NhanViens on nv.MaNV equals qv.MaNV
						  where qv.MaPB.Trim() == t1.Trim() & nv.MaKC.Trim() == (t2 * 100 + t3).ToString() & qv.TrangThai == "Đang công tác"
						  select nv;



			List<KyCongChiTietDTO> listKQ = new List<KyCongChiTietDTO>();
			foreach (KyCongChiTiet nv in truyvan)
			{
				var config = new MapperConfiguration(cfg => cfg.CreateMap<KyCongChiTiet, KyCongChiTietDTO>());
				var mapper = new Mapper(config);
				KyCongChiTietDTO dto = mapper.Map<KyCongChiTietDTO>(nv);

				listKQ.Add(dto);
			}
			return listKQ;
		}

		public static bool EF_UpdateTrangThai(string t1)
		{
			QLNVEntities data = new QLNVEntities();
			KyCong sp = (from p in data.KyCongs
						 where p.MaKC == t1.Trim()
						 select p).Single<KyCong>();
			sp.trangthai = true;
			return data.SaveChanges() > 0 ? true : false;
		}

		public static bool EF_UpdateNgayPhep(string t1, string t2, int t3, int t4)
		{
			QLNVEntities data = new QLNVEntities();
			KyCongChiTiet sp = (from p in data.KyCongChiTiets
								where p.MaKC == t1.Trim() & p.MaNV == t2.Trim()
								select p).Single<KyCongChiTiet>();
			sp.ngayphep = t3;
			sp.tongngaycong = sp.ngaycong - t4;
			return data.SaveChanges() > 0 ? true : false;
		}

		public static bool EF_UpdateDiemDanh(string t1, string t2, string t3)
		{
			string nnn = "D" + t1;
			QLNVEntities data = new QLNVEntities();
			KyCongChiTiet sp = (from p in data.KyCongChiTiets
								where p.MaKC == t2.Trim() & p.MaNV == t3.Trim()
								select p).Single<KyCongChiTiet>();
			switch (nnn)
			{
				case "D1":
					sp.D1 = "X";
					break;
				case "D2":
					sp.D2 = "X";
					break;
				case "D3":
					sp.D3 = "X";
					break;
				case "D4":
					sp.D4 = "X";
					break;
				case "D5":
					sp.D5 = "X";
					break;
				case "D6":
					sp.D6 = "X";
					break;
				case "D7":
					sp.D7 = "X";
					break;
				case "D8":
					sp.D8 = "X";
					break;
				case "D9":
					sp.D9 = "X";
					break;
				case "D10":
					sp.D10 = "X";
					break;
				case "D11":
					sp.D11 = "X";
					break;
				case "D12":
					sp.D12 = "X";
					break;
				case "D13":
					sp.D13 = "X";
					break;
				case "D14":
					sp.D14 = "X";
					break;
				case "D15":
					sp.D15 = "X";
					break;
				case "D16":
					sp.D16 = "X";
					break;
				case "D17":
					sp.D17 = "X";
					break;
				case "D18":
					sp.D18 = "X";
					break;
				case "D19":
					sp.D19 = "X";
					break;
				case "D20":
					sp.D20 = "X";
					break;
				case "D21":
					sp.D21 = "X";
					break;
				case "D22":
					sp.D22 = "X";
					break;
				case "D23":
					sp.D23 = "X";
					break;
				case "D24":
					sp.D24 = "X";
					break;
				case "D25":
					sp.D25 = "X";
					break;
				case "D26":
					sp.D26 = "X";
					break;
				case "D27":
					sp.D27 = "X";
					break;
				case "D28":
					sp.D28 = "X";
					break;
				case "D29":
					sp.D29 = "X";
					break;
				case "D30":
					sp.D30 = "X";
					break;
				case "D31":
					sp.D31 = "X";
					break;

			}
			return data.SaveChanges() > 0 ? true : false;
		}


		public static int GetDayNumber(int thang, int nam)
		{
			int dayNumber = 0;
			switch (thang)
			{
				case 2:
					dayNumber = (nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0 ? 29 : 28;
					break;

				case 4:
				case 6:
				case 9:
				case 11:
					dayNumber = 30;
					break;

				case 1:
				case 3:
				case 5:
				case 7:
				case 8:
				case 10:
				case 12:
					dayNumber = 31;
					break;
			}

			return dayNumber;
		}

		public static string laythutrongtuan(int nam, int thang, int ngay)
		{
			string thu = "";
			DateTime newDate = new DateTime(nam, thang, ngay);
			switch (newDate.DayOfWeek.ToString())
			{
				case "Monday":
					thu = "Thứ hai";
					break;
				case "Tuesday":
					thu = "Thứ ba";
					break;
				case "Wednesday":
					thu = "Thứ tư";
					break;
				case "Thursday":
					thu = "Thứ năm";
					break;
				case "Friday":
					thu = "Thứ sáu";
					break;
				case "Saturday":
					thu = "Thứ bảy";
					break;
				case "Sunday":
					thu = "Chủ nhật";
					break;
			}
			return thu;
		}

		public static int GetTongNgayCong(string makycong, string manhanvien)
		{
			QLNVEntities data = new QLNVEntities();
			var truyvan = from nv in data.KyCongChiTiets
						  where nv.MaKC.Trim() == makycong
						  select nv;


			int i = 0;
			List<KyCongChiTietDTO> listKQ = new List<KyCongChiTietDTO>();
			foreach (KyCongChiTiet nv in truyvan)
			{
				var config = new MapperConfiguration(cfg => cfg.CreateMap<KyCongChiTiet, KyCongChiTietDTO>());
				var mapper = new Mapper(config);
				KyCongChiTietDTO dto = mapper.Map<KyCongChiTietDTO>(nv);
				if (dto.MaNV.Trim() == manhanvien)
				{
					i = dto.tongngaycong;
				}

			}
			return i;
		}

	}
}
