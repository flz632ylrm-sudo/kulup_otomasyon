using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club_Otomasyon
{
    [Table("Table_event")]
    internal class Event
    {
        [Key]
        public int event_ıd { get; set; }


        [Required,MaxLength(100)]
        public string event_name { get; set; }

        [Required]
        public DateTime event_date { get; set; }

        

        [ForeignKey("kulup")]
        public int club_ıd{ get; set; } 

        public virtual kulup kulup { get; set; }
        public virtual ICollection<StudentEvent>StudentEvents{ get; set; }  


        

    }
}
