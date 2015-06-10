using UnityEngine;
using System.Collections;

public class BaseStatItem : BaseItem
{
    private int strenght;
    private int magic;
    private int physical_defence;
    private int magical_defence;

    public int Strenght
    {
        get { return strenght; }
        set { strenght = value; }
    }
    
    public int Magic
    {
        get { return magic; }
        set { magic = value; }
    }
    public int Physical_defence
    {
        get { return physical_defence; }
        set { physical_defence = value; }
    }

    public int Magical_defence
    {
        get { return magical_defence; }
        set { magical_defence = value; }
    }
}
