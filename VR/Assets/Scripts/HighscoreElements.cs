using System;

// this is a pure C# class, doesn't have any unity related stuff

[Serializable]
public class HighscoreElements 
{
    public string playerName;
    public int points;

    public HighscoreElements (string name, int points)
    {
        playerName = name;
        this.points = points;
    }
}
