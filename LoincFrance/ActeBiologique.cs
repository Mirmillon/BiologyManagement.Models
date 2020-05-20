
using BiologyManagement.Models.LoincFrance.EnumTable;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BiologyManagement.Models.LoincFrance
{
    public class ActeBiologique
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [MaxLength(10)]
        [Display(Name = "Loinc Code")]
        public string LoincCodeId { get; set; }



        [MaxLength(300)]
        [Display(Name = "Libellé de référence")]
        [Required]
        public string LabelReferenceFR { get; set; }

        [MaxLength(300)]
        [Display(Name = "Composant français")]
        public string ComposantFrancais { get; set; }

        [MaxLength(300)]
        [Display(Name = "Composant anglais")]
        public string ComposantAnglais { get; set; }

        [Display(Name = "Date de Validation")]
        public DateTime? DateValidation { get; set; }

        [Display(Name = "Date de retrait")]
        public DateTime? DateRetrait { get; set; }

        [Display(Name = "Date de retrait LOINC")]
        public DateTime? DateRetraitLoinc { get; set; }

        //FK
        [Display(Name = "Chapitre")]
        public string ChapitreId { get; set; }
        public Chapitre Chapitre { get; set; }

        [Display(Name = "Echelle")]
        public string EchelleId { get; set; }
        public Echelle Echelle { get; set; }

        [Display(Name = "Grandeur")]
        public string GrandeurId { get; set; }
        public Grandeur Grandeur { get; set; }

        [Display(Name = "Milieu Biologique")]
        public string MilieuBiologiqueId { get; set; }
        public MilieuBiologique MilieuBiologique { get; set; }

        [Display(Name = "Technique")]
        public string TechniqueId { get; set; }
        public Technique Technique { get; set; }

        [Display(Name = "Temps")]
        public string TempsId { get; set; }
        public Temps Temps { get; set; }

        [Display(Name = "Statut")]
        public int? StatutId { get; set; }
        public Statut Statut { get; set; }

        [Display(Name = "Version")]
        public int? VersionId { get; set; }
        public VersionActe Version { get; set; }

        public List<Remplacement> Remplacements { get; set; }

        public List<ActebiologiqueVersion> ActebiologiqueVersions { get; set; }


    }
}
