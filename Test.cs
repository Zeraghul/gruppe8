using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	private int amountOfItems;		// Use this for initialization

	void Start () 
	{
		amountOfItems = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		RaycastHit hit = new RaycastHit();
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		Debug.DrawRay (ray.origin, ray.direction * 10, Color.cyan);

		if(Input.GetButtonUp("Fire1"))			// Click logic
		{
			if(Physics.Raycast(ray, out hit, 10000))
			{
				if(hit.transform.tag == "Clue")	//If hit target has "Clue" tag
				{
						Vector3 newpos = new Vector3(-9.5f + amountOfItems, -1.5f, -3f);	//Location of inventory slots
						hit.transform.position = newpos;									//Moves hit object to inventory slot
						amountOfItems++;													//Moves one slot in inventory
						hit.transform.tag = "Inventory";									//Changes tag on target
						hit.transform.tag = "Inventory";											//Removes tag from object
				}
			}
		}	//End of click logic
	}
}


