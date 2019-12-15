//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfSampleProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public staff()
        {
            this.payment = new HashSet<payment>();
            this.rental = new HashSet<rental>();
            this.store1 = new HashSet<store>();
        }
    
        public byte staff_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int address_id { get; set; }
        public byte[] picture { get; set; }
        public string email { get; set; }
        public int store_id { get; set; }
        public bool active { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public System.DateTime last_update { get; set; }
    
        public virtual address address { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<payment> payment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rental> rental { get; set; }
        public virtual store store { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<store> store1 { get; set; }
    }
}
