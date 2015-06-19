using UnityEngine;
using System.Collections;

public class BaseClass:BaseRace {
	private string class_name;
	private string class_description;
	private int hp;
	private int strengh;
	private int magic;
	private int physical_defense;
	private int magical_defense;
    private SexSpecific sex;
    private bool can_lead;
    private Alignment alignment;
/*    private int ali_min;
    private int ali_max;

    public int Ali_Max
    {
        get { return ali_max; }
        set { ali_max = value; }
    }

    public int Ali_Min
    {
        get { return ali_min; }
        set { ali_min = value; }
    } */

    public Alignment Alignment1
    {
        get { return alignment; }
        set { alignment = value; }
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

    public enum SexSpecific
    {
        MALE,
        FEMALE,
        UNISEX
    }

	public string Class_Description {
		get {
			return class_description;
		}
		set {
			class_description = value;
		}
	}

	public int HP {
		get {
			return hp;
		}
		set {
			hp = value;
		}
	}

	public int Strengh {
		get {
			return strengh;
		}
		set {
			strengh = value;
		}
	}

	public int Magic {
		get {
			return magic;
		}
        set
        {
            magic = value;
        }
	}

	public int Physical_Defense {
		get {
			return physical_defense;
		}
		set {
			physical_defense = value;
		}
	}

	public int Magical_Defense {
		get {
			return magical_defense;
		}
		set {
			magical_defense = value;
		}
	}
    public enum Alignment
    {
        VERY_CHAOTIC,
        CHAOTIC,
        NEUTRAL_CHAOTIC,
        NEUTRAL,
        NEUTRAL_LAWFUL,
        LAWFUL,
        VERY_LAWFUL
    }
}
