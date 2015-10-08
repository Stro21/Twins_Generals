using UnityEngine;
using System.Collections;

public class BaseEquipment : BaseItem
{
    private EquipmentTypes equipment_type;
    private BaseStats stats;

    public BaseStats Stats
    {
        get { return stats; }
        set { stats = value; }
    }
    public EquipmentTypes Equipment_Type
    {
        get { return equipment_type; }
        set { equipment_type = value; }
    }
}
public enum EquipmentTypes
{
    Right_Hand,
    Left_Hand,
    Body, 
    Head
}
