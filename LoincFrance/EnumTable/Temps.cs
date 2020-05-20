using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BiologyManagement.Models.LoincFrance.EnumTable
{
    public class Temps
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [MaxLength(6)]
        [Display(Name = "Code Temps")]
        public string TempsId { get; set; }

        [MaxLength(45)]
        [Display(Name = "Label Temps")]
        [Required]
        public string Label { get; set; }

        public List<ActeBiologique> ActeBiologiques { get; set; }
    }
}

