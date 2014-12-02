using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {


	private int amountOfItems;		//Antall clues man har plukket
	public GameObject EndOfLevel;	//Prefab for å gå til neste level
	public Transform EndOfLevelPos;	//Prefab for position til neste level prefab

	void Start () 
	{
		amountOfItems = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		RaycastHit hit = new RaycastHit();
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

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
						hit.transform.tag = "Inventory";									//Removes tag from object
				}
			}
		}	//End of click logic

		if(amountOfItems == 3)
		{	//Spawner prefab på EndOfLevelPos sin position
			Instantiate(EndOfLevel,EndOfLevelPos.position, EndOfLevelPos.rotation);
			amountOfItems = 0;	//Resett amountOfItems for å hindre infinite loop
		}
	}
}


