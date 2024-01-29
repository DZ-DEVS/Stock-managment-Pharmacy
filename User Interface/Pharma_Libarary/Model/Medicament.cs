namespace Pharma_Libarary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Medicament")]
    public partial class Medicament
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Medicament()
        {
            Générique = new HashSet<Générique>();
            Générique1 = new HashSet<Générique>();
            Selles = new HashSet<Selle>();
        }

        [Key]
        [StringLength(10)]
        public string Ref_med { get; set; }

        [Required]
        [StringLength(20)]
        public string nom_comrsl { get; set; }

        [StringLength(10)]
        public string Form { get; set; }

        [StringLength(10)]
        public string Dossage { get; set; }

        [StringLength(10)]
        public string Conditionnement { get; set; }

        public bool Type { get; set; }

        [StringLength(10)]
        public string Liste { get; set; }

        public bool? Commercialisation { get; set; }

        public bool? Remboursable { get; set; }

        [Column(TypeName = "money")]
        public decimal Tarif { get; set; }

        [Column(TypeName = "money")]
        public decimal PPA { get; set; }

        [Required]
        [StringLength(15)]
        public string edited_by { get; set; }

        [Required]
        [StringLength(10)]
        public string Lab_code { get; set; }

        [Required]
        [StringLength(20)]
        public string nom_Cpharma { get; set; }

        [Required]
        [StringLength(20)]
        public string code_Cthera { get; set; }

        [Required]
        [StringLength(20)]
        public string nom_DCI { get; set; }

        public virtual Classe_pharmacologique Classe_pharmacologique { get; set; }

        public virtual Classe_thérapeutique Classe_thérapeutique { get; set; }

        public virtual DCI DCI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Générique> Générique { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Générique> Générique1 { get; set; }

        public virtual Laboratoire Laboratoire { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Selle> Selles { get; set; }
    }
}
