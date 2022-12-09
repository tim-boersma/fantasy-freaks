using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class FantasyDataContext : DbContext
    {
        public FantasyDataContext()
        {
        }

        public FantasyDataContext(DbContextOptions<FantasyDataContext> options) : base(options)
        {
        }

        public DbSet<DefenseDataModel> Defense { get; set; }
        public DbSet<LastSeasonPlayerDataModel> LastSeasonPlayer { get; set; }
        public DbSet<CurrentPlayerModel> CurrentPlayer { get; set; }

        public DbSet<PlayerPerformanceDataModel> Week1Player { get; set; }
        public DbSet<PlayerPerformanceDataModel> Week2Player { get; set; }
        public DbSet<PlayerPerformanceDataModel> Week3Player { get; set; }
        public DbSet<PlayerPerformanceDataModel> Week4Player { get; set; }
        public DbSet<PlayerPerformanceDataModel> Week5Player { get; set; }
        public DbSet<PlayerPerformanceDataModel> Week6Player { get; set; }
        public DbSet<PlayerPerformanceDataModel> Week7Player { get; set; }
        public DbSet<PlayerPerformanceDataModel> Week8Player { get; set; }
        public DbSet<PlayerPerformanceDataModel> Week9Player { get; set; }
        public DbSet<PlayerPerformanceDataModel> Week10Player { get; set; }
        public DbSet<PlayerPerformanceDataModel> Week11Player { get; set; }
        public DbSet<PlayerPerformanceDataModel> Week12Player { get; set; }
        public DbSet<PlayerPerformanceDataModel> Week13Player { get; set; }
        public DbSet<PlayerPerformanceDataModel> Week14Player { get; set; }
        public DbSet<PlayerPerformanceDataModel> Week15Player { get; set; }
        public DbSet<PlayerPerformanceDataModel> Week16Player { get; set; }
        public DbSet<PlayerPerformanceDataModel> Week17Player { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DefenseDataModel>().ToTable("Defense");
            modelBuilder.Entity<LastSeasonPlayerDataModel>().ToTable("LastSeasonPlayer");
            modelBuilder.Entity<CurrentPlayerModel>().ToTable("NewSeasonPlayer");

            for(int i = 1; i <= 17; i++)
            {
                modelBuilder.Entity<PlayerPerformanceDataModel>().ToTable("Week" + i + "Player");
            }

        }
    }
}
