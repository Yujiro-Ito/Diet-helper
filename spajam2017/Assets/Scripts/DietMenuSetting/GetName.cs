using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetName : MonoBehaviour {
	public Text calorieText;
	public Text foodNameText;
	public string foodName;
	public string menuName;
	public string foodCal;
	// Use this for initialization
	void Start () {
		//SetFoodText ("カレー",500);
	}

	public void SetFoodText(string food, int cal){
		foodName = food;
		foodCal = cal + "kcal";
		NameText();
	}

	public void NameText(){
		foodNameText.text = foodName;
		calorieText.text = foodCal;
	}

	// Update is called once per frame
	void Update () {
		
	}
}
