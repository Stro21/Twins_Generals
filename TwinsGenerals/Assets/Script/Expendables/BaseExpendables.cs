using UnityEngine;
using System.Collections;

public class BaseExpendables : BaseItem
{
    private ExpendablesTypes expendables_types;
    private int spellEffectID;

    public int SpellEffectID
    {
        get { return spellEffectID; }
        set { spellEffectID = value; }
    }

    public ExpendablesTypes Expendables_types
    {
        get { return expendables_types; }
        set { expendables_types = value; }
    }
}
public enum ExpendablesTypes
{
    Curatives,
    Supplamentals,
    Others
}