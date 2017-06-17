using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DietMenu : MonoBehaviour {

	public Text text;

	public int _time;

	//１時間での消費カロリー
	public int _diet;
	public static int WALK = 2;
	public static int RUN = 5;
	public static int SWIM = 10;

	//カロリー登録
	public static int CAKE = 1000;
	public static int POTATE = 500;
	public static int JUICE = 100;

	// Use this for initialization
	void Start () {
		
		//ダイエット方法を選ぶ
		_diet = Random.Range(0, 9);


	}
	
	// Update is called once per frame
	void Update () {

		if (0 <= _diet && _diet < 3) {
			_time = CAKE / WALK;
			text = this.GetComponent<Text>();
			text.text = _time + "時間歩いてください";
		}
		if( 3<= _diet && _diet < 6 ){
			_time = CAKE / RUN;
			text = this.GetComponent<Text>();
			text.text = _time + "時間走ってください";
		}
		if (6 <= _diet && _diet < 9) {
			_time = CAKE / SWIM;
			text = this.GetComponent<Text>();
			text.text = _time + "時間泳いでください";
		}

		
	}
}
