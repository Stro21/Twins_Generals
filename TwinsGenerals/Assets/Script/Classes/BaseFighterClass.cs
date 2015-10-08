using UnityEngine;
using System.Collections;

public class BaseFighterClass : BaseClass
{
	public BaseFighterClass(){
        Class_Name = "Fighter";
        Class_Description = "The basic melee unit";
        Sex = SexSpecific.Unisex;
        Can_Lead = false;
        BaseRace race = new HumanRace();
        Race = race;
        Previous_class = null;
        BaseLevelStats stats1 = new BaseLevelStats(6, 3, 1, 4, 2, 1);
        BaseStats stats = new BaseStats(40, 20, 10, 10, 5, 30);
        Stats = stats;
        Stat_Lvl = stats1;
        BaseAlignment ali = new BaseAlignment(50);
        Alignment = ali;
        Hability = null;
	}
}

