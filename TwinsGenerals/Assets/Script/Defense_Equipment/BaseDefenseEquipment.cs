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
    Shield,
    Book,
    Helm,
    Hat,
    Light_Armor,
    Medium_Armor,
    Heavy_Armor
}