namespace Pharma_Libarary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pay()
        {
            Laboratoires = new HashSet<Laboratoire>();
        }

        [Key]
        [StringLength(3)]
        public string Pays_code { get; set; }

        [Required]
        [StringLength(20)]
        public string pay_nom { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Laboratoire> Laboratoires { get; set; }
    }
}
