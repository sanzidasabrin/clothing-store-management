//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VogueLink2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Review
    {
        public int Review_Id { get; set; }
        public string Review1 { get; set; }
        public decimal Rating { get; set; }
        public int Customer_Id { get; set; }
        public int Product_Id { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
