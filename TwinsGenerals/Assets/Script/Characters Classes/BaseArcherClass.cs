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
    }
}
