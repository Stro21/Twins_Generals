using UnityEngine;
using System.Collections;

public class BaseFighterClass : BaseClass
{
	public BaseFighterClass(){
        Class_Name = "Fighter";
        Class_Description = "The basic melee unit";
        HP = 40;
        Strengh = 20;
        Magic = 10;
        Physical_Defense = 10;
        Magical_Defense = 5;
        Race1 = Race.HUMAN;
        Sex = SexSpecific.UNISEX;
        Can_Lead = false;
        Race_Description = "Humans are the are most populated inteligent species.";
        Size = 1;
	}
}

