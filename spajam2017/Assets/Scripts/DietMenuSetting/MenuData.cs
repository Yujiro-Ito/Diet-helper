using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuData : MonoBehaviour {

	public Data[] datas;
	private string foodName;
	private float foodCal;

	private float CalResult;

	//表示
	private Text myText;

	// Use this for initialization
	void Start () {
		myText = GetComponentInChildren<Text> ();

		SetFoodText ("カレー", 300);
	}

	public void SetFoodText(string food, int cal){
		foodName = food;
		foodCal = (float)cal;
		CalCalucalation ();
	}

	public void CalCalucalation(){
		int random = Random.Range (0,datas.Length);
		CalResult =  foodCal / datas[random].cal;
		myText.text = datas[random].menuName +"を"+ CalResult + datas[random].unit;
	}

	// Update is called once per frame
	void Update () {
		
	}

}
[System.Serializable]
public class Data{
	public string menuName;
	public float cal;
	public string unit;
}
