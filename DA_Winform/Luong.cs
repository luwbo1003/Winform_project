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
    
    public partial class Luong
    {
        public string MaNV { get; set; }
        public Nullable<int> LuongCoBan { get; set; }
        public Nullable<System.DateTime> NgayLanh { get; set; }
        public string MaKT { get; set; }
        public string MaKL { get; set; }
        public string MaCV { get; set; }
        public Nullable<double> MaLuong { get; set; }
        public Nullable<double> TongLuong { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
    }
}
