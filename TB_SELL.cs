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
    
    public partial class TB_SELL
    {
        public int ID { get; set; }
        public Nullable<int> SELL_Person_Code { get; set; }
        public string SELL_Resv_Name { get; set; }
        public Nullable<int> SELL_Cat { get; set; }
        public Nullable<System.DateTime> SELL_Date { get; set; }
        public Nullable<int> SELL_Num { get; set; }
        public Nullable<int> SELL_Charity_Rcever { get; set; }
    
        public virtual TB_Emploee TB_Emploee { get; set; }
        public virtual TB_PUR TB_PUR { get; set; }
        public virtual TB_Registered_Users TB_Registered_Users { get; set; }
    }
}