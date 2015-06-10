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
	}
}

