using DA_Winform.DAL;
using DA_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_Winform.BLL
{
	public class KyCongChiTietBLL
	{
		public static int GetTongNgayCong(string makycong, string manhanvien)
		{
			return KyCongChiTietDAL.GetTongNgayCong(makycong, manhanvien);
		}

		public static List<KyCongChiTietDTO> EF_GetWith(String t1)
		{
			return KyCongChiTietDAL.EF_GetWith(t1);
		}

		public static List<KyCongChiTietDTO> EF_GetWithSpecial(string t1, int t2, int t3)
		{
			return KyCongChiTietDAL.EF_GetWithSpecial(t1, t2, t3);
		}

		public static bool EF_UpdateTrangThai(string t1)
		{
			return KyCongChiTietDAL.EF_UpdateTrangThai(t1);
		}

		QLNVEntities db = new QLNVEntities();
		public void phatSinhKyCongChiTiet(int thang, int nam)
		{
			List<NhanVienDTO> lstNV = NhanVienBLL.EF_GetAll();
			if (lstNV.Count == 0) return;

			foreach (NhanVienDTO item in lstNV)
			{
				List<string> listDay = new List<string>();

				for (int j = 1; j <= GetDayNumber(thang, nam); j++)
				{
					DateTime newDate = new DateTime(nam, thang, j);

					switch (newDate.DayOfWeek.ToString())
					{
						case "Sunday":
							listDay.Add("CN");
							break;
						default:
							listDay.Add("P");
							break;
					}
				}

				switch (listDay.Count)
				{
					case 28:
						listDay.Add("");
						listDay.Add("");
						listDay.Add("");
						break;
					case 29:
						listDay.Add("");
						listDay.Add("");
						break;
					case 30:
						listDay.Add("");
						break;
				}

				KyCongChiTiet kycongchitiet = new KyCongChiTiet();
				kycongchitiet.MaKC = (nam * 100 + thang).ToString();
				kycongchitiet.MaNV = item.MaNV;
				kycongchitiet.TenNV = item.TenNV;
				kycongchitiet.D1 = listDay[0];
				kycongchitiet.D2 = listDay[1];
				kycongchitiet.D3 = listDay[2];
				kycongchitiet.D4 = listDay[3];
				kycongchitiet.D5 = listDay[4];
				kycongchitiet.D6 = listDay[5];
				kycongchitiet.D7 = listDay[6];
				kycongchitiet.D8 = listDay[7];
				kycongchitiet.D9 = listDay[8];
				kycongchitiet.D10 = listDay[9];
				kycongchitiet.D11 = listDay[10];
				kycongchitiet.D12 = listDay[11];
				kycongchitiet.D13 = listDay[12];
				kycongchitiet.D14 = listDay[13];
				kycongchitiet.D15 = listDay[14];
				kycongchitiet.D16 = listDay[15];
				kycongchitiet.D17 = listDay[16];
				kycongchitiet.D18 = listDay[17];
				kycongchitiet.D19 = listDay[18];
				kycongchitiet.D20 = listDay[19];
				kycongchitiet.D21 = listDay[20];
				kycongchitiet.D22 = listDay[21];
				kycongchitiet.D23 = listDay[22];
				kycongchitiet.D24 = listDay[23];
				kycongchitiet.D25 = listDay[24];
				kycongchitiet.D26 = listDay[25];
				kycongchitiet.D27 = listDay[26];
				kycongchitiet.D28 = listDay[27];
				kycongchitiet.D29 = listDay[28];
				kycongchitiet.D30 = listDay[29];
				kycongchitiet.D31 = listDay[30];
				kycongchitiet.ngaycong = KyCongBLL.demngaycongtrongthang(thang, nam);
				kycongchitiet.ngayphep = KyCongBLL.demngaycongtrongthang(thang, nam);
				kycongchitiet.tongngaycong = 0;
				db.KyCongChiTiets.Add(kycongchitiet);
				db.SaveChanges();
			}

		}


		public static int GetDayNumber(int thang, int nam)
		{
			return KyCongChiTietDAL.GetDayNumber(thang, nam);
		}

		public static string laythutrongtuan(int nam, int thang, int ngay)
		{
			return KyCongChiTietDAL.laythutrongtuan(nam, thang, ngay);
		}

		public static bool EF_UpdateDiemDanh(string t1, string t2, string t3)
		{
			return KyCongChiTietDAL.EF_UpdateDiemDanh(t1, t2, t3);
		}

		public static bool EF_UpdateNgayPhep(string t1, string t2, int t3, int t4)
		{
			return KyCongChiTietDAL.EF_UpdateNgayPhep(t1, t2, t3, t4);
		}

	}
}
