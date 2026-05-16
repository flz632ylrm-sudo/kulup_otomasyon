using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Club_Otomasyon
{
    [Table("Table_students")]
    internal class student
    {
        [Key]
        public int student_ıd { get; set; }

        [Required]
        [MaxLength(50)]
        public string student_name { get; set; }

        [Required]
        [MaxLength(50)]
        public string student_surname { get; set; }

        [Required]
        [MaxLength(11)]
        public string student_phone { get; set; }

        [Required]
        [MaxLength(100)]
        public string student_department { get; set; }

        [Required]
        [MaxLength(100)]
        public string student_email { get; set; }    
    }
}
