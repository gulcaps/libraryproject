//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolLibrary0._1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public student()
        {
            this.book_loan = new HashSet<book_loan>();
        }
    
        public int student_id { get; set; }
        public string student_username { get; set; }
        public string student_name { get; set; }
        public string student_surname { get; set; }
        public string student_class { get; set; }
        public int student_number { get; set; }
        public int account_id { get; set; }
        public Nullable<int> verification_id { get; set; }
        public string student_email { get; set; }
        public Nullable<int> file_id { get; set; }
    
        public virtual account account { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<book_loan> book_loan { get; set; }
        public virtual file file { get; set; }
        public virtual verification verification { get; set; }
    }
}