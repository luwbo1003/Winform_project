//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DA_Winform
{
    using System;
    using System.Collections.Generic;
    
    public partial class KyLuat
    {
        public string MaKL { get; set; }
        public Nullable<System.DateTime> NgayKyLuat { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string NoiDungKL { get; set; }
        public string HinhThuc { get; set; }
        public Nullable<int> TienKL { get; set; }
        public string TrangThai { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
    }
}
