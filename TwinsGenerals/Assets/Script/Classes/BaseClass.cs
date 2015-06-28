using UnityEngine;
using System.Collections;

public class BaseClass {
	private string class_name;
	private string class_description;
	private int hp;
	private int strengh;
	private int magic;
	private int physical_defense;
	private int magical_defense;
    private SexSpecific sex;
    private bool can_lead;
    private BaseAlignment alignment;
    private int hp_lvl;
    private int str_lvl;
    private int mag_lvl;
    private int phydef_lvl;
    private int magdef_lvl;
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

    public int Magdef_lvl
    {
        get { return magdef_lvl; }
        set { magdef_lvl = value; }
    }

    public int Phydef_lvl
    {
        get { return phydef_lvl; }
        set { phydef_lvl = value; }
    }

    public int Mag_lvl
    {
        get { return mag_lvl; }
        set { mag_lvl = value; }
    }

    public int Str_lvl
    {
        get { return str_lvl; }
        set { str_lvl = value; }
    }

    public int HP_lvl
    {
        get { return hp_lvl; }
        set { hp_lvl = value; }
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

    public BaseAlignment Alignment
    {
        get { return alignment; }
        set { alignment = value; }
    }
}
