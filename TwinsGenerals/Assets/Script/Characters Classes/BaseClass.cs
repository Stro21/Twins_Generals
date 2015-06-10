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
}
