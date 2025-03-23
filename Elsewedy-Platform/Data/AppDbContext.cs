using Elsewedy_Platform.Models;
using Elsewedy_Platform.repo_courses.projects;
using Elsewedy_Platform2.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApi_Abdelrhman_khaled_0522015_S4.Data
{
    public class AppDbContext:DbContext
    {
       public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
       public DbSet<Porject_Information> porject_Information { get; set; }
       public DbSet<Teacher> teachers { get; set; }
       public DbSet<Achivments> Achivments { get; set; }
 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>().HasKey(x => x.Id);
            modelBuilder.Entity<Porject_Information>().HasIndex(x => x.email).IsUnique();
            base.OnModelCreating(modelBuilder);
        }
        
    }
}
