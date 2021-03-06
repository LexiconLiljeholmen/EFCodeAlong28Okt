﻿using LexiconUniversity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LexiconUniversity.DataAccessLayer {
    public class UniversityContext : DbContext {

        public UniversityContext()
            : base("UniversityContext") {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

    }
}