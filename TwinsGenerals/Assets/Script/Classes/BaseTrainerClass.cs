using UnityEngine;
using System.Collections;



public class BaseTrainerClass : BaseClass
{
    public BaseTrainerClass()
    {
        Class_Name = "Trainer";
        Class_Description = "The basic trainer unit";
        BaseRace race = new HumanRace();
        Race = race;
        Sex = SexSpecific.Unisex;
        Can_Lead = false;
        Previous_class = null;
        BaseLevelStats stats_lvl = new BaseLevelStats(2, 2, 2, 3, 3, 1);
        BaseStats stats = new BaseStats(35, 18, 12, 7, 8, 30);
        Stats = stats;
        Stat_Lvl = stats_lvl;
        BaseAlignment ali = new BaseAlignment(50);
        Alignment = ali;
        Hability = null;
    }
}
