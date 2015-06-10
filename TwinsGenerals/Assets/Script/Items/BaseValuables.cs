using UnityEngine;
using System.Collections;

public class BaseValuables : BaseItem
{
    public enum ValuablesTypes
    {
        PORTABLE,
        TREASURE
    }
    private ValuablesTypes value_types;    
    private int spellEffectID;

    public int SpellEffectID
    {
        get { return spellEffectID; }
        set { spellEffectID = value; }
    }
    public ValuablesTypes Value_Types
    {
        get { return value_types; }
        set { value_types = value; }
    }
} 
