

namespace JwtWebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder
                .UseSqlServer("Server=(localdb)\\Raph_Local;Database=userdb;Trusted_Connection=True;");
        }

        public DbSet<User> Users => Set<User>();
    }
}
