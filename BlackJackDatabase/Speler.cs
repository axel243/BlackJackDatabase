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
    using BlackJackDatabase.Repository_s;
    using System;
    using System.Collections.Generic;
    
    public partial class Speler: IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Speler()
        {
            this.Sessies = new HashSet<Sessie>();
            this.Uitslagens = new HashSet<Uitslagen>();
        }
    
        public int speler_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sessie> Sessies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Uitslagen> Uitslagens { get; set; }
    }
}
