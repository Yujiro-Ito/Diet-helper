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
		myText = GetComponent<Text> ();
	}

	public void SetFoodText(string food, int cal){
		foodName = food;
		foodCal = (float)cal;
		CalCalucalation ();
	}

	public void CalCalucalation(){
		int random = Random.Range (0,datas.Length);
		CalResult =  foodCal / datas[random].cal;
		myText.text = datas[random].menuName +"を\n"+ CalResult + datas[random].unit;
		//セーブデータ作成
		SaveNode node = new SaveNode();
		node.foodName = foodName;
		node.cal = (int)foodCal;
		node.menu = datas[random].menuName +"を"+ CalResult + datas[random].unit;
		MenuManager.Instance().Save.Add(node);
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
