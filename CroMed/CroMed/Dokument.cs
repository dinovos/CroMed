//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CroMed
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dokument
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dokument()
        {
            this.PromjeneStanjaDokumenta = new HashSet<PromjeneStanjaDokumenta>();
            this.StavkeDokumenta = new HashSet<StavkeDokumenta>();
        }
    
        public int Id { get; set; }
        public int PoslovniSubjekt { get; set; }
    
        public virtual PoslovniSubjekt PoslovniSubjekt1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PromjeneStanjaDokumenta> PromjeneStanjaDokumenta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StavkeDokumenta> StavkeDokumenta { get; set; }
    }
}
