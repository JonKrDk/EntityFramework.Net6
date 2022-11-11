using Data;
using Domain;

FootballLeagueDbContext context = new FootballLeagueDbContext();

// Writing

// context.Leagues.Add(new League { Name = "Red Stripe Premiere League" });

//var league = new League { Name = "Liga 2" };
//var team1 = new Team { Name = "Hold 2", League = league };
//var team2 = new Team { Name = "Hold 3", League = league };
//var team3 = new Team { Name = "Hold 4", League = league };

//context.Add(team1);
//context.Add(team2);
//context.Add(team3);

//context.SaveChanges();

// Reading
//var leagues = context.Leagues.ToList();

//foreach (var league in leagues)
//{
//    Console.WriteLine($"{league.Id} {league.Name}");
//}

// Update

//var league = context.Leagues.Find(3);
//league.Name = "Sønder Revl FC";
//context.SaveChanges();

// Delete

var league = context.Leagues.Find(3);

Console.WriteLine(league.Id);
Console.WriteLine(league.Name);
foreach (Team team in league.Teams)
{
    Console.WriteLine("-----------");
    Console.WriteLine(team.Id);
    Console.WriteLine(team.Name);
}
