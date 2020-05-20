using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BiologyManagement.Models.LoincFrance.EnumTable
{
    public class Grandeur
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [MaxLength(6)]
        [Display(Name = "Code Grandeur")]
        public string GrandeurId { get; set; }

        [MaxLength(50)]
        [Display(Name = "Label Grandeur")]
        [Required]
        public string Label { get; set; }

        public List<ActeBiologique> ActeBiologiques { get; set; }
    }
}

