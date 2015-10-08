using UnityEngine;
using System.Collections;

public class BaseStats 
{
    private int hp;
    private int strengh;
    private int magic;
    private int physical_defense; 
    private int magical_defense;
    private int stamina;

    public BaseStats(int hp, int str, int mag, int phy_def, int mag_def, int stamina)
    {
        this.hp = hp;
        strengh = str;
        magic = mag;
        physical_defense = phy_def;
        magical_defense = mag_def;
        this.stamina = stamina;
    }
    public int HP
    {
        get { return hp; }
        set { hp = value; }
    }
    public int Strengh
    {
        get { return strengh; }
        set { strengh = value; }
    }
    public int Magic
    {
        get { return magic; }
        set { magic = value; }
    }
    public int Physical_defense
    {
        get { return physical_defense; }
        set { physical_defense = value; }
    }
    public int Magical_defense
    {
        get { return magical_defense; }
        set { magical_defense = value; }
    }
    public int Stamina
    {
        get { return stamina; }
        set { stamina = value; }
    }
}
