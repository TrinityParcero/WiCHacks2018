using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuText : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        OnGUI();
	}

    void OnGUI()
    {
        GUIStyle titleStyle = new GUIStyle();
        titleStyle.fontSize = 50;
        titleStyle.normal.textColor = Color.black;
    


        GUI.Box(new Rect(340, 220, 500, 60), "PLAY", titleStyle);

        if (GUI.Button(new Rect(10, 10, 150, 100), "I am a button"))
            print("You clicked the button!");

    }
}
