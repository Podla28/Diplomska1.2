//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Diplomska1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kriterij
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kriterij()
        {
            this.Kontrolne_Naloge = new HashSet<Kontrolne_Naloge>();
        }
    
        public int ID_Kriterij { get; set; }
        public string Odlično { get; set; }
        public string PravDobro { get; set; }
        public string Dobro { get; set; }
        public string Zadostno { get; set; }
        public string Nezadostno { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kontrolne_Naloge> Kontrolne_Naloge { get; set; }
    }
}