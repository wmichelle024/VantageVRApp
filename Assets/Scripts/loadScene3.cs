﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene3 : MonoBehaviour {

	public string sceneToChange;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnMouseOver () {
		if (Input.GetMouseButtonDown (0)) {
			SceneManager.LoadScene(sceneToChange);

		}

	}
}
