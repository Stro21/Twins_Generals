using UnityEngine;
using System.Collections;

public class WarriorCaptain : BaseClass
{
    public WarriorCaptain()
    {
        Class_Name = "Warrior Captain";
        Class_Description = "This is a protagonist first class, is a warrior but you have to choose between Eduardo or Erika, the other will be a Magician Captain.";
        Sex = SexSpecific.Unisex;
        Can_Lead = true;
        BaseRace race = new HumanRace();
        Race = race;
        Previous_class = null;
        BaseStats stats = new BaseStats(60, 30, 10, 15, 10);
        BaseLevelStats stats_lvl = new BaseLevelStats(8, 5, 3, 6, 4);
        Stats = stats;
        Stat_Lvl = stats_lvl;
        BaseAlignment ali = new BaseAlignment(50);
        Alignment = ali;
        Hability = null;
        Stamina = 40;
        Stamina_lvl = 2;
    }
}
