using UnityEngine;
using System.Collections;

public class BaseCharacter
{
    private string name;
    private int level;
    private BaseClass clase;
    private BaseAlignment current_alignment;
    private BaseStatus current_status;
    private int stamina;
    private BaseStats stats;
    private Sex sex;
    private BaseRace race;
    private bool is_a_protagonist;
    private int current_hp;
    private bool is_a_hero;
    private Attribute attribute;
    private int experience;

    public int Experience
    {
        get { return experience; }
        set { experience = value; }
    }

    public Attribute Attribute
    {
        get { return attribute; }
        set { attribute = value; }
    }

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
    public void level_up()
    {
        if (level < 100)
        {
            level++;
            stats.HP = +clase.Stat_Lvl.HP_Lvl;
            stats.Magic = +clase.Stat_Lvl.Mag_Lvl;
            stats.Strengh = +clase.Stat_Lvl.Str_Lvl;
            stats.Physical_defense = +clase.Stat_Lvl.Phy_Def_Lvl;
            stats.Magical_defense = +clase.Stat_Lvl.Mag_Def_Lvl;
            stats.Stamina = +clase.Stat_Lvl.Stamina_lvl;
        }
    }
}
