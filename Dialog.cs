using UnityEngine;
using System.Collections;

public class Dialog : MonoBehaviour {

	public string textField;		//Text that will be displayed
	public Texture2D inputImage;	//Portrait that will be displayed

	
	// Update is called once per frame
	void OnMouseDown () {	//If left clicked
		if(this.tag != "Inventory")
			DialogBox.DrawGUI (textField, inputImage);	//See DialogBox.c
	}
}
