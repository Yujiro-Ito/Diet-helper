using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetName : MonoBehaviour {

	public Text foodText;
	public Text calText;
	string foodName;
	string menuName;
	// Use this for initialization

	public void SetNameText(string food, int cal){
		foodName = food;
		menuName = cal + "kcal";
		NameText();
	}

	public void NameText(){
		foodText.text = foodName;
		calText.text = menuName;
	}

	// Update is called once per frame
	void Update () {
		
	}
}
