using UnityEngine;
using System.Collections;

public class TestGUI : MonoBehaviour {

    private BaseClass arquero = new BaseArcherClass();
    private BaseClass luchador = new BaseFighterClass();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
        GUILayout.Label(arquero.Class_Name);
        GUILayout.Label(arquero.Class_Description);
        GUILayout.Label(luchador.Class_Name);
        GUILayout.Label(luchador.Class_Description);
	}
}
