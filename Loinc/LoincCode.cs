using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BiologyManagement.Models.Loinc
{
    public class LoincCode
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [MaxLength(10)]
        [Display(Name = "Loinc Code")]
        public string LoincCodeId { get; set; }
        [Display(Name = "Fully Specified Name")]
        public string FullySpecifiedName { get; set; }
    }
}
