using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BiologyManagement.Models.LoincFrance.EnumTable
{
    public class Statut
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [MaxLength(6)]
        [Display(Name = "Code statut")]
        public int StatutId { get; set; }

        [MaxLength(20)]
        [Display(Name = "Statut")]
        [Required]
        public string Label { get; set; }

        public List<ActeBiologique> ActeBiologiques { get; set; }
    }
}

