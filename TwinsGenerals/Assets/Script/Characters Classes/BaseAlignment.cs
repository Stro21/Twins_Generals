using UnityEngine;
using System.Collections;

public class BaseAlignment
{
    private Alignment alignment;
    private int ali_min;
    private int ali_max;

    public BaseAlignment(int min, int max)
    {
        ali_min = min;
        ali_max = max;
        current_alignment();
    }

    public int Ali_max
    {
        get { return ali_max; }
        set { ali_max = value; }
    }
    public int Ali_min
    {
        get { return ali_min; }
        set { ali_min = value; }
    }
    
    public Alignment Alignment1
    {
        get { return alignment; }
        set { alignment = value; }
    }
    public enum Alignment
    {
        VERY_CHAOTIC,
        CHAOTIC,
        NEUTRAL_CHAOTIC,
        NEUTRAL,
        NEUTRAL_LAWFUL,
        LAWFUL,
        VERY_LAWFUL
    }

    void current_alignment()
    {
        if (ali_min >= 0 && ali_max < 15)
        {
            alignment = Alignment.VERY_CHAOTIC;
        }
        else if (ali_min > 14 && ali_max < 30)
        {
            alignment = Alignment.CHAOTIC;
        }
        else if (ali_min > 29 && ali_max < 45)
        {
            alignment = Alignment.NEUTRAL_CHAOTIC;
        }
        else if (ali_min > 44 && ali_max < 56)
        {
            alignment = Alignment.NEUTRAL;
        }
        else if (ali_min > 55 && ali_max < 71)
        {
            alignment = Alignment.NEUTRAL_LAWFUL;
        }
        else if (ali_min > 70 && ali_max < 86)
        {
            alignment = Alignment.LAWFUL;
        }
        else if (ali_min > 85 && ali_max <= 100)
        {
            alignment = Alignment.VERY_LAWFUL;
        }
        else
        {
            Debug.LogError("Error, the aligment must be between 0 and 100.");
        }
    }
}
