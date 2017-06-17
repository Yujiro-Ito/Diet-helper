using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetName : MonoBehaviour {

	Text myText;
	string foodName;
	string menuName;
	// Use this for initialization
	void Start () {
		myText = GetComponentInChildren<Text> ();
		//SetNameText ("カレー","トライアスロン行ってこい");
		NameText();
	}

	public void SetNameText(string food, string menu){
		foodName = food;
		menuName = menu;
		NameText();
	}

	public void NameText(){
		if (gameObject.name == "FoodName") {
			myText.text = foodName;
		}
		if (gameObject.name == "MenuName") {
			myText.text = menuName;
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
