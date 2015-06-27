using UnityEngine;
using System.Collections;

public class CreateNewDefenseEquipment : MonoBehaviour
{
    private BaseDefenseEquipment defense_equipment;
    void Start()
    {
        create_random_defense_equipment();
        Debug.Log("Hability_Name: " + defense_equipment.Name);
        Debug.Log("Description: " + defense_equipment.Description);
        Debug.Log("Item ID: " + defense_equipment.ItemID.ToString());
        Debug.Log("Defense Equipment Type: " + defense_equipment.Equipment_Type.ToString());
        Debug.Log("Streght: " + defense_equipment.Strenght.ToString());
        Debug.Log("Magic: " + defense_equipment.Magic.ToString());
        Debug.Log("Physical Defense: " + defense_equipment.Physical_defence.ToString());
        Debug.Log("Magical Defense: " + defense_equipment.Magical_defence.ToString());
        Debug.Log("Spell Effect ID: " + defense_equipment.SpellEffectID.ToString());
        Debug.Log("Equipment Type: " + defense_equipment.Equipment_Type.ToString());
    }
    public void create_defense_equipment(string name, string description, int itemid, int[] stats, DefenseEquipmentTypes defense_equipment_type, int spelleffectid,
        EquipmentTypes equip)
    {
        defense_equipment = new BaseDefenseEquipment();

        //assign Hability_Name to the defense equipment
        defense_equipment.Name = name;
        //defense equipment Description
        defense_equipment.Description = description;
        //defense equipmentid
        defense_equipment.ItemID = itemid;
        //stats
        defense_equipment.Strenght = stats[0];
        defense_equipment.Magic = stats[1];
        defense_equipment.Physical_defence = stats[2];
        defense_equipment.Magical_defence = stats[3];
        //choose type of defense equipment
        defense_equipment.Defense_Equipment_Types = defense_equipment_type;
        //spell effect id
        defense_equipment.SpellEffectID = spelleffectid;
        defense_equipment.Equipment_Type = equip;
    }
    public void create_random_defense_equipment()
    {
        defense_equipment = new BaseDefenseEquipment();

        //assign Hability_Name to the defense equipment
        defense_equipment.Name = "W" + Random.Range(1, 101);
        //defense equipment Description
        defense_equipment.Description = "This is a new defense equipment";
        //defense equipmentid
        defense_equipment.ItemID = Random.Range(1, 101);
        //stats
        defense_equipment.Strenght = Random.Range(1, 11);
        defense_equipment.Magic = Random.Range(1, 11);
        defense_equipment.Physical_defence = Random.Range(1, 11);
        defense_equipment.Magical_defence = Random.Range(1, 11);
        //choose type of defense equipment
        ChooseRandomdefense_equipment_type();
        //spell effect id
        defense_equipment.SpellEffectID = Random.Range(1, 101);
        ChooseRandomEquipmentType();
    }
    private void ChooseRandomdefense_equipment_type()
    {
        int randomTemp = Random.Range(1, 8);
        if (randomTemp == 1)
        {
            defense_equipment.Defense_Equipment_Types = DefenseEquipmentTypes.BOOK;
        }
        else if (randomTemp == 2)
        {
            defense_equipment.Defense_Equipment_Types = DefenseEquipmentTypes.HAT;
        }
        else if (randomTemp == 3)
        {
            defense_equipment.Defense_Equipment_Types = DefenseEquipmentTypes.HEAVY_ARMOR;
        }
        else if (randomTemp == 4)
        {
            defense_equipment.Defense_Equipment_Types = DefenseEquipmentTypes.HELM;
        }
        else if (randomTemp == 5)
        {
            defense_equipment.Defense_Equipment_Types = DefenseEquipmentTypes.LIGHT_ARMOR;
        }
        else if (randomTemp == 6)
        {
            defense_equipment.Defense_Equipment_Types = DefenseEquipmentTypes.MEDIUM_ARMOR;
        }
        else if (randomTemp == 7)
        {
            defense_equipment.Defense_Equipment_Types = DefenseEquipmentTypes.SHIELD;
        }
    }
    private void ChooseRandomEquipmentType()
    {
        int random = Random.Range(1, 4);
        if (random == 1)
        {
            defense_equipment.Equipment_Type = EquipmentTypes.LEFT_HAND;
        }
        else if (random == 2)
        {
            defense_equipment.Equipment_Type = EquipmentTypes.HEAD;
        }
        else if (random == 3)
        {
            defense_equipment.Equipment_Type = EquipmentTypes.BODY;
        }
    }
}
