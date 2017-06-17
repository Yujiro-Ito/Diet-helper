using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM_singleton : MonoBehaviour {
	
	private static GameObject _singletonObject;
	private static GM_singleton _singleton;

	private GameObject SceneFadeObj;
	public static GM_singleton Instance() {
		if (_singleton == null) {
			_singletonObject = new GameObject ("Singleton");
			_singletonObject.AddComponent<GM_singleton> ();
			_singleton = _singletonObject.GetComponent<GM_singleton> ();
		}
		return _singleton;
	}

	// Use this for initialization
	void Start () {
		//SceneFadeObj = GameObject.Find ("transporter_01_damge2/[CameraRig]/Camera(head)/Camera(eye)");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//クリア後タイトルにいく
	public void GoTitleScene()
	{
		//Camera.main.GetComponent<SceneFade> ().LoadSceenWithFade ("Title");
		//Application.LoadLevel("Title");
	}
	//クリアsceneにいく
	public void GoClearScene()
	{
		//SceneFadeのFadeOutメソッドを呼び出したあとClearシーンに遷移する
		//Camera.main.GetComponent<SceneFade> ().LoadSceenWithFade ("Clear");
	}

	//オーバsceneにいく
	public void GoOverScene()
	{
		Application.LoadLevel("Title");
		//Camera.main.GetComponent<SceneFade> ().LoadSceenWithFade ("Title");
	}
}
