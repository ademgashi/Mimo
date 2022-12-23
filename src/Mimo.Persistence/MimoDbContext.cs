using Microsoft.EntityFrameworkCore;
using Mimo.Domain.Models;


namespace Mimo.Persistence
{
    public class MimoDbContext : DbContext
    {
        public MimoDbContext(DbContextOptions<MimoDbContext> options)
            : base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<LessonCompletion> LessonCompletions { get; set; }
        public DbSet<Achievement> Achievements { get; set; }
        public DbSet<UserAchievement> UserAchievements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=mimo.db");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .HasMany(c => c.Chapters)
                .WithOne(ch => ch.Course)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Chapter>()
                .HasMany(ch => ch.Lessons)
                .WithOne(l => l.Chapter)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(u => u.LessonCompletions)
                .WithOne(lc => lc.User)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(u => u.UserAchievements)
                .WithOne(a => a.User)
                .OnDelete(DeleteBehavior.Cascade);

            // define unique constraint on LessonCompletion.UserId and LessonCompletion.LessonId
            // (we might not need this just adding it here to save disk space)

            modelBuilder.Entity<LessonCompletion>()
                .HasIndex(lc => new { lc.UserId, lc.LessonId })
                .IsUnique();

            
        }
    }
}
