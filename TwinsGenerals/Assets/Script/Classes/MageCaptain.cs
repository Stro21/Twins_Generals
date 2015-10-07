using UnityEngine;
using System.Collections;

public class MageCaptain : BaseClass
{
    public MageCaptain()
    {
        Class_Name = "Mage Captain";
        Class_Description = "This is protagonist first class, is a magician but you have to choose between Eduardo or Erika, the other will be a Warrior Captain.";
        Sex = SexSpecific.Unisex;
        Can_Lead = true;
        BaseRace race = new HumanRace();
        Race = race;
        Previous_class = null;
        BaseLevelStats stats_lvl = new BaseLevelStats(8, 3, 5, 4, 6);
        BaseStats stats = new BaseStats(60, 10, 30, 10, 15);
        Stats = stats;
        Stat_Lvl = stats_lvl;
        BaseAlignment ali = new BaseAlignment(50);
        Alignment = ali;
        Hability = null;
        Stamina = 40;
        Stamina_lvl = 2;
    }
}
