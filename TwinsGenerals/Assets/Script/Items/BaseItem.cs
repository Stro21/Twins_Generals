using UnityEngine;
using System.Collections;

public class BaseItem {

    private string name;
    private string description;
    private int itemID;
    
    private Item_Type item_type;

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
    EQUIMENT,
    EXPENDABLES, 
    ACCESORIES,
    VALUABLES
}