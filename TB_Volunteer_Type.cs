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
    
    public partial class TB_Volunteer_Type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Volunteer_Type()
        {
            this.TB_volunteer = new HashSet<TB_volunteer>();
        }
    
        public int volunteer_type_ID { get; set; }
        public string volunteer_type_Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_volunteer> TB_volunteer { get; set; }
    }
}