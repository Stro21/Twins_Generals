using UnityEngine;
using System.Collections;

public class BaseLevelStats
{
    private int hp_lvl;
    private int str_lvl;
    private int mag_lvl;
    private int phy_def_lvl; 
    private int magl_def_lvl;
    private int stamina_lvl;

    public BaseLevelStats(int hp, int str, int mag, int phy_def, int mag_def, int stamina)
    {
        this.hp_lvl = hp;
        str_lvl = str;
        mag_lvl = mag;
        phy_def_lvl = phy_def;
        magl_def_lvl = mag_def;
        stamina_lvl = stamina;
    }
    public int HP_Lvl
    {
        get { return hp_lvl; }
        set { hp_lvl = value; }
    }
    public int Str_Lvl
    {
        get { return str_lvl; }
        set { str_lvl = value; }
    }
    public int Mag_Lvl
    {
        get { return mag_lvl; }
        set { mag_lvl = value; }
    }
    public int Phy_Def_Lvl
    {
        get { return phy_def_lvl; }
        set { phy_def_lvl = value; }
    }
    public int Mag_Def_Lvl
    {
        get { return magl_def_lvl; }
        set { magl_def_lvl = value; }
    }
    public int Stamina_lvl
    {
        get { return stamina_lvl; }
        set { stamina_lvl = value; }
    }
}
