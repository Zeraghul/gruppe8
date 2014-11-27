using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	public struct ItemObject
	{
		public string itemName;
	}

	public GameObject Scene1Prefab;
	public GameObject Scene2Prefab;
	private GameObject scene;


	// Use this for initialization
	void Start () 
	{
		int inventorySize = 12;
		ItemObject[] itemInventory = new ItemObject[inventorySize];
		itemInventory[0].itemName = "Cigarette";


		scene = Instantiate(Scene1Prefab) as GameObject;
	}
	
	// Update is called once per frame
	void Update () 
	{
		RaycastHit hit = new RaycastHit();
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

		if(Input.GetButtonUp("Fire1"))
		{
			if(Physics.Raycast(ray, out hit, 10000))
			{
				if(hit.transform.tag == "boks")
				{
					Debug.Log("Hittt");
					Destroy(scene.gameObject);
					scene = Instantiate(Scene2Prefab) as GameObject;
				}
				if(hit.transform.tag == "boks2")
				{
					Debug.Log("Hittt");
					Destroy(scene.gameObject);
					scene = Instantiate(Scene1Prefab) as GameObject;
				}
			}
		}
	}
}
