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
    
    public partial class book_loan
    {
        public int book_loan_id { get; set; }
        public int book_id { get; set; }
        public Nullable<int> student_id { get; set; }
        public Nullable<int> user_id { get; set; }
        public System.DateTime date_taken { get; set; }
        public Nullable<System.DateTime> date_return { get; set; }
    
        public virtual book book { get; set; }
        public virtual student student { get; set; }
        public virtual user user { get; set; }
    }
}
