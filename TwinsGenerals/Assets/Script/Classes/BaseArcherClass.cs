using UnityEngine;
using System.Collections;

public class BaseArcherClass : BaseClass {
    public BaseArcherClass()
    {
        Class_Name = "Archer";
        Class_Description = "The basic ranged unit";
        HP = 30;
        Strengh = 15;
        Magic = 15;
        Physical_Defense = 5;
        Magical_Defense = 10;
        Sex = SexSpecific.Unisex;
        Can_Lead = false;
        BaseRace race = new BaseRace(Races.HUMAN, "Humans are the are most populated inteligent species.", 1);
        Race = race;
        Previous_class = null;
        HP_lvl = 3;
        Str_lvl = 1;
        Mag_lvl = 3;
        Phydef_lvl = 2;
        Mag_lvl = 4;
        BaseAlignment ali = new BaseAlignment(50);
        Alignment = ali;
        Is_a_Protagonist = false;
        Hability = null;
        Stamina = 30;
        Stamina_lvl = 1;
    }
}
