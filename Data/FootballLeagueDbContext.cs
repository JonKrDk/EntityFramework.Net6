using Data.Configurations.Entities;
using Domain;
using Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class FootballLeagueDbContext : AuditableFootballLeageDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Database=FootballLeagueDb;Trusted_Connection=True;MultipleActiveResultSets=true")
                .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information)
                .EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>()
                .HasMany(m => m.HomeMatches)
                .WithOne(m => m.HomeTeam)
                .HasForeignKey(m => m.HomeTeamId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Team>()
                .HasMany(m => m.AwayMatches)
                .WithOne(m => m.AwayTeam)
                .HasForeignKey(m => m.AwayTeamId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Team>().Property(p => p.Name).HasMaxLength(50);
            modelBuilder.Entity<Team>().HasIndex(h => h.Name).IsUnique();
            modelBuilder.Entity<League>().Property(p => p.Name).HasMaxLength(50);
            modelBuilder.Entity<League>().HasIndex(h => h.Name).IsUnique();
            modelBuilder.Entity<Coach>().Property(p => p.Name).HasMaxLength(50);
            // Multiple fields index defined by an anonymous type
            modelBuilder.Entity<Coach>().HasIndex(h => new { h.Name, h.TeamId }).IsUnique();

            modelBuilder.ApplyConfiguration(new LeagueSeedConfiguration());
            modelBuilder.ApplyConfiguration(new TeamSeedConfiguration());
            modelBuilder.ApplyConfiguration(new CoachSeedConfiguration());
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Coach> Coaches{ get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Match> Matches { get; set; }
    }
}
 