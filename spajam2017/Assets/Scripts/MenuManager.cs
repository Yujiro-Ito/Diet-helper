using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {
	//---------Singleton------------//
	private static GameObject _singletonObject;
	private static MenuManager _singleton;
	//------------------------------//

	//Data
	private string menuName;
	public string MenuName{ get{ return menuName; } set{ menuName = value; }}

	private int menuCal;
	public int MenuCal{ get{return menuCal; } set{ menuCal = value; }}

	private static SaveData saveData;
	public SaveData Save{
		get{ return saveData; }
	}


	public static MenuManager Instance(){
		if (_singleton == null) {
			_singletonObject = new GameObject("Singleton");
			_singletonObject.AddComponent<MenuManager> ();
			_singleton = _singletonObject.GetComponent<MenuManager> ();

			//saveData
			saveData = new SaveData();
		}
		return _singleton;
	}

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {

	}
}
