using System;
using System.Collections.Generic;
using System.Data.Entity;
using rc019415MIS4200.Models;
using System.Linq;
using System.Web;

namespace rc019415MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context, rc019415MIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));
        }
        public DbSet<Student> Student { get; set; }

        public DbSet <Classes> Classes { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }

}