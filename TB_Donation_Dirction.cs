//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FWD
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_Donation_Dirction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Donation_Dirction()
        {
            this.TB_DON = new HashSet<TB_DON>();
        }
    
        public int Donation_Dir_ID { get; set; }
        public string Donation_Dir_Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_DON> TB_DON { get; set; }
    }
}