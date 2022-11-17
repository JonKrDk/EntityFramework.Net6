using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations.Entities
{
    public class TeamSeedConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasData(
                new Team
                {
                    Id = 20,
                    Name = "Team 1",
                    LeagueId = 20
                },
                new Team
                {
                    Id = 21,
                    Name = "Team 2",
                    LeagueId = 20
                },
                new Team
                {
                    Id = 22,
                    Name = "Team 3",
                    LeagueId = 20
                }
            );
        }
    }
}
