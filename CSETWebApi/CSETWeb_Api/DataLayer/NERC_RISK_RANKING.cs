//////////////////////////////// 
// 
//   Copyright 2018 Battelle Energy Alliance, LLC  
// 
// 
//////////////////////////////// 
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class NERC_RISK_RANKING
    {
        public Nullable<int> Question_id { get; set; }
        public Nullable<int> Requirement_Id { get; set; }
        public int Compliance_Risk_Rank { get; set; }
        public string Violation_Risk_Factor { get; set; }
    
        public virtual NEW_QUESTION NEW_QUESTION { get; set; }
        public virtual NEW_REQUIREMENT NEW_REQUIREMENT { get; set; }
    }
}

