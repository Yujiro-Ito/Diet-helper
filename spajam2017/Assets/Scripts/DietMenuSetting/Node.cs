using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Node : MonoBehaviour {
	public Text foodName;
	public Text calorie;
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AssignData(string foodname, int calorieNum){
		foodName.text = foodname;
		calorie.text = calorieNum + "kcal";
	}
}
