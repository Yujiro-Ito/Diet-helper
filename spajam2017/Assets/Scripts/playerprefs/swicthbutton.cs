using System.Collections;
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
		GetComponent<Button> ().onClick.AddListener (OnClick);

	}

	void OnClick(){
		string name = PlayerPrefs.GetString( "name");
		string toll = PlayerPrefs.GetString( "toll");
		string weight = PlayerPrefs.GetString( "weight");
		string old = PlayerPrefs.GetString( "old");
		string neta2 = PlayerPrefs.GetString( "neta2");
		if (name == "" || toll == "" || weight == "" || old == "" || neta2 == "" ) {
			SceneManager.LoadScene("Profile");
		} else {
			SceneManager.LoadScene("NextScene");
		}
	}
}
