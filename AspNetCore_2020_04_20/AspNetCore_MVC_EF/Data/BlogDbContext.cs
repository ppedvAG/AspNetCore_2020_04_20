﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspNetCore_MVC_EF.Models;
using Serilog;

namespace AspNetCore_MVC_EF.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext (DbContextOptions<BlogDbContext> options)
            : base(options)
        {
            Log.Information("BlogDb wurde instanziiert");
        }

        public DbSet<AspNetCore_MVC_EF.Models.Blog> Blog { get; set; }

        public DbSet<AspNetCore_MVC_EF.Models.Comment> Comment { get; set; }
    }
}
