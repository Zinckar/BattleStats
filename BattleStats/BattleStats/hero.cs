//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BattleStats
{
    using System;
    using System.Collections.Generic;
    
    public partial class hero
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hero()
        {
            this.hero_duel = new HashSet<hero_duel>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string fullName { get; set; }
        public string upperName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hero_duel> hero_duel { get; set; }
    }
}
