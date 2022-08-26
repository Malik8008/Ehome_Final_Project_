using Ehome_BackEnd.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ehome_BackEnd.DAL
{
    public class AppDbContext: IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Setting>().HasIndex(k => k.Key).IsUnique();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Partnyor> Partnyors { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Futniture> Futnitures { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<FurnitureImage> FurnitureImages { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Country> Countries { get; set; }   
        public DbSet<Order> Orders { get; set; }
        public DbSet<Matreal> Matreals { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Campaing> Campaings { get; set; }
        public DbSet<WishlistItem> Wishlist { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
