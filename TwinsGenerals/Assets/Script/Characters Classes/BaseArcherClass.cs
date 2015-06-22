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
        Race1 = Race.HUMAN;
        Sex = SexSpecific.UNISEX;
        Can_Lead = false;
        Race_Description = "Humans are the are most populated inteligent species.";
        Size = 1;
        Previous_class = null;
        HP_lvl = 3;
        Str_lvl = 1;
        Mag_lvl = 3;
        Phydef_lvl = 2;
        Mag_lvl = 4;
        BaseAlignment ali = new BaseAlignment(45, 55);
        Alignment = ali;
    }
}
