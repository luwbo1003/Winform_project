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
    
    public partial class KyCong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KyCong()
        {
            this.KyCongChiTiets = new HashSet<KyCongChiTiet>();
        }
    
        public string MaKC { get; set; }
        public int thang { get; set; }
        public int nam { get; set; }
        public System.DateTime ngaytinhcong { get; set; }
        public Nullable<int> ngaycongtrongthang { get; set; }
        public Nullable<bool> trangthai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KyCongChiTiet> KyCongChiTiets { get; set; }
    }
}
