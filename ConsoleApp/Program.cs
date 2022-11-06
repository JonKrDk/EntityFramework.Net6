using Data;
using Domain;

FootballLeagueDbContext context = new FootballLeagueDbContext();

context.Leagues.Add(new League { Name = "Red Stripe Premiere League" });
context.SaveChanges();
