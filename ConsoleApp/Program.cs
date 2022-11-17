using Data;
using Domain;
using Microsoft.EntityFrameworkCore;

FootballLeagueDbContext context = new FootballLeagueDbContext();

// Writing

context.Leagues.Add(new League { Name = "Red Stripe Premiere League" });

var league = new League { Name = "Liga 2" };
var team1 = new Team { Name = "Hold 2", League = league };
var team2 = new Team { Name = "Hold 3", League = league };
var team3 = new Team { Name = "Hold 4", League = league };

context.Add(team1);
context.Add(team2);
context.Add(team3);

context.SaveChanges();

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

//var league = context.Leagues.Find(3);

//Console.WriteLine(league.Id);
//Console.WriteLine(league.Name);
//foreach (Team team in league.Teams)
//{
//    Console.WriteLine("-----------");
//    Console.WriteLine(team.Id);
//    Console.WriteLine(team.Name);
//}


// Seeding data start

//var random = new Random();

//foreach (Match match in context.Matches)
//{
//    context.Matches.Remove(match);
//}
//foreach (Coach coach in context.Coaches)
//{
//    context.Coaches.Remove(coach);
//}
//foreach (Team team in context.Teams)
//{
//    context.Teams.Remove(team);
//}
//foreach (League league in context.Leagues)
//{
//    context.Leagues.Remove(league);
//}

//context.SaveChanges();

//for (int n = 0; n < 3; n++)
//{
//    var league = new League()
//    {
//        Name = $"League Number {n + 1}"
//    };

//    context.Leagues.Add(league);
//}

//context.SaveChanges();

//for (int n = 0; n < 10; n++)
//{
//    var team = new Team()
//    {
//        Name = $"Team Number {n}",
//        LeagueId = context.Leagues.ToList()[random.Next(context.Leagues.ToList().Count)].Id
//    };

//    context.Teams.Add(team);
//}

//context.SaveChanges();

//var teams = context.Teams.ToList();

//for (int n = 0; n < 10; n++)
//{
//    var coach = new Coach()
//    {
//        Name = $"Coach Number {n}",
//        TeamId = teams[n].Id
//    };

//    context.Coaches.Add(coach);
//}

//context.SaveChanges();

//for (int n = 0; n < 10; n++)
//{
//    for (int m = 0; m < 10; m++)
//    {
//        if (n != m) {
//            var match = new Match()
//            {
//                AwayTeamId = context.Teams.ToList()[n].Id,
//                HomeTeamId = context.Teams.ToList()[m].Id,
//                Date= DateTime.Now
//            };

//            context.Matches.Add(match);
//        }
//    }
//}

//context.SaveChanges();

// Seeding data end

//var leagues = context.Leagues.Include(league => league.Teams).ToList();

//var teams = context.Teams
//    .Include(q => q.AwayMatches).ThenInclude(q => q.HomeTeam)
//    .Include(q => q.HomeMatches).ThenInclude(q => q.AwayTeam)
//    .FirstOrDefault(q => q.Id == 80);

//var teams2 = context.Teams.Include(q => q.Coach).Select(q => new { TeamName = q.Name, CoachName = q.Coach.Name }).ToList();

//int a = 0;