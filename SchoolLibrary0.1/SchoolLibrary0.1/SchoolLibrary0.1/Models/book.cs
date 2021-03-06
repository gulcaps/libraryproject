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
    
    public partial class book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public book()
        {
            this.book_category = new HashSet<book_category>();
            this.book_loan = new HashSet<book_loan>();
        }
    
        public int book_id { get; set; }
        public string book_title { get; set; }
        public string book_isbn { get; set; }
        public string book_number { get; set; }
        public string book_format { get; set; }
        public bool book_status { get; set; }
        public int category_id { get; set; }
        public string book_language { get; set; }
        public Nullable<int> file_id { get; set; }
        public int author_id { get; set; }
    
        public virtual author author { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
      
        
        public virtual ICollection<book_category> book_category { get; set; }
        public virtual file file { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<book_loan> book_loan { get; set; }
    }
}
