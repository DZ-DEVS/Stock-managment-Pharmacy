namespace Pharma_Libarary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Générique
    {
        [Key]
        [StringLength(20)]
        public string Ref_generique_origine { get; set; }

        [Required]
        [StringLength(10)]
        public string ref_med_origine { get; set; }

        [Required]
        [StringLength(10)]
        public string ref_med_generique { get; set; }

        public virtual Medicament Medicament { get; set; }

        public virtual Medicament Medicament1 { get; set; }
    }
}
