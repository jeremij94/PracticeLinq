using System;
using System.Linq;

//Exercise 2:
//Use the list of
//Linq methods
//for help
//Create a new console app and name it PracticeLinq.
//Create a list of video game names...
//Order the list of games by length of the game name.
//Use the lambda expression in this exercise as well.
//use Method Syntax for this exercise

List<string> videoGames = new List<string>
{
    "Mortal Kombat",
    "Street Fighter",
    "Tekken",
    "Soul Calibur",
    "Final Fight",
    "Killer Instinct",
    "Virtua Fighter",
    "Dead or Alive",
    "Super Smash Bros."
};

//Method Syntax

IEnumerable<string> inOrderGames = videoGames.OrderBy(game => game.Length);
foreach (var game in inOrderGames)
{
    Console.WriteLine(game);
    Console.WriteLine();
}
Console.ReadLine();

//Query Syntax

var newOrderedGames = from game in videoGames
                   orderby game.Length
                   select game;
foreach (var game in newOrderedGames)
    {
    Console.WriteLine(game);
    Console.WriteLine();
    }
Console.ReadLine();
                    

