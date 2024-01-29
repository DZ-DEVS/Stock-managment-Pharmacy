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

        public virtual Medicament Medicament { get; set; }
    }
}
