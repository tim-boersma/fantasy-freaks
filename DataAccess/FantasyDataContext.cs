using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using static DataAccess.GlobalConstants;
using System.Collections.Generic;

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
        public DbSet<PlayerPerformanceDataModel> PlayerPerformance { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DefenseDataModel>().ToTable("Defense");
            modelBuilder.Entity<LastSeasonPlayerDataModel>().ToTable("LastSeasonPlayer");
            modelBuilder.Entity<CurrentPlayerModel>().ToTable("NewSeasonPlayer");
            modelBuilder.Entity<PlayerPerformanceDataModel>().ToTable("PlayerPerformance");
        }
    }
}
