using UnityEngine;
using System.Collections;

public class MageCaptain : BaseClass
{
    public MageCaptain()
    {
        Class_Name = "Mage Captain";
        Class_Description = "This is Erika first class";
        HP = 60;
        Strengh = 10;
        Magic = 30;
        Physical_Defense = 10;
        Magical_Defense = 15;
        Sex = SexSpecific.Female;
        Can_Lead = true;
        BaseRace race = new HumanRace();
        Race = race;
        Previous_class = null;
        HP_lvl = 8;
        Str_lvl = 3;
        Mag_lvl = 5;
        Phydef_lvl = 4;
        Mag_lvl = 6;
        BaseAlignment ali = new BaseAlignment(50);
        Alignment = ali;
        Hability = null;
        Stamina = 40;
        Stamina_lvl = 2;
    }
}
