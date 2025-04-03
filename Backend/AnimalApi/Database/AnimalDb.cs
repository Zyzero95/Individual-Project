using Microsoft.EntityFrameworkCore;
// AnimalDb initiates a query for the Animal model class towards the Database.
    public class AnimalDb : DbContext
    {
        public AnimalDb(DbContextOptions<AnimalDb> options) : base(options) { }

        public DbSet<Animal> Animals => Set<Animal>();
    }