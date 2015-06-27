using UnityEngine;
using System.Collections;

public class BaseRace
{
    private Races race;
    private string race_description;
    private double size;

    public BaseRace(Races race, string description, double size)
    {
        this.race = race;
        race_description = description;
        this.size = size;
    }

    public Races Race1
    {
        get { return race; }
        set { race = value; }
    }
    
    public double Size
    {
        get { return size; }
        set { size = value; }
    }

    public string Race_Description
    {
        get { return race_description; }
        set { race_description = value; }
    }
    
}
public enum Races
{
    HUMAN,
    HAWKMAN,
    DRAGON,
    GOLEM,
    BEAST,
    DEMON
}