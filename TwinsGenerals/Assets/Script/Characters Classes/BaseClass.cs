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
    private Race race;
    private SexSpecific sex;
    private bool can_lead;

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
    

    public Race Race1
    {
        get { return race; }
        set { race = value; }
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

    public enum Race
    {
        HUMAN,
        HAWKMAN,
        DRAGON,
        GOLEM,
        BEAST,
        DEMON
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
}
