﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class swicthbutton : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void OnClick(){
		string name = PlayerPrefs.GetString( "name");
		if (name == "") {
			SceneManager.LoadScene("Profile");
		} else {
			SceneManager.LoadScene("DietMenuSetting");
		}
	}
}
