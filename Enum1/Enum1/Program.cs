using System;

public class Enums
{
    public static void Main()
    {
        Player[] players = new Player[3];

        players[0] = new Player
        {
            playerName = "Matt Duchene",
            nhlPosition = nhlPosition.Skater
        };

        players[1] = new Player
        {
            playerName = "Semyon Varlamov",
            nhlPosition = nhlPosition.Goaile
        };

        players[2] = new Player
        {
            playerName = "Joe Schmoe",
            nhlPosition = nhlPosition.Unknown
        };
    }
}


public enum nhlPosition
{
    Unknown,
    Skater,
    Goaile
}

public class noEnums
{
    public static void Main()
    {
        Player[] players = new Player[3];

        players[0] = new Player
        {
            playerName = "Matt Duchene",
            nhlPosition = 1
        };

        players[1] = new Player
        {
            playerName = "Semyon Varlamov",
            nhlPosition = 2
        };

        players[2] = new Player
        {
            playerName = "Joe Schmoe",
            nhlPosition = 0
        };
    }
}


public enum nhlPosition
{
    Unknown,
    Skater,
    Goaile
}
