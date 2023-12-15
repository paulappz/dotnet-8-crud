using dotNetCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace dotNetCrud.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Category> Category{ get; set;}
    }
}

