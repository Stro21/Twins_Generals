using UnityEngine;
using System.Collections;

public class BaseMaleCaptain : BaseClass
{
    public BaseMaleCaptain()
    {
        Class_Name = "Male Captain";
        Class_Description = "This is Eduardo first class";
        HP = 60;
        Strengh = 25;
        Magic = 15;
        Physical_Defense = 15;
        Magical_Defense = 10;
        Race1 = Race.HUMAN;
        Sex = SexSpecific.MALE;
        Can_Lead = true;
        Race_Description = "Humans are the are most populated inteligent species.";
        Size = 1;
        Previous_class = null;
        HP_lvl = 8;
        Str_lvl = 5;
        Mag_lvl = 3;
        Phydef_lvl = 6;
        Mag_lvl = 4;
        BaseAlignment ali = new BaseAlignment(50);
        Alignment = ali;
        Is_a_Protagonist = true;
        string h_d = "This can ignore a portion of the enemy physical defense";
        BaseSpecialHability special_hability = new BaseSpecialHability("Armor Penetration", h_d);
        Hability = special_hability;
    }
}
