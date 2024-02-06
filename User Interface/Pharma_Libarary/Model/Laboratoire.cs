namespace Pharma_Libarary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Laboratoire")]
    public partial class Laboratoire
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Laboratoire()
        {
            Medicaments = new HashSet<Medicament>();
        }

        [Key]
        [StringLength(10)]
        public string Lab_code { get; set; }

        [Required]
        [StringLength(20)]
        public string Lab_nom { get; set; }

        [StringLength(250)]
        public string Adress { get; set; }

        [StringLength(10)]
        public string tel { get; set; }

        [StringLength(50)]
        public string web_adress { get; set; }

        [Required]
        [StringLength(3)]
        public string pay_code { get; set; }

        public virtual Pay Pay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Medicament> Medicaments { get; set; }
    }
}
