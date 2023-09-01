using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SecondHandBass.Core.Models;

namespace SecondHandBass.DataAccessLayer.DataContexts
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        private readonly IConfiguration configuration;
        public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration) : base(options)
        {
            this.configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.configuration.GetConnectionString("AppConnectionString"), opt =>
            {
                opt.EnableRetryOnFailure(3);

            });
        }
        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<AdvertisementPicture> AdvertisementPictures { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Conversation> Conversations { get; set; }
        public DbSet<ConversationMessage> ConversationMessages { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Model> Models { get; set; }
    }
}
