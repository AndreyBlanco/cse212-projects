/*
 * CSE 212 Lesson 6C 
 * 
 * This code will analyze the NBA basketball data and create a table showing
 * the players with the top 10 career points.
 * 
 * Note about columns:
 * - Player ID is in column 0
 * - Points is in column 8
 * 
 * Each row represents the player's stats for a single season with a single team.
 */

using System.Linq;
using Microsoft.VisualBasic.FileIO;

public class Basketball
{
    public static void Run()
    {
        var players = new Dictionary<string, int>();

        using var reader = new TextFieldParser("basketball.csv");
        reader.TextFieldType = FieldType.Delimited;
        reader.SetDelimiters(",");
        reader.ReadFields(); // ignore header row
        while (!reader.EndOfData) {
            var fields = reader.ReadFields()!;
            var playerId = fields[0];
            var points = int.Parse(fields[8]);
            if (players.ContainsKey(playerId))
                players[playerId] += points;
            else
                players[playerId] = points;
        }

        //Console.WriteLine($"Players: {{{string.Join(", ", players)}}}");

        var topPlayers = new string[10];
        var ordertopPlayers = new string[10];

        foreach (var player in players)
        {
            for (var i = 0; i < 10; i++)
            {
                if (topPlayers[i] == null)
                {
                    topPlayers[i] = player.Key;
                    break;
                }

                if (player.Value > players[topPlayers[i]])
                {
                    topPlayers[i] = player.Key;
                    break;
                }
            }
        }

        Console.WriteLine($"Players: {{{string.Join(", ", topPlayers)}}}");

        var order = players.OrderByDescending(par => par.Value).Take(10);

        var count = 0;
        foreach (var play in order)
        {
            ordertopPlayers[count] = play.Key;
            count++;
        }

        Console.WriteLine($"Players: {{{string.Join(", ", ordertopPlayers)}}}");

        var topPlayersol = players.ToArray();
        Array.Sort(topPlayersol, (p1, p2) => p2.Value - p1.Value);

        Console.WriteLine();
        for (var i = 0; i < 10; ++i)
        {
            Console.WriteLine(topPlayersol[i]);
        }

    }
}