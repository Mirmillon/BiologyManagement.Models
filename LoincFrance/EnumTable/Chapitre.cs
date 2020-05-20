using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BiologyManagement.Models.LoincFrance.EnumTable
{
    public class Chapitre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [MaxLength(6)]
        [Display(Name = "Code Chapitre")]
        public string ChapitreId { get; set; }

        [MaxLength(60)]
        [Display(Name = "Label Chapitre")]
        [Required]
        public string Label { get; set; }


        public List<ActeBiologique> ActeBiologiques { get; set; }
    }
}
