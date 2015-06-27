using UnityEngine;
using System.Collections;

public class BaseCharacter
{
    private string name;
    private int level;
    private BaseClass clase;
    private BaseAlignment current_alignment;

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
