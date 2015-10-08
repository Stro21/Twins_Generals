using UnityEngine;
using System.Collections;

public class BaseWeapon : BaseEquipment 
{
    
    private WeaponTypes weapon_type;
    
    public WeaponTypes Weapon_type
    {
        get { return weapon_type; }
        set { weapon_type = value; }
    }
}
public enum WeaponTypes
{
    Sword,
    Bow,
    Lance,
    Rapier,
    Two_Handed_Sword,
    Staff,
    Dagger,
    Whip,
    Axe
}