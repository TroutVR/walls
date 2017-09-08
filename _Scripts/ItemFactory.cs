using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ItemFactory {
	static int id;
	static public int ID 
	{
		get
		{
			return id;
		}
		private set 
		{
			id = value;
		}
	}

	static string name;
	static public string Name{
		get 
		{ 
			return name;
		}
		private set 
		{ 
			name = value;
		}
	}

	static private int idParent;
	static public int IDParent
	{
		get
		{
			return idParent;
		}
		private set 
		{ 
			idParent = value;
		}
	}

	static private string itemPath;
	static public string ItemPath
	{
		get
		{
			return itemPath;
		}
		private set 
		{
			itemPath = value;
		}
	}
		
	public static GameObject CreateItem(string[] currentRowsColumns){

		ID = int.Parse(currentRowsColumns [0]);
		string folderAndType = currentRowsColumns [1];
		Name = currentRowsColumns [2];
		string prefabName = currentRowsColumns [3];
		IDParent = int.Parse(currentRowsColumns [4]);
		ItemPath = "_Prefabs/" + folderAndType + "/" + prefabName;
		GameObject go = GameObject.Instantiate (Resources.Load (itemPath) as GameObject);
		go.GetComponent<ObjectID> ().HasBeenEditted = true;
		go.GetComponent<ObjectID> ().PrefabName = prefabName;
		go.GetComponent<ObjectID> ().ID = ID;
		go.name = Name;
		if (int.Parse (currentRowsColumns [5]) == 0)
			go.gameObject.SetActive(false);
		else
			go.gameObject.SetActive(true);

		// A GameObject's tranfrosm.
		go.transform.position = StringToVector3 (currentRowsColumns [6]);
		go.transform.localScale = StringToVector3 (currentRowsColumns [7]);
		go.transform.eulerAngles = StringToVector3 (currentRowsColumns [8]);
	
		//go.transform.localScale = StringToVector3 (currentRowsColumns [8]);
		//go.GetComponent<Renderer> ().material = Resources.Load ("_Materials/" + currentRowsColumns [10]);

		return go;
	}

	static Vector3 StringToVector3(string sVector)
	{
		// Remove parenthesis.
		if (sVector.StartsWith ("(") && sVector.EndsWith (")"))
			sVector = sVector.Substring (1, sVector.Length - 2);

		string[] sArray = sVector.Split(',');

		Vector3 result = new Vector3(float.Parse(sArray[0]),float.Parse(sArray[1]),float.Parse(sArray[2]));

		return result;
	}


}
