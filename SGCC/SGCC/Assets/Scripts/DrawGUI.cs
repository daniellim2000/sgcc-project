using UnityEngine;
using System.Collections;

public class DrawGUI : MonoBehaviour {

	void OnGUI() {
		GUIStyle style = new GUIStyle ();
		style.font = (Font)Resources.Load ("ren_retro", typeof(Font));
		style.fontSize = 45;
		style.normal.textColor = Color.yellow;
		GUI.Label (new Rect (40, 20, 100, 20), "The Rise Of Ice Pie Standards", style);
	}

}
