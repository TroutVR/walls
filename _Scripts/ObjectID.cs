using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ObjectID : MonoBehaviour {

	[SerializeField]
	int id;
	public int ID 
	{
		get 
		{ 
			return id;
		}
		set
		{
			id = value;
		}
	}


	[SerializeField]
	int idParent;
	public int IDParent
	{
		get 
		{ 
			return idParent;
		}
		set
		{
			idParent = value;
		}
	}

	[SerializeField]
	string prefabName = ""; 
	public string PrefabName
	{
		get
		{
			if (prefabName == "")
				return PrefabUtility.GetPrefabParent (gameObject).name;
			else
				return prefabName;
		}
		set
		{
			prefabName = value;
		}
	}

	[SerializeField]
	bool hasBeenEditted = false;
	public bool HasBeenEditted
	{
		get
		{
			return hasBeenEditted;
		}
		set
		{
			hasBeenEditted = value;
		}
	}


	void Start()
	{
		transform.hasChanged = false;
	}
	void Update()
	{
		//CheckIfEditorChanged();
		if (transform.hasChanged)
			HasBeenEditted = true;
	}
		
}


