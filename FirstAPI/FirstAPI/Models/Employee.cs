//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FirstAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    [KnownType(typeof(FirstAPI.Models.Company_SDEntities))]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Employee1 = new HashSet<Employee>();
        }

        [DataMember]
        public string Fname { get; set; }
        [DataMember]
        public string Lname { get; set; }
        [DataMember]
        public int SSN { get; set; }
        [DataMember]
        public Nullable<System.DateTime> Bdate { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string Sex { get; set; }
        [DataMember]
        public Nullable<int> Salary { get; set; }
        [DataMember]
        public Nullable<int> Superssn { get; set; }
        [DataMember]
        public Nullable<int> Dno { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employee1 { get; set; }
        public virtual Employee Employee2 { get; set; }
    }
}
