using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PassFoodName : MonoBehaviour {
	private Text _foodNameText;
	public FoodSearch search;

	// Use this for initialization
	void Start () {
		_foodNameText = GetComponent<Text>();
	}

	public void Search(){
		search.GetFoods(_foodNameText.text);
	}
}
