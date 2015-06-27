using UnityEngine;
using System.Collections;

public class BaseCharacter
{
    private string name;
    private int level;
    private BaseClass clase;
    private BaseAlignment current_alignment;
    private BaseStatus current_status;

    public BaseStatus Current_Status
    {
        get { return current_status; }
        set { current_status = value; }
    }
    public BaseAlignment Current_Alignment
    {
        get { return current_alignment; }
        set { current_alignment = value; }
    }
    

    public BaseClass Clase
    {
        get { return clase; }
        set { clase = value; }
    }

    public int Level
    {
        get { return level; }
        set { level = value; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    
    
}
