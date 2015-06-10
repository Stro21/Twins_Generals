using UnityEngine;
using System.Collections;

public class BaseWeapon : BaseEquipment 
{
    public enum WeaponTypes
    {
        SWORD,
        BOW,
        LANCE,
        RAPIER,
        GIANTSWORD,
        STAFF,
        DAGGER,
        WHIP
    }
    private WeaponTypes weapon_type;
    
    public WeaponTypes Weapon_type
    {
        get { return weapon_type; }
        set { weapon_type = value; }
    }
}
