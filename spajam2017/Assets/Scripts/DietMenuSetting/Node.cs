using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Node : MonoBehaviour {
	public Text foodNameText;
	public Text calorieText;

	private string foodName;
	private int calorie;
	public string FoodName{ get {return foodName; }}
	public int Calorie{ get {return calorie; }}
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AssignData(string foodname, int calorieNum){
		foodNameText.text = foodname;
		calorieText.text = calorieNum + "kcal";

		foodName = foodname;
		calorie = calorieNum;
	}
}
