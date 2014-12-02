using UnityEngine;
using System.Collections;

public class Dialog : MonoBehaviour {

	public string textField;
	public Texture2D inputImage;

	
	// Update is called once per frame
	void OnMouseDown () {
		if(this.tag != "Inventory")
		DialogBox.DrawGUI (textField, inputImage);
	}
}
