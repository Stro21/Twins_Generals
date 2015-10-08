using UnityEngine;
using System.Collections;


public class CreateNewWeapon : MonoBehaviour
{
    private BaseWeapon new_weapon;
    void Start()
    {
        create_random_weapon();
        Debug.Log("Hability_Name: "+ new_weapon.Name);
        Debug.Log("Description: " + new_weapon.Description);
        Debug.Log("Item ID: " + new_weapon.ItemID.ToString());
        Debug.Log("Weapon Type: " + new_weapon.Weapon_type.ToString());
        Debug.Log("Streght: " + new_weapon.Stats.Strengh.ToString());
        Debug.Log("Magic: " + new_weapon.Stats.Magic.ToString());
        Debug.Log("Physical Defense: " + new_weapon.Stats.Physical_defense.ToString());
        Debug.Log("Magical Defense: " + new_weapon.Stats.Magical_defense.ToString());
        Debug.Log("Spell Effect ID: " + new_weapon.SpellEffectID.ToString());
        Debug.Log("Equipment Type: " + new_weapon.Equipment_Type.ToString());
    }
    public void create_weapon(string name, string description, int itemid, int[] stats, WeaponTypes weapontype, int spelleffectid)
    {
        new_weapon = new BaseWeapon();

        //assign Hability_Name to the weapon
        new_weapon.Name = name;
        //weapon Description
        new_weapon.Description = description;
        //weaponid
        new_weapon.ItemID = itemid;
        //Stats
        new_weapon.Stats.Strengh = stats[0];
        new_weapon.Stats.Magic = stats[1];
        new_weapon.Stats.Physical_defense = stats[2];
        new_weapon.Stats.Magical_defense = stats[3];
        //choose type of weapon
        new_weapon.Weapon_type = weapontype;
        //spell effect id
        new_weapon.SpellEffectID = spelleffectid;
        new_weapon.Equipment_Type = EquipmentTypes.Right_Hand;
    }
    public void create_random_weapon()
    {
        new_weapon = new BaseWeapon();

        //assign Hability_Name to the weapon
        new_weapon.Name = "W" + Random.Range(1, 101);
        //weapon Description
        new_weapon.Description = "This is a new weapon";
        //weaponid
        new_weapon.ItemID = Random.Range(1, 101);
        //Stats
        new_weapon.Stats.Strengh = Random.Range(1, 11);
        new_weapon.Stats.Magic = Random.Range(1, 11);
        new_weapon.Stats.Physical_defense = Random.Range(1, 11);
        new_weapon.Stats.Magical_defense = Random.Range(1, 11);
        //choose type of weapon
        ChooseRandomWeaponType();
        //spell effect id
        new_weapon.SpellEffectID = Random.Range(1, 101);
        new_weapon.Equipment_Type = EquipmentTypes.Right_Hand;
    }
    private void ChooseRandomWeaponType()
    {
        int randomTemp = Random.Range(1, 10);
        if (randomTemp == 1)
        {
            new_weapon.Weapon_type = WeaponTypes.Bow;
        }
        else if(randomTemp == 2){
            new_weapon.Weapon_type = WeaponTypes.Dagger;
        }
        else if (randomTemp == 3)
        {
            new_weapon.Weapon_type = WeaponTypes.Two_Handed_Sword;
        }
        else if (randomTemp == 4)
        {
            new_weapon.Weapon_type = WeaponTypes.Lance;
        }
        else if (randomTemp == 5)
        {
            new_weapon.Weapon_type = WeaponTypes.Rapier;
        }
        else if (randomTemp == 6)
        {
            new_weapon.Weapon_type = WeaponTypes.Staff;
        }
        else if (randomTemp == 7)
        {
            new_weapon.Weapon_type = WeaponTypes.Sword;
        }
        else if (randomTemp == 8)
        {
            new_weapon.Weapon_type = WeaponTypes.Whip;
        }
        else if (randomTemp == 9)
        {
            new_weapon.Weapon_type = WeaponTypes.Axe;
        }
    }
}
