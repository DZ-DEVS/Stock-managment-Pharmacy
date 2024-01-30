using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharma_Libarary.Model
{
    public partial class UserSession
    {
        [Key]
        public int SessionId { get; set; }

        [ForeignKey("User")]
        [StringLength(15)]
        public string UserId { get; set; }

        public DateTime LoginTime { get; set; }
        public DateTime? LogoutTime { get; set; }

        public virtual User User { get; set; }


    }
}