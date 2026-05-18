using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Club_Otomasyon
{
    internal class studentsDbContext : DbContext
    {
        public studentsDbContext() : base("name=studentsDbContext")
        {
        }
        public DbSet<student> students { get; set; }
        public DbSet<kulup> clubs { get; set; }

        public DbSet<Event> events { get; set; }
        public DbSet<StudentEvent> studentEvents  { get; set; }
    }
}
