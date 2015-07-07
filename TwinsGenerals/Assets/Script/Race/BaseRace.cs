using UnityEngine;
using System.Collections;

public class BaseRace
{
    private Races race;
    private string race_description;
    private int size;
    private double extra_size;
    private double square_size = 1;

    public double Square_Size
    {
        get { return square_size; }
        set { square_size = value; }
    }

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
    
    public int Size
    {
        get { return size; }
        set { size = value; }
    }

    public string Race_Description
    {
        get { return race_description; }
        set { race_description = value; }
    }
    public bool correct_size(int size)
    {
        return size == 1 || size == 2;
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