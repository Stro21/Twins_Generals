using UnityEngine;
using System.Collections;

public class BaseDefenseEquipment : BaseEquipment
{
    private DefenseEquipmentTypes defense_equipment_types;

    public DefenseEquipmentTypes Defense_Equipment_Types
    {
        get { return defense_equipment_types; }
        set { defense_equipment_types = value; }
    }
}
public enum DefenseEquipmentTypes
{
    SHIELD,
    BOOK,
    HELM,
    HAT,
    LIGHT_ARMOR,
    MEDIUM_ARMOR,
    HEAVY_ARMOR
}