using UnityEngine;
using System.Collections;

public class BaseArcherClass : BaseClass {
    public BaseArcherClass()
    {
        Class_Name = "Archer";
        Class_Description = "The basic ranged unit";
        Sex = SexSpecific.Unisex;
        Can_Lead = false;
        BaseRace race = new HumanRace();
        Race = race;
        Previous_class = null;
        BaseLevelStats stats1 = new BaseLevelStats(3, 1, 3, 2, 4, 1);
        BaseStats stats = new BaseStats(30, 15, 15, 5, 10, 30);
        Stats = stats;
        BaseAlignment ali = new BaseAlignment(50);
        Alignment = ali;
        Hability = null;
    }
}
