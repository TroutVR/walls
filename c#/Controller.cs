using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour 
{
	/// <summary>
	/// Used by other classes to access this specific class and not an instance of the class.
	/// </summary>
	public static Controller instance = null;

	/// <summary>
	///	The walls in the current scene. WallOne being walls[0], they are indexed as walls[x-1]..walls[k-1] with
	/// ceiling being walls[k] and floor being walls[k+1].
	/// </summary>
	public GameObject[] walls;

//	/// <summary>
//	///	The first wall in the scene.
//	/// </summary>
//	public GameObject wallOne;
//
//	/// <summary>
//	///	The second wall in the scene.
//	/// </summary>
//	public GameObject wallTwo;
//
//	/// <summary>
//	///	The third wall in the scene.
//	/// </summary>
//	public GameObject wallThree;
//
//	/// <summary>
//	///	The fourth wall in the scene.
//	/// </summary>
//	public GameObject wallFour;
//
//	/// <summary>
//	///	The ceiling in the scene.
//	/// </summary>
//	public GameObject ceiling;
//
//	/// <summary>
//	///	The floor in the scene.
//	/// </summary>
//	public GameObject floor;

	//public GameObject wallOneTrimOneButton;

	/// <summary>
	/// The first piece of floor trim for wall one.
	/// </summary>
	public GameObject wallOneTrimOne;

	/// <summary>
	/// The second piece of floor trim for wall one.
	/// </summary>
	public GameObject wallOneTrimTwo;

	/// <summary>
	/// Used to determine if a trim is already active in this spot.
	/// </summary>
	public bool wallOneFloorTrimIsActive = false;

	/// <summary>
	/// Used to determine if a trim is already active in this spot.
	/// </summary>
	//private bool wallTwoFloorTrimIsActive = false;

	/// <summary>
	/// Used to keep track of what trim is currentle being edited.
	/// </summary>
	public string currentWallOneFloorTrim = "";

	/// <summary>
	/// Used to keep track of what wall is currently selected.
	/// </summary>
	public string currentSelectedWall = "";

	/// <summary>
	///	The original wall color. Default is the color of sheetrock, #DFDFDF.
	/// </summary>
	public Material originalWallColor;

	public Material selectedWallColor;

	/// <summary>
	///	The original trim color. Default is a white, #FFFFFF.
	/// </summary>
	public Material originalTrimColor;

	private string previousSelection;
	public GameObject[] navigationTabs;
	public GameObject[] wallOneAdditionTypes;
	public GameObject[] wallOneAdditionLocations;
	public GameObject[] wallOneIndividualAdditions;
	public GameObject[] wallOneIndividualAdditionProperties;

	/// <summary>
	///	The material used to display that the current selected item is toggled as 'on'.
	/// </summary>
	public Material toggleOn;

	/// <summary>
	///	The material used to display that the current selected item is toggled as 'off'.
	/// </summary>
	public Material toggleOff;

	/// <summary>
	///	Used to keep track if the current selected item is toggled.
	/// </summary>
	public bool isToggle = false;

	/// <summary>
	///	The toggle button.
	/// </summary>
	public GameObject toggle;

	/// <summary>
	///	Used to determine which item the toggle button should refer to.
	/// </summary>
	public GameObject currentSelection;


	public GameObject tempText;
	public GameObject tempTextParent;
	private GameObject tempTempText;

	// Use this for initialization
	void Awake () 
	{
		// Singleton Pattern. Will make sure that there is only ever one instance of the GameController
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);
	}

	void Start()
	{
	}

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Space))
		{
			tempTempText = Instantiate (tempText, tempTextParent.transform);
			tempTempText.transform.parent = tempTextParent.transform;
		}
	}
		
	/// <summary>
	/// Select the wall in the scene that is to be currently edited.
	/// </summary>
	public void SelectWall(string wall)
	{
		currentSelectedWall = wall;
		switch (wall)
		{
		case "WallOne":
			//wallOne.gameObject.GetComponent<Renderer> ().material = selectedWallColor;
			walls[0].gameObject.GetComponent<Renderer> ().material = selectedWallColor;
			DisplayAdditionTypes (wall);
			break;
		case "WallTwo":
			//wallTwo.gameObject.GetComponent<Renderer> ().material = selectedWallColor;
			walls[1].gameObject.GetComponent<Renderer> ().material = selectedWallColor;
			break;
		case "WallThree":
			//wallThree.gameObject.GetComponent<Renderer> ().material = selectedWallColor;
			walls[2].gameObject.GetComponent<Renderer> ().material = selectedWallColor;
			break;
		case "WallFour":
			//wallFour.gameObject.GetComponent<Renderer> ().material = selectedWallColor;
			walls[3].gameObject.GetComponent<Renderer> ().material = selectedWallColor;
			break;
		case "Ceiling":
			//ceiling.gameObject.GetComponent<Renderer> ().material = selectedWallColor;
			walls[4].gameObject.GetComponent<Renderer> ().material = selectedWallColor;
			break;
		case "Floor":
			//floor.gameObject.GetComponent<Renderer> ().material = selectedWallColor;
			walls[5].gameObject.GetComponent<Renderer> ().material = selectedWallColor;
			break;
		default:
			break;
		}
			
	}

	/// <summary>
	/// Toggle the current selected addition on/off.
	/// </summary>
	void ToggleAddition(GameObject other)
	{
		// Check if currently active.
		if (isToggle)
		{
			other.gameObject.SetActive (false);
			isToggle = false;
			toggle.gameObject.GetComponent<Renderer> ().material = toggleOff;
		} else if (!isToggle)
		{
			other.gameObject.SetActive (true);
			isToggle = true;
			toggle.gameObject.GetComponent<Renderer> ().material = toggleOn;
		}
	}


	/// <summary>
	/// Deselect the previous selected wall. 
	/// </summary>
	public void DeselectWall(string wall)
	{
		switch (wall)
		{
		case "WallOne":
			//wallOne.gameObject.GetComponent<Renderer> ().material = originalWallColor;
			walls[0].gameObject.GetComponent<Renderer> ().material = originalWallColor;
			break;
		case "WallTwo":
			//wallTwo.gameObject.GetComponent<Renderer> ().material = originalWallColor;
			walls[1].gameObject.GetComponent<Renderer> ().material = originalWallColor;
			break;
		case "WallThree":
			//wallThree.gameObject.GetComponent<Renderer> ().material = originalWallColor;
			walls[2].gameObject.GetComponent<Renderer> ().material = originalWallColor;
			break;
		case "WallFour":
			//wallFour.gameObject.GetComponent<Renderer> ().material = originalWallColor;
			walls[3].gameObject.GetComponent<Renderer> ().material = originalWallColor;
			break;
		case "Ceiling":
			//ceiling.gameObject.GetComponent<Renderer> ().material = originalWallColor;
			walls[4].gameObject.GetComponent<Renderer> ().material = originalWallColor;
			break;
		case "Floor":
			//floor.gameObject.GetComponent<Renderer> ().material = originalWallColor;
			walls[5].gameObject.GetComponent<Renderer> ().material = originalWallColor;
			break;
		default:
			break;
		}
	}

	public void ChangeTrimPosition(string trim, string button)
	{
		switch (button)
		{
		case "DPadLeft":
			//wallOne.gameObject.transform.Find (trim).transform.position += new Vector3 (-.1f, 0, 0);
			walls[0].gameObject.transform.Find (trim).transform.position += new Vector3 (-.1f, 0, 0);
			break;
		case "DPadRight":
			//wallOne.gameObject.transform.Find (trim).transform.position += new Vector3 (.1f, 0, 0);
			walls[0].gameObject.transform.Find (trim).transform.position += new Vector3 (.1f, 0, 0);
			break;
		default:
			break;
		}
	}

	/// <summary>
	/// A button has been pressed by the user. Perform some action.
	/// </summary>
	public void ButtonPressed(GameObject other)
	{
		switch (other.name)
		{
		case "WallOne":
		case "WallTwo":
			previousSelection = currentSelectedWall;
			SelectWall (other.name);
			break;
		case "LightingButton":
		case "PaintButton":		
		case "TrimButton":
			SelectAdditionType (other.name);
			break;
		case "FloorTrimButton":
		case "WallTrimButton":
		case "CeilingTrimButton":
			SelectAdditionLocation (other.name);
			break;
		case "FloorTrimOne":
		case "FloorTrimTwo":
		case "FloorTrimThree":
			SelectIndividualAdditions (other.name);
			break;
		case "Toggle":
			ToggleAddition (currentSelection);
			break;
		default:
			break;
		}
		DeselectWall (previousSelection);
	}

	/// <summary>
	/// Display appropriate types of additions on the wall for selection. i.e, Lighting/Paint/Trim/etc.
	/// </summary>
	void DisplayAdditionTypes(string wall)
	{
		switch (wall)
		{
		case "WallOne":
			foreach (var type in wallOneAdditionTypes)
				type.gameObject.SetActive (true);
			break;
		default:
			break;

		}

	}

	/// <summary>
	/// An addition type has been selected and now the locations of this addition must be shown.
	/// </summary>
	void SelectAdditionType(string choice)
	{
		CloseAdditionTypes (choice);
		DisplayLocationTypes(choice);
	}

	/// <summary>
	/// Deactivate current addition type buttons.
	/// </summary>
	void CloseAdditionTypes(string choice)
	{
		switch(choice)
		{
		case "TrimButton":
			foreach (var type in wallOneAdditionTypes)
				type.gameObject.SetActive (false);
			break;
		default:
			break;

		}

	}
		
	/// <summary>
	/// Display appropriate locations for the specific type of addition. i.e., Celiling/Floor/Wall/etc.
	/// </summary>
	void DisplayLocationTypes (string choice)
	{
		switch(choice)
		{
		case "TrimButton":
			foreach (var location in wallOneAdditionLocations)
				location.gameObject.SetActive (true);
			break;
		default:
			break;

		}
	}

	/// <summary>
	/// An addition location has been selected and not the individual additions must be shown.
	/// </summary>
	void SelectAdditionLocation(string choice)
	{
		CloseAdditionLocations (choice);
		Debug.Log (choice);
		DisplayIndividualAdditions (choice);
	}

	/// <summary>
	/// Deactivate current addition type locations.
	/// </summary>
	void CloseAdditionLocations(string choice)
	{
		switch(choice)
		{
		case "FloorTrimButton":
		case "WallTrimButton":
		case "CeilingTrimButton":
			foreach (var location in wallOneAdditionLocations)
				location.gameObject.SetActive (false);
			break;
		default:
			break;

		}
	}

	/// <summary>
	/// Display appropriate individual additions for the specific location of the addition. i.e., ExampleOne/ExampleTwo/ExampleThree/etc.
	/// </summary>
	void DisplayIndividualAdditions(string choice)
	{
		switch(choice)
		{
		case "CeilingTrimButton":
		case "FloorTrimButton":
		case "WallTrimButton":
			DisplayIndividual (choice);
			break;
		default:
			break;

		}
	}

	/// <summary>
	/// An individual addition has been selected and now it's properties must be shown.
	/// </summary>
	void SelectIndividualAdditions(string choice)
	{
		CloseIndividualAdditions (choice);
		Debug.Log(choice);
		DisplayIndividualAdditionProperties (choice);
	}

	/// <summary>
	/// Deactivate current individual additions.
	/// </summary>
	void CloseIndividualAdditions(string choice)
	{
		switch(choice)
		{
		case "FloorTrimOne":
		case "FloorTrimTwo":
		case "FloorTrimThree":
			foreach (var individual in wallOneIndividualAdditions)
				individual.gameObject.SetActive (false);
			break;			
		default:
			break;

		}
	}

	/// <summary>
	/// Display appropriate properties for the specific addition selected. i.e., Model/Color/Size/etc.
	/// </summary>
	void DisplayIndividualAdditionProperties(string choice)
	{
		switch(choice)
		{
		case "FloorTrimOne":
			DisplayProperties ();
			SetCurrentSelection ("WallOneFloorTrimOne");
			break;
		case "FloorTrimTwo":
			DisplayProperties ();
			SetCurrentSelection ("WallOneFloorTrimTwo");
			break;
		case "FloorTrimThree":
			DisplayProperties ();
			SetCurrentSelection ("WallOneFloorTrimThree");
			break;
		default:
			break;
		}

	}

	/// <summary>
	/// Set the current selected item and display whether or not it is currentlt active in the scene/hierarchy.
	/// </summary>
	void SetCurrentSelection(string piece)
	{
		currentSelection = GameObject.Find (piece);

		if (currentSelection.activeInHierarchy)
		{
			isToggle = true;
			toggle.gameObject.GetComponent<Renderer> ().material = toggleOn;
		} else if(!currentSelection.activeInHierarchy)
		{
			isToggle = false;
			toggle.gameObject.GetComponent<Renderer> ().material = toggleOff;
		}
	}
		
	void DisplayProperties()
	{
		foreach (var property in wallOneIndividualAdditionProperties)
			property.gameObject.SetActive (true);
	}

	/// <summary>
	/// Display the individual additions based on which location was selected.
	/// </summary>
	void DisplayIndividual (string choice)
	{
		switch(choice)
		{
		case "FloorTrimButton":
			foreach (var addition in wallOneIndividualAdditions)
				addition.gameObject.SetActive (true);
			break;
		default:
			break;
		}
	}
}

//	Notes - 06/23/17 9:16 PM
//
//	1) Each selected piece are to be individual "item" objects. (Name subject to change)
//	The objects are stored in a DB upon creation.
// 	Pieces then retrieved from DB when selected.
//
//	2) Split class into seperate objects.
//		1 - Repetitive UI selection. Condense into one method/object if possible.
//		Check if DB has item selected and perform necessary operation.
//		2 - UI 
//			a) Make selection time sensitive. 
//				i) Display the weight.
//		3 - Individual GameObject	
//			a) Each object selected should be a seperate object.
//          	Objects should be stored into DB. 
//		4 - 		
//
//
//	3) Split button type into different categories.
//		Depending on category, search for object inside of category.

