using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BiologyManagement.Models.LoincFrance.EnumTable
{
    public class Echelle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [MaxLength(6)]
        [Display(Name = "Code Echelle")]
        public string EchelleId { get; set; }

        [MaxLength(30)]
        [Display(Name = "Label Echelle")]
        [Required]
        public string Label { get; set; }

        public List<ActeBiologique> ActeBiologiques { get; set; }
    }
}
