//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlackJackDatabase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Uitslagen
    {
        public int uitslag_id { get; set; }
        public Nullable<int> speler_id { get; set; }
        public Nullable<int> spel_id { get; set; }
        public string uitslag { get; set; }
    
        public virtual Speler Speler { get; set; }
        public virtual Spellen Spellen { get; set; }
    }
}