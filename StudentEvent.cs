using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club_Otomasyon
{
    [Table("Table_student_event")]
    internal class StudentEvent
    {
        [Key]
        public int stuEvent_ıd { get; set; }

        [ForeignKey("Student")]
        public int student_ıd { get; set; }
        [ForeignKey("Event")]
        public int event_ıd { get; set; }
        public virtual student Student { get; set; }
        public virtual Event Event { get; set; }
    }
}
