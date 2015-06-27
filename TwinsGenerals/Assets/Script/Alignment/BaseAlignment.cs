using UnityEngine;
using System.Collections;

public class BaseAlignment
{
    private Alignment alignment;
    private int alig;

    public int Alig
    {
        get { return alig; }
        set { alig = value; }
    }

    public BaseAlignment(int ali)
    {
        alig = ali;
        current_alignment();
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
        if (alig >= 0 && alig < 15)
        {
            alignment = Alignment.VERY_CHAOTIC;
        }
        else if (alig > 14 && alig < 30)
        {
            alignment = Alignment.CHAOTIC;
        }
        else if (alig > 29 && alig < 45)
        {
            alignment = Alignment.NEUTRAL_CHAOTIC;
        }
        else if (alig > 44 && alig < 56)
        {
            alignment = Alignment.NEUTRAL;
        }
        else if (alig > 55 && alig < 71)
        {
            alignment = Alignment.NEUTRAL_LAWFUL;
        }
        else if (alig > 70 && alig < 86)
        {
            alignment = Alignment.LAWFUL;
        }
        else if (alig > 85 && alig <= 100)
        {
            alignment = Alignment.VERY_LAWFUL;
        }
        else
        {
            Debug.LogError("Error, the aligment must be between 0 and 100.");
        }
    }
}
