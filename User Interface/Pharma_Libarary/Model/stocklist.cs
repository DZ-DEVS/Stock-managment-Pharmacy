namespace Pharma_Libarary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stocklist")]
    public partial class stocklist
    {
        [Key]
        public int ref_stock { get; set; }

        [Required]
        [StringLength(20)]
        public string ref_med { get; set; }

        [StringLength(15)]
        public string nom_fourni { get; set; }

        [StringLength(15)]
        public string prenom_fourni { get; set; }

        public int Qts { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateComm_achat { get; set; }

        [Column(TypeName = "date")]
        public DateTime date_Expiration { get; set; }

        [Required]
        [StringLength(15)]
        public string edited_by { get; set; }

        public virtual Medicament Medicament { get; set; }

        public virtual User User { get; set; }
    }
}
