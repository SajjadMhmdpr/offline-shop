using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using bussiness_entity;

namespace data_acsess
{
    class DB : DbContext
    {
        public DB() : base("shop_project") { }
        public DbSet<customer> customers { get; set; }
        public DbSet<manager> managers { get; set; }
        public DbSet<kala> kalaha { get; set; }
        public DbSet<sabad> sabadha { get; set; }
        public DbSet<choose_kala> choose_kala { get; set; }
        public DbSet<tarikhche> tarikhcheha { get; set; }

    }
}
