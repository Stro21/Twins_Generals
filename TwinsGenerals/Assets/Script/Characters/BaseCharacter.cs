using UnityEngine;
using System.Collections;

public class BaseCharacter
{
    private string name;
    private int level;
    private BaseClass clase;
    private BaseAlignment current_alignment;
    private BaseStatus current_status;
    private int hp;
    private int strengh;
    private int magic;
    private int physical_defense;
    private int magical_defense;
    private int stamina;
    private Sex sex;
    private Races race;

    public Races Race
    {
        get { return race; }
        set { race = value; }
    }
    public Sex Sex
    {
        get { return sex; }
        set { sex = value; }
    }

    public int Stamina
    {
        get { return stamina; }
        set { stamina = value; }
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

    public int HP
    {
        get { return hp; }
        set { hp = value; }
    }
    

    public BaseStatus Current_Status
    {
        get { return current_status; }
        set { current_status = value; }
    }
    public BaseAlignment Current_Alignment
    {
        get { return current_alignment; }
        set { current_alignment = value; }
    }
    

    public BaseClass Clase
    {
        get { return clase; }
        set { clase = value; }
    }

    public int Level
    {
        get { return level; }
        set { level = value; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    
    
}
