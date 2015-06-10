using UnityEngine;
using System.Collections;


public class CreateNewWeapon : MonoBehaviour
{
    private BaseWeapon new_weapon;
    void Start()
    {
        create_random_weapon();
        Debug.Log("Name: "+ new_weapon.Name);
        Debug.Log("Description: " + new_weapon.Description);
        Debug.Log("Item ID: " + new_weapon.ItemID.ToString());
        Debug.Log("Weapon Type: " + new_weapon.Weapon_type.ToString());
        Debug.Log("Streght: " + new_weapon.Strenght.ToString());
        Debug.Log("Magic: " + new_weapon.Magic.ToString());
        Debug.Log("Physical Defense: " + new_weapon.Physical_defence.ToString());
        Debug.Log("Magical Defense: " + new_weapon.Magical_defence.ToString());
        Debug.Log("Spell Effect ID: " + new_weapon.SpellEffectID.ToString());
    }
    public void create_weapon(string name, string description, int itemid, int[] stats, BaseWeapon.WeaponTypes weapontype, int spelleffectid)
    {
        new_weapon = new BaseWeapon();

        //assign name to the weapon
        new_weapon.Name = name;
        //weapon description
        new_weapon.Description = description;
        //weaponid
        new_weapon.ItemID = itemid;
        //stats
        new_weapon.Strenght = stats[0];
        new_weapon.Magic = stats[1];
        new_weapon.Physical_defence = stats[2];
        new_weapon.Magical_defence = stats[3];
        //choose type of weapon
        new_weapon.Weapon_type = weapontype;
        //spell effect id
        new_weapon.SpellEffectID = spelleffectid;
    }
    public void create_random_weapon()
    {
        new_weapon = new BaseWeapon();

        //assign name to the weapon
        new_weapon.Name = "W" + Random.Range(1, 101);
        //weapon description
        new_weapon.Description = "This is a new weapon";
        //weaponid
        new_weapon.ItemID = Random.Range(1, 101);
        //stats
        new_weapon.Strenght = Random.Range(1, 11);
        new_weapon.Magic = Random.Range(1, 11);
        new_weapon.Physical_defence = Random.Range(1, 11);
        new_weapon.Magical_defence = Random.Range(1, 11);
        //choose type of weapon
        ChooseRandomWeaponType();
        //spell effect id
        new_weapon.SpellEffectID = Random.Range(1, 101);
    }
    private void ChooseRandomWeaponType()
    {
        int randomTemp = Random.Range(1, 10);
        if (randomTemp == 1)
        {
            new_weapon.Weapon_type = BaseWeapon.WeaponTypes.BOW;
        }
        else if(randomTemp == 2){
            new_weapon.Weapon_type = BaseWeapon.WeaponTypes.DAGGER;
        }
        else if (randomTemp == 3)
        {
            new_weapon.Weapon_type = BaseWeapon.WeaponTypes.GIANTSWORD;
        }
        else if (randomTemp == 4)
        {
            new_weapon.Weapon_type = BaseWeapon.WeaponTypes.LANCE;
        }
        else if (randomTemp == 5)
        {
            new_weapon.Weapon_type = BaseWeapon.WeaponTypes.RAPIER;
        }
        else if (randomTemp == 6)
        {
            new_weapon.Weapon_type = BaseWeapon.WeaponTypes.STAFF;
        }
        else if (randomTemp == 7)
        {
            new_weapon.Weapon_type = BaseWeapon.WeaponTypes.SWORD;
        }
        else if (randomTemp == 8)
        {
            new_weapon.Weapon_type = BaseWeapon.WeaponTypes.WHIP;
        }
        else if (randomTemp == 9)
        {
            new_weapon.Weapon_type = BaseWeapon.WeaponTypes.AXE;
        }
    }
}
