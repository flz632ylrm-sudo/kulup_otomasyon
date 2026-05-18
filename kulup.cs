using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club_Otomasyon
{

    [Table("Table_club")]
    internal class kulup
    {
        [Key]
        public int club_ıd { get; set; }

        [Required]
        [MaxLength(100)]
        public string club_name { get; set; }

        public virtual ICollection<Event> events { get; set; }
       
        
    }
}
