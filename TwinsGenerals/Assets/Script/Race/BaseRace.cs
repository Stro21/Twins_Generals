using UnityEngine;
using System.Collections;

public class BaseRace
{
    private Races race;
    private string race_description;
    private double size;
    private double extra_size;

    public double Extra_Size
    {
        get { return extra_size; }
        set { extra_size = value; }
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
    public bool wrong_size(double size)
    {
        return size == 1;
    }

    public bool wrong_extra_size(double extra)
    {
        return extra == 0.5 || extra == 0;
    }
    public static double Size1(BaseRace race1)
    {
        return race1.Size;
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