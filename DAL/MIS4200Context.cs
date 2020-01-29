﻿using System;
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
          
        }
        public DbSet<Student> Student { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }

    }
}