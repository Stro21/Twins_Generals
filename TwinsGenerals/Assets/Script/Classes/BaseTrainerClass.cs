using UnityEngine;
using System.Collections;


public class BaseTrainerClass : BaseClass
{
    public BaseTrainerClass()
    {
        Class_Name = "Trainer";
        Class_Description = "The basic trainer unit";
        HP = 35;
        Strengh = 18;
        Magic = 12;
        Physical_Defense = 7;
        Magical_Defense = 8;
        BaseRace race = new HumanRace();
        Race = race;
        Sex = SexSpecific.Unisex;
        Can_Lead = false;
        Previous_class = null;
        HP_lvl = 2;
        Str_lvl = 2;
        Mag_lvl = 2;
        Phydef_lvl = 3;
        Mag_lvl = 3;
        BaseAlignment ali = new BaseAlignment(50);
        Alignment = ali;
        Hability = null;
        Stamina = 30;
        Stamina_lvl = 1;
    }
}
