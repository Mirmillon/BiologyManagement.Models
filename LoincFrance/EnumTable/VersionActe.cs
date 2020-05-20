using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BiologyManagement.Models.LoincFrance.EnumTable
{
    public class VersionActe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [MaxLength(6)]
        [Display(Name = "Code version")]
        public int VersionId { get; set; }

        [MaxLength(8)]
        [Display(Name = "Version")]
        public string Label { get; set; }

        public List<ActeBiologique> ActeBiologiques { get; set; }

        public List<ActebiologiqueVersion> ActebiologiqueVersions { get; set; }
    }
}

