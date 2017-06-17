using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

public class FoodSearch : MonoBehaviour {
	[HideInInspector]
	public string searchName;

	// Use this for initialization
	void Start () {
		searchName = "カレー";
		StartCoroutine(GetFoodList(searchName));

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private IEnumerator GetFoodList(string foodName){
		string url = "http://24th.jp/test/api_cal.php?submit=on&name=" + foodName;
		WWW www = new WWW(url);
		yield return www;
		//接続失敗
		if(www.error != null){
			Debug.LogError(www.error);
			yield break;
		}
		//xmlからデータへデシリアライズ
		var serializer = new XmlSerializer(typeof(FoodList));
		Debug.Log(www.text);
		List<Food> foodlist = new List<Food>();
		FoodList foodList;
		using(TextReader reader = new StringReader(www.text)){
			//Debug.Log(((FoodList)serializer.Deserialize(reader)).Foods[2].name);
			foodList = ((FoodList)serializer.Deserialize(reader));
			/*for(int i = 0; i < ((FoodList)serializer.Deserialize(reader)).Foods.Length; i++){
				foodlist.Add(((FoodList)serializer.Deserialize(reader)).Foods[i]);
			}
		}

		foreach(Food child in foodlist){
			Debug.Log(child.name + " : " + child.cal);
		}*/
		}

		for(int i = 0; i < foodList.Foods.Length; i++){
			Debug.Log(foodList.Foods[i].name + " : " + foodList.Foods[i].cal);
		}
	}
}

[SerializableAttribute]
[XmlRoot("Result")]
public class FoodList{
	[XmlElementAttribute("food")]
	public Food[] Foods;
}

[SerializableAttribute]
public class Food{
	[XmlElementAttribute("id")]
	public int id;
	[XmlElementAttribute("name")]
	public string name;
	[XmlElementAttribute("cal")]
	public int cal;
}