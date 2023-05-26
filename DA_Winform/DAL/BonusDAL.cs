using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DA_Winform.DTO;
using AutoMapper;

namespace DA_Winform.DAL
{
    public class BonusDAL
    {
        public static List<BonusDTO> BN_GetAll()
        {
            QLNVEntities data = new QLNVEntities();
            var Query = from nv in data.KhenThuongs
                        select nv;

            List<BonusDTO> listBonus = new List<BonusDTO>();
            foreach (KhenThuong kt in Query)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<KhenThuong, BonusDTO>());
                var mapper = new Mapper(config);
                BonusDTO dto = mapper.Map<BonusDTO>(kt);
                var htnv = data.NhanViens.FirstOrDefault(n => n.MaNV == kt.MaNV);
                dto.TenNV = htnv.TenNV;
                listBonus.Add(dto);
            }
            return listBonus;
        }
        public static bool BN_Add(BonusDTO dto)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BonusDTO, KhenThuong>());
            var mapper = new Mapper(config);
            KhenThuong nv = mapper.Map<KhenThuong>(dto);
            QLNVEntities data = new QLNVEntities();
            data.KhenThuongs.Add(nv);

            return data.SaveChanges() > 0 ? true : false;
        }


        public static bool BN_Update(string makt, DateTime ngay, string manv, string tennv, string noidungkt, string hinhthuc, int tienkt, string trangthai)
        {
            QLNVEntities data = new QLNVEntities();
            KhenThuong sp = (from p in data.KhenThuongs
                             where p.MaKT == makt.Trim()
                             select p).Single<KhenThuong>();
            //sp.MaKL = t1;
            sp.NgayKhenThuong = ngay;
            sp.MaNV = manv;
            sp.TenNV = tennv;
            sp.NoiDungKT = noidungkt;
            sp.HinhThuc = hinhthuc;
            sp.TienThuong = tienkt;
            sp.TrangThai = trangthai;

            //sp.TrangThai = t6;
            return data.SaveChanges() > 0 ? true : false;
        }
        public static int BN_Count()
        {
            int count;
            QLNVEntities db = new QLNVEntities();
            count = db.KhenThuongs.Count() + 1;
            return count;
        }

        //public static bool Delete(string manv)
        //{
        //    QLNVEntities data = new QLNVEntities();
        //    KhenThuong truyvan = (from kt in data.KhenThuongs
        //                          where kt.MaNV == manv.Trim()
        //                          select kt).DefaultIfEmpty().Single<KhenThuong>();
        //    truyvan.TrangThai = "Đã khen thưởng";
        //    return data.SaveChanges() > 0 ? true : false;
        //}

        public static List<object> BN_GetAllStaffBYID(string name)
        {
            QLNVEntities data = new QLNVEntities();
            var staff = from kt in data.KhenThuongs
                        join nv in data.NhanViens
                        on kt.TenNV equals nv.TenNV
                        where kt.TenNV.Contains(name)
                        select new
                        {
                            kt.MaKT,
                            kt.NgayKhenThuong,
                            kt.MaNV,
                            kt.TenNV,
                            kt.NoiDungKT,
                            kt.HinhThuc,
                            kt.TienThuong,
                            kt.TrangThai,
                        };
            List<object> KhenThuongDTOs = new List<object>();
            foreach (var st in staff)
            {
                KhenThuongDTOs.Add(st);
            }
            return KhenThuongDTOs;
        }

    }
}
