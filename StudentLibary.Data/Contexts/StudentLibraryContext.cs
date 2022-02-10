﻿using Microsoft.EntityFrameworkCore;
using StudentLibrary.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Data.Contexts
{
    public class StudentLibraryContext:DbContext
    {
        public StudentLibraryContext(DbContextOptions<StudentLibraryContext> dbContextOptions):base(dbContextOptions)
        {
                    
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Operation> Operations { get; set; }
    }
}
