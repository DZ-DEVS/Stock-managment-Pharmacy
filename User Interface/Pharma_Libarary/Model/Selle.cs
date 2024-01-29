namespace Pharma_Libarary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Selle
    {
        [Key]
        public int orderID { get; set; }

        [Required]
        [StringLength(10)]
        public string Ref_med { get; set; }

        public int Qts { get; set; }

        [Required]
        [StringLength(10)]
        public string sellerID { get; set; }

        [Required]
        [StringLength(15)]
        public string userName { get; set; }

        public virtual Medicament Medicament { get; set; }

        public virtual User User { get; set; }
    }
}
