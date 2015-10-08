using UnityEngine;
using System.Collections;

public class BaseItem {

    private string name;
    private string description;
    private int itemID;
    private Item_Type item_type;
    private int spellEffectID;

    public int SpellEffectID
    {
        get { return spellEffectID; }
        set { spellEffectID = value; }
    }

    public Item_Type Item_type
    {
        get { return item_type; }
        set { item_type = value; }
    }
    public int ItemID
    {
        get { return itemID; }
        set { itemID = value; }
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }
    public string Name
    {
        get { 
            return name; 
        }
        set { 
            name = value; 
        }
    }
    
	
}
public enum Item_Type
{
    Equipment,
    Expendables, 
    Accesories,
    Valuables
}