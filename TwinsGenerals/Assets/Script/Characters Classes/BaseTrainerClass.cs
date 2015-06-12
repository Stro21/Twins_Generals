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
        Race1 = BaseRace.Race.HUMAN;
        Race_Description = "Humans are the are most populated inteligent species.";
        Size = 1;
        Sex = SexSpecific.UNISEX;
        Can_Lead = false;
    }
}
