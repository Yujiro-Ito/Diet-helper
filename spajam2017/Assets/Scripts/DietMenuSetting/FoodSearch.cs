using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

public class FoodSearch : MonoBehaviour {
	public Text recomend;
	public GameObject content;
	private SlideTest slider;
	private GameObject _nodePrefab;

	public void GetFoods(string foodName){
		StartCoroutine(GetFoodList(foodName));
		slider = GetComponent<SlideTest>();
		_nodePrefab = Resources.Load("Prefabs/Node") as GameObject;
	}

	private IEnumerator GetFoodList(string foodName){
		recomend.text = "少々お待ちください";
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
		FoodList foodList;
		using(TextReader reader = new StringReader(www.text)){
			foodList = ((FoodList)serializer.Deserialize(reader));
		}
		//何もデータがなかった場合,もう一度やり直す
		if(foodList.Foods == null){
			StartCoroutine(ChangeText());
			yield break;
		} else {
			slider.slideInAnim();
		}

		for(int i = 0; i < foodList.Foods.Length; i++){
			GameObject obj = (GameObject)Instantiate(_nodePrefab, Vector3.zero, Quaternion.identity);
			obj.transform.SetParent(content.transform);
			obj.transform.localScale = Vector3.one;
			obj.GetComponent<Node>().AssignData(foodList.Foods[i].name, foodList.Foods[i].cal);
		}
	}

	private IEnumerator ChangeText(){
		recomend.text = "食べ物が見つからなかったよ";
		yield return new WaitForSeconds(2);
		recomend.text = "食べたい物の名前を\n入力してください";
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