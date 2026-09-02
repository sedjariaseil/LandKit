using LandKit.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

//———————————— DbContext: LandKitDbContext ————————————
// المسؤول على قاعدة البيانات وIdentity ديال LandKit.
namespace LandKit.Infrastructure.Data
{
    public class LandKitDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        //———————————— Constructor ————————————
        public LandKitDbContext(DbContextOptions<LandKitDbContext> options)
            : base(options)
        {
        }

        //———————————— Landing Pages ————————————
        // جدول LandingPages فـDatabase.
        public DbSet<LandingPage> LandingPages => Set<LandingPage>();

        //———————————— Model Configuration ————————————
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //———————————— User → LandingPages ————————————
            // User واحد يقدر يكون عندو بزاف ديال Landing Pages.
            builder.Entity<LandingPage>()
                .HasOne<User>()
                .WithMany(user => user.LandingPages)
                .HasForeignKey(page => page.SellerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
