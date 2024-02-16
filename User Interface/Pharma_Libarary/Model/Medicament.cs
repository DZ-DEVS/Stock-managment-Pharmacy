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
            stocklists = new HashSet<stocklist>();
            Selles = new HashSet<Selle>();
        }
        public Medicament(string ref_med, string nom_comrsl, string form, string dossage, string conditionnement, decimal tarif, decimal pPA, Laboratoire lab, Classe_pharmacologique classe_pharmacologique, Classe_thérapeutique classe_thérapeutique, DCI dCI, User user)
        {
            Ref_med = ref_med;
            this.nom_comrsl = nom_comrsl;
            Form = form;
            Dossage = dossage;
            Conditionnement = conditionnement;
            Tarif = tarif;
            PPA = pPA;
            this.edited_by = user.userName;
            this.Lab_code = lab.Lab_code;
            this.nom_Cpharma = classe_pharmacologique.nom_Cpharma;
            this.code_Cthera = classe_thérapeutique.code_Cthera;
            this.nom_DCI = dCI.nom_DCI;
            //this.Classe_pharmacologique = classe_pharmacologique;
            //this.Classe_thérapeutique = classe_thérapeutique;
            //this.DCI = dCI;
            //this.Laboratoire = lab;
            //this.User = user;
            Générique = new HashSet<Générique>();
            Générique1 = new HashSet<Générique>();
            Selles = new HashSet<Selle>();
        }
        [Key]
        [StringLength(20)]
        public string Ref_med { get; set; }

        [Required]
        [StringLength(50)]
        public string nom_comrsl { get; set; }

        [StringLength(50)]
        public string Form { get; set; }

        [StringLength(50)]
        public string Dossage { get; set; }

        [StringLength(10)]
        public string Conditionnement { get; set; }

        public bool? Type { get; set; }

        [StringLength(10)]
        public string Liste { get; set; }

        public bool? Commercialisation { get; set; }

        public bool? Remboursable { get; set; }

        [Column(TypeName = "money")]
        public decimal? Tarif { get; set; }

        [Column(TypeName = "money")]
        public decimal? PPA { get; set; }

        [Required]
        [StringLength(15)]
        public string edited_by { get; set; }

        [StringLength(50)]
        public string Lab_code { get; set; }

        [StringLength(100)]
        public string nom_Cpharma { get; set; }

        [StringLength(100)]
        public string code_Cthera { get; set; }

        [StringLength(100)]
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
        public virtual ICollection<stocklist> stocklists { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Selle> Selles { get; set; }
    }
}
