using UnityEngine;
using System.Collections;

public class BaseSpecialHability
{
    private string hability_name;
    private string hability_description;

    public BaseSpecialHability(string name, string description)
    {
        hability_name = name;
        hability_description = description;
    }

    public string Hability_Description
    {
        get { return hability_description; }
        set { hability_description = value; }
    }

    public string Hability_Name
    {
        get { return hability_name; }
        set { hability_name = value; }
    }
}
