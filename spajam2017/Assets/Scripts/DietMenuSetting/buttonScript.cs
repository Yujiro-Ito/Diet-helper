using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {
	GameObject _slideObj;
	SlideTest _slideTest;
	public string panelName;

	// Use this for initialization
	void Start () {
		_slideObj = GameObject.Find (panelName);
		_slideTest = _slideObj.GetComponent<SlideTest> ();	
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void ButtonPush(){
		_slideTest.slideInAnim ();
	}
}
