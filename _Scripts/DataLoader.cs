using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;

public class DataLoader : MonoBehaviour {
	[SerializeField]
	string[] items;

	string[] Items {
		get { return items; }
		set { items = value; }
	}
	protected string url = "http://localhost:8080/Item_Inventory/ItemsData.php";

	List<GameObject> currentActiveItems = new List<GameObject>();

	void Update(){
		if (Input.GetKeyDown (KeyCode.Space))
		{
			GameObject[] objects = UnityEngine.Object.FindObjectsOfType<GameObject> ();
			foreach (GameObject go in objects)
			{
				go.gameObject.tag = "save";
			}
		}
	}
	// Use this for initialization
	IEnumerator Start () {
		yield return StartCoroutine ("LoadItemsFromDB");
		CreateItems ();
	}
		
	IEnumerator LoadItemsFromDB(){

		// Download contents from a specific URL. In this case, a php script which accesses DB.
		WWW itemsData = new WWW (url);

		// The time before the download started.
		int dt = System.DateTime.Now.Millisecond;

		// Wait for itemsData to finish downloading.
		yield return itemsData;

		// The time after the download finished.
		int dt2 = System.DateTime.Now.Millisecond;

		int downloadCompletionTime = dt2 - dt;
		print ("It took " + downloadCompletionTime + " milliseconds to complete the download!");

		// Store the contents retrieved from the url in 'WWW' as a string.
		string itemsDataString = itemsData.text;

		Items = SplitStrings(itemsDataString, '|');
	}

	void CreateItems(){
		foreach (string row in Items)
			CreateItem(SplitStrings(row, '+'));	
	}

	void CreateItem(string[] str){
		currentActiveItems.Add(ItemFactory.CreateItem(str));
	}

	string[] SplitStrings(string a, char c){
		return a.Split (c);
	}
		

}
