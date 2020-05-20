using BiologyManagement.Models.LoincFrance;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BiologyManagement.Models.LoincFrance.EnumTable
{
    public class MilieuBiologique
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [MaxLength(6)]
        [Display(Name = "Code Milieu Biologique")]
        public string MilieuBiologiqueId { get; set; }

        [MaxLength(90)]
        [Display(Name = "Label Milieu Biologique")]
        [Required]
        public string Label { get; set; }

        public List<ActeBiologique> ActeBiologiques { get; set; }
    }
}

