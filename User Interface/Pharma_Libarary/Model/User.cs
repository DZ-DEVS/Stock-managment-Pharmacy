namespace Pharma_Libarary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Medicaments = new HashSet<Medicament>();
            Selles = new HashSet<Selle>();
        }

        [Key]
        [StringLength(15)]
        public string userName { get; set; }

        [Required]
        [StringLength(25)]
        public string password { get; set; }

        [Required]
        [StringLength(15)]
        public string nom { get; set; }

        [Required]
        [StringLength(15)]
        public string prenom { get; set; }

        public bool? isAdmin { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Medicament> Medicaments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Selle> Selles { get; set; }
    }
}
