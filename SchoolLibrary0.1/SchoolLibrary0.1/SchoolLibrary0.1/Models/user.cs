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
    
    public partial class user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user()
        {
            this.book_loan = new HashSet<book_loan>();
        }
    
        public int user_id { get; set; }
        public string user_username { get; set; }
        public string user_firstname { get; set; }
        public string user_surname { get; set; }
        public string user_email { get; set; }
        public Nullable<int> file_id { get; set; }
        public int account_id { get; set; }
        public Nullable<int> verification_id { get; set; }
    
        public virtual account account { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<book_loan> book_loan { get; set; }
        public virtual file file { get; set; }
        public virtual verification verification { get; set; }
    }
}