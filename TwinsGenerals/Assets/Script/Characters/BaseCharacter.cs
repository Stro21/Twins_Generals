using UnityEngine;
using System.Collections;

public class BaseCharacter
{
    private string name;
    private int level;
    private BaseClass clase;
    private BaseAlignment current_alignment;
    private BaseStatus current_status;
    private int max_hp;
    private int strengh;
    private int magic;
    private int physical_defense;
    private int magical_defense;
    private int stamina;
    private Sex sex;
    private BaseRace race;
    private bool is_a_protagonist;
    private int current_hp;
    private bool is_a_hero;

    public bool Is_a_Hero
    {
        get { return is_a_hero; }
        set { is_a_hero = value; }
    }

    public int Current_HP
    {
        get { return current_hp; }
        set { current_hp = value; }
    }

    public bool Is_a_protagonist
    {
        get { return is_a_protagonist; }
        set { is_a_protagonist = value; }
    }

    public BaseRace Race
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

    public int Max_HP
    {
        get { return max_hp; }
        set { max_hp = value; }
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
    public static double Current_hp(BaseCharacter character){
        return character.Current_HP;
    }
    public static BaseCharacter change_hp(BaseCharacter p, int hp)
    {
        p.Current_HP = hp;
        return p;
    }
}
