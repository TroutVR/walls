using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour {

	public OVRInput.Controller controller;

	// Update is called once per frame
	void Update () {
		transform.localPosition = OVRInput.GetLocalControllerPosition (controller);
		transform.localRotation = OVRInput.GetLocalControllerRotation (controller);
	}

	void OnCollisionEnter(Collision other)
	{
        //if(LayerMask.LayerToName(other.gameObject.layer) == "Bullseye")
        //{
        //        // Do Something...
        //}
		Controller.instance.ButtonPressed (other.gameObject);
	}

    


}
