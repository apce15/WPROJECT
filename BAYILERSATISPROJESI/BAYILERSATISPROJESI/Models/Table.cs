//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BAYILERSATISPROJESI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;


    public partial class Table
    {
        public int Id { get; set; }
        [DisplayName("�lke")]
        [Required(ErrorMessage = "Bu alan� doldurunuz!!!")]
        public string ulke { get; set; }
        [DisplayName("�ehir")]
        [Required(ErrorMessage = "Bu alan� doldurunuz!!!")]
        public string sehir { get; set; }
        [DisplayName("Bayi ID")]
        [Required(ErrorMessage = "Bu alan� doldurunuz!!!")]
        public Nullable<decimal> bayiid { get; set; }
        [DataType(DataType.Password)]
        [DisplayName("�ifre")]
        [Required(ErrorMessage = "Bu alan� doldurunuz!!!")]
        public Nullable<decimal> sifre { get; set; }
        public string entryErrorMessage { get; set; }

    }
}
