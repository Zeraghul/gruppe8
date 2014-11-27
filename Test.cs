using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	public struct ItemObject
	{
		public GameObject item;
		public string itemName;
	}
	
	ItemObject[] itemInventory = new ItemObject[12];
	int i = 0;
		// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		RaycastHit hit = new RaycastHit();
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

		if(Input.GetButtonUp("Fire1"))
		{
			if(Physics.Raycast(ray, out hit, 10000))
			{
				if(hit.transform.tag == "Clue")
				{
					if(itemInventory[i].itemName == null)
					{
						itemInventory[i].itemName = hit.collider.gameObject.name;
						Debug.Log(itemInventory[i].itemName + i);
						Destroy(hit.transform.gameObject);
						i++;
					}
				}
			}
		}
	}
}
	

