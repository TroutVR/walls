using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Net;

public class DataInserter : MonoBehaviour {

	public OVRInput.Controller controller;

	public string inputUserName;
	public string inputPassword;
	public string inputEmail;

	string CreateUserURL = "localhost/Item_Inventory/InsertUser.php";
	string CreateSceneObjectURL = "http://localhost/Item_Inventory/InsertItem.php";
	IEnumerator coroutine;

	// Working as of: 7/18/2017
	IEnumerator Start()
	{
		GameObject[] objects =  GameObject.FindGameObjectsWithTag("save");
		// DownloadString (CreateSceneObjectURL);
		foreach(GameObject go in objects)
		{
			coroutine = SendItemToDB (go);
			yield return StartCoroutine (coroutine);
			//SendItemToDB(go);
		}

		GameObject gObject = GameObject.FindGameObjectWithTag("test");
	}
	// Working as of: 7/18/2017
	IEnumerator SendItemToDB(GameObject go)
	{
		if (!go.GetComponent<ObjectID> ().HasBeenEditted)
		{
			print("The item has not been changed and therefore it will not be saved.");
			yield break;
		} else {
		WWWForm form = new WWWForm ();
		form.AddField ("idPost", go.GetComponent<ObjectID> ().ID);
		//print (go.GetComponent<ObjectID> ().ID);
		form.AddField ("typePost", LayerMask.LayerToName(go.gameObject.layer));
		form.AddField ("itemNamePost", go.name);
		form.AddField ("itemPrefabNamePost", (go.GetComponent<ObjectID>().PrefabName));
		form.AddField ("idParentPost", 100);
		form.AddField ("activePost", (go.gameObject.activeInHierarchy ? 1 : 0));
		form.AddField ("positionPost", Vector3ToString(go.transform.position));
		form.AddField ("localScalePost", Vector3ToString(go.transform.localScale));
		form.AddField ("rotationPost", Vector3ToString(go.transform.eulerAngles));
		form.AddField ("materialPost", go.GetComponent<Renderer> ().material.name);
		form.AddField ("userIdPost", 1);

		WWW www = new WWW (CreateSceneObjectURL, form);
		yield return www;
		string item = www.text;
		print(item);

		}
	}

	// Working as of: 7/18/2017
	void SendDuplicate( GameObject go){

	}

	// Working as of: 7/18/2017
	string Vector3ToString(Vector3 v3){
		return "(" + v3.x + "," + v3.y + "," + v3.z + ")";
	}



}
