﻿using UnityEngine;
using System.Collections;

public class DialogBox : MonoBehaviour {
	private static bool drawGUI = false;
	private static string value;
	private static Texture2D portrait;
	public Texture2D background;

	public int buttonX = -110;
	public int buttonY = 100;

	public int backX = -226;
	public int backY = 40;

	public int portX = -320;
	public int portY = 40;

	public int tekstX = -233;
	public int tekstY = 58;

	public static void DrawGUI (string textField, Texture2D inputImage) {
		value = textField;
		portrait = inputImage;
		drawGUI = true;
	}
	
	void OnGUI () {
		if (drawGUI) {
			GUI.Label (new Rect(Screen.width / 2 + backX,Screen.height / 2 + backY, 200,100),background);
			GUI.Label (new Rect(Screen.width / 2 + portX,Screen.height / 2 + portY, 100, 100),portrait);
			GUI.Label (new Rect(Screen.width / 2 + tekstX,Screen.height / 2 + tekstY, 300, 200),"<color=black>" + value + "</color>");
			if (GUI.Button (new Rect (Screen.width / 2 + buttonX,Screen.height / 2 + buttonY,75,25), "Next")) {
				drawGUI = false;
			}
		}
	}
}
