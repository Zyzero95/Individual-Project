using Microsoft.EntityFrameworkCore;
    public class AnimalDb : DbContext
    {
        public AnimalDb(DbContextOptions<AnimalDb> options) : base(options) { }

        public DbSet<Animal> Animals => Set<Animal>();
    }