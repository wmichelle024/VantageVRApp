using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class DisplayInfo : MonoBehaviour {
	public TextMesh mainText;
	public TextMesh additionalText;

	// Use this for initialization
	void Start () {
		// GetComponent<Renderer>().enabled = false;
		hideAllText ();
	}
	
	public void showMainText() {
		mainText.GetComponent<Renderer>().enabled = true;
	}

	public void showAdditionalText() {
		additionalText.GetComponent<Renderer>().enabled = true;
	}
		
	public void hideAllText() {
		mainText.GetComponent<Renderer>().enabled = false;
		additionalText.GetComponent<Renderer>().enabled = false;
	}
		
}