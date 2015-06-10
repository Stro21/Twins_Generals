using UnityEngine;
using System.Collections;

public class BaseEquipment : BaseStatItem
{
    public enum EquipmentTypes
    {
        RIGHT_HAND, LEFT_HAND, BODY, HEAD
    }

    private EquipmentTypes equipment_type;

    private int spellEffectID;

    public int SpellEffectID
    {
        get { return spellEffectID; }
        set { spellEffectID = value; }
    }

    public EquipmentTypes Equipment_Type
    {
        get { return equipment_type; }
        set { equipment_type = value; }
    }
}
