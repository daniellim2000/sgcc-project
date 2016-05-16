using UnityEngine;
using System.Collections;

public class DrawGUICredits : MonoBehaviour {

	void OnGUI() {
		GUIStyle style = new GUIStyle ();
		style.font = (Font)Resources.Load ("Chiller_LET_Plain-1.0", typeof(Font));
		style.fontSize = 45;
		style.normal.textColor = Color.black;
		GUI.Label (new Rect (275, 40, 375, 40), "Proudly presented to you by: ", style);
		GUI.Label (new Rect (320, 110, 420, 110), "Students of NUS High ", style);
		GUIStyle style2 = new GUIStyle ();
		style2.font = (Font)Resources.Load ("Chiller_LET_Plain-1.0", typeof(Font));
		style2.fontSize = 34;
		style2.normal.textColor = Color.black;
		GUI.Label (new Rect (370, 145+10, 470, 145+10), "Chong Jing Quan ", style2);
		GUI.Label (new Rect (370, 180+10, 470, 180+10), "Daniel Lim Wee Song ", style2);
		GUI.Label (new Rect (370, 215+10, 470, 215+10), "Gnoh Cheng Yi ", style2);
		GUI.Label (new Rect (370, 250+10, 470, 250+10), "Lim Bing Sen ", style2);
	}
}
