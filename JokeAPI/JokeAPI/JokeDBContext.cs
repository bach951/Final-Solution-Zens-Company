using Microsoft.EntityFrameworkCore;
using System.Security.Principal;

namespace JokeAPI
{
    public class JokeDBContext : DbContext
    {
        public JokeDBContext()
        {
                
        }
        public JokeDBContext(DbContextOptions<JokeDBContext> options) : base(options)
        {

        }

        public DbSet<Content> Content { get; set; }
        public DbSet<Vote> Vote { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder()
                                  .SetBasePath(Directory.GetCurrentDirectory())
                                  .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                IConfigurationRoot configuration = builder.Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("JokeDB"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Joke
            modelBuilder.Entity<Content>(joke =>
            {
                joke.Property(prop => prop.JokeContent).IsUnicode(false).HasMaxLength(500).IsRequired(true);
            });
            #endregion

            #region Vote
            modelBuilder.Entity<Vote>(vote =>
            {
                vote.Property(prop => prop.Favorite);
            });
            #endregion
        }
        
    }
}
