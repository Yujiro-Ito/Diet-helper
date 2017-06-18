using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetName : MonoBehaviour {

	public Text myText;
	public string foodName;
	public string menuName;
	public string foodCal;
	// Use this for initialization
	void Start () {
		myText = GetComponentInChildren<Text> ();
		//SetFoodText ("カレー",500);
	}

	public void SetFoodText(string food, string cal){
		foodName = food;
		foodCal = cal;
		NameText();
	}

	public void NameText(){
		if (gameObject.name == "FoodName") {
			myText.text = foodName + foodCal;
		}
		if (gameObject.name == "MenuName") {
			myText.text = menuName;
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
