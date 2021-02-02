using EFCore.Persistance.Model;
using Microsoft.EntityFrameworkCore;
using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCore.Persistance
{
    public class EfCoreContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }

        public EfCoreContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder
                .UseSqlServer(@"Server=.\SQLExpress;Database=EFCore;Integrated Security=True;Connect Timeout=30;Trusted_Connection=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
                .UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Team>()
                .HasMany(t => t.Members)
                .WithOne(tm => tm.Team)
                .HasForeignKey(tm => tm.TeamId);

            modelBuilder.Entity<TeamMember>()
                .HasOne(tm => tm.Team).WithMany(t => t.Members);

            /* insert Bogus data */
            var teams = new Faker<Team>().RuleFor(o => o.Name, f => f.Name.FullName());
            var generatedTeams = teams.Generate(6);
            modelBuilder.Entity<Team>().HasData(generatedTeams);

            var teamMembers = new Faker<TeamMember>()
                .RuleFor(o => o.FirstName, f => f.Name.FirstName())
                .RuleFor(o => o.LastName, f => f.Name.LastName())
                .RuleFor(o => o.Title, f => GetRandomTitleType())
                .RuleFor(o => o.TeamId, f => GetRandomTeamId(generatedTeams));

            var generatedembers = teamMembers.Generate(50);
            modelBuilder.Entity<TeamMember>().HasData(generatedembers);
        }

        private static TitleType GetRandomTitleType()
        {
            var result = new Random().Next(0, Enum.GetValues(typeof(TitleType)).Length);
            return (TitleType)result;
        }

        private static Guid GetRandomTeamId(List<Team> teams)
            => teams
                .Select(t => t.Id)
                .OrderBy(o => Guid.NewGuid())
                .FirstOrDefault();
    }
}
