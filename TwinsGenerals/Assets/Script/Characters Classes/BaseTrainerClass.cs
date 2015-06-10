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
    }
}
