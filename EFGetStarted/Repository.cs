using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFGetStarted
{
    public class Repository : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public Repository() : base()
        {
            // create if not exists
            if (Database.EnsureCreated())
            {
                Repository context = this;
                Blog blog = new Blog() { Url = "criado.aqui" };
                context.Blogs.Add(blog);
                context.SaveChanges();
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=efgetstarted;Trusted_Connection=True;Encrypt=false;");
        }
    }
}
