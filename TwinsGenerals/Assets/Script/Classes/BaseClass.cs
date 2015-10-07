using UnityEngine;
using System.Collections;

public class BaseClass {
	private string class_name;
	private string class_description;
    private BaseStats stats;
    private SexSpecific sex;
    private bool can_lead;
    private BaseAlignment alignment;
    private BaseLevelStats stat_lvl;
    private BaseClass previous_class;
    private BaseSpecialHability hability;
    private int stamina;
    private int stamina_lvl;
    private BaseRace race;

    public BaseRace Race
    {
        get { return race; }
        set { race = value; }
    }

    public int Stamina_lvl
    {
        get { return stamina_lvl; }
        set { stamina_lvl = value; }
    }

    public int Stamina
    {
        get { return stamina; }
        set { stamina = value; }
    }

    public BaseSpecialHability Hability
    {
        get { return hability; }
        set { hability = value; }
    }

    public BaseClass Previous_class
    {
        get { return previous_class; }
        set { previous_class = value; }
    }
    
    public bool Can_Lead
    {
        get { return can_lead; }
        set { can_lead = value; }
    }
    public SexSpecific Sex
    {
        get { return sex; }
        set { sex = value; }
    }
    
	public string Class_Name {
		get {
			return class_name;
		}
		set {
			class_name = value;
		}
	}

    

	public string Class_Description {
		get {
			return class_description;
		}
		set {
			class_description = value;
		}
	}

    public BaseAlignment Alignment
    {
        get { return alignment; }
        set { alignment = value; }
    }

    public BaseStats Stats
    {
        get { return stats; }
        set { stats = value; }
    }

    public BaseLevelStats Stat_Lvl
    {
        get { return stat_lvl; }
        set { stat_lvl = value; }
    }
}
