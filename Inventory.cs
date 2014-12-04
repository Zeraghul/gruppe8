using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {
	
	ArrayList currentInventory;
	string tempString;
	int i;



	void Start()
	{
		i = 0;
		currentInventory = GameObject.FindWithTag("Player").GetComponent<clicker> ().inventory; //henter listen av "clues" som har blitt funnet

		for(i = 0; i < currentInventory.Count; i++)	//Endless loop must fix
		{
			tempString = currentInventory[i].ToString();
			tempString = tempString.Remove(tempString.Length - 7, 7);
			GameObject prefab = Resources.Load (tempString) as GameObject;
			GameObject instances = Instantiate(prefab,new Vector3(0,0,0), Quaternion.identity) as GameObject;
		}
	}
}
