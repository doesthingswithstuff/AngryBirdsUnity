using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {
	
	void OnGUI() {
		if(GUI.Button(new Rect(Screen.width / 30, Screen.height / 10, 100, 30), "Try Again")) {
			Application.LoadLevel("Level");
		}
	}
	
}