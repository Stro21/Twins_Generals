using UnityEngine;
using System.Collections;

public class BaseRace
{
    private Race race;
    private string race_description;
    private double size;

    public Race Race1
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
    public enum Race
    {
        HUMAN,
        HAWKMAN,
        DRAGON,
        GOLEM,
        BEAST,
        DEMON
    }
}
