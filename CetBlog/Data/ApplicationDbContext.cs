using System;
using System.Collections.Generic;
using System.Text;
using CetBlog.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CetBlog.ViewModels;

namespace CetBlog.Data
{
    public class ApplicationDbContext : IdentityDbContext<CetUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }


    }
}
