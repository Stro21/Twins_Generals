using UnityEngine;
using System.Collections;

public class BaseAccesories : BaseItem
{
    public enum AccesoriesTypes
    {
        NON_CLASS_SPECIFIC,
        CLASS_SPECIFIC
    }
    private AccesoriesTypes accesories_types;
    private int spellEffectID;

    public int SpellEffectID
    {
        get { return spellEffectID; }
        set { spellEffectID = value; }
    }

    public AccesoriesTypes Accesories_Types
    {
        get { return accesories_types; }
        set { accesories_types = value; }
    }
    
}
