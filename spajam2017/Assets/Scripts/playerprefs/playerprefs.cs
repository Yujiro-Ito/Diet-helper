using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerprefs : MonoBehaviour {

	public Text namefield;

	// Use this for initialization
	void Start () {
		namefield = GameObject.Find("name").GetComponent<Text>();
		
	}

	public void GetName(){
		Debug.Log (namefield.text);
		PlayerPrefs.SetString( "name", namefield.text );
	}
}
