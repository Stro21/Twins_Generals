﻿using UnityEngine;
using System.Collections;

public class WarriorCaptain : BaseClass
{
    public WarriorCaptain()
    {
        Class_Name = "Warrior Captain";
        Class_Description = "This is Eduardo first class";
        HP = 60;
        Strengh = 30;
        Magic = 10;
        Physical_Defense = 15;
        Magical_Defense = 10;
        Sex = SexSpecific.Male;
        Can_Lead = true;
        BaseRace race = new HumanRace();
        Race = race;
        Previous_class = null;
        HP_lvl = 8;
        Str_lvl = 5;
        Mag_lvl = 3;
        Phydef_lvl = 6;
        Mag_lvl = 4;
        BaseAlignment ali = new BaseAlignment(50);
        Alignment = ali;
        Hability = null;
        Stamina = 40;
        Stamina_lvl = 2;
    }
}
