using Data;
using Domain;

FootballLeagueDbContext context = new FootballLeagueDbContext();

// context.Leagues.Add(new League { Name = "Red Stripe Premiere League" });

//var league = new League { Name = "Liga 2" };
//var team1 = new Team { Name = "Hold 2", League = league };
//var team2 = new Team { Name = "Hold 3", League = league };
//var team3 = new Team { Name = "Hold 4", League = league };

//context.Add(team1);
//context.Add(team2);
//context.Add(team3);

//context.SaveChanges();

var leagues = context.Leagues.ToList();

foreach (var league in leagues)
{
    Console.WriteLine($"{league.Id} {league.Name}");
}