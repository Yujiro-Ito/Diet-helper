using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour {
	public const float FADE_TIME = 2;
	private GameObject _fadeCanvas;
	[HideInInspector]
	public bool Fade = false;
	[HideInInspector]
	[ColorUsageAttribute(false)]
	public Color FadeColor;
	private float _timeCount;

	void Awake(){
		_fadeCanvas = Resources.Load("Prefabs/FadeCanvas") as GameObject;
		_timeCount = 0;
	}

	public void SceneSwitch(string sceneName){
		if(Fade){
			StartCoroutine(FadeAndSwitch(sceneName));
		} else {
			SceneManager.LoadScene(sceneName);
		}
	}

	//Fadeする際の処理
	private IEnumerator FadeAndSwitch(string sceneName){
		GameObject ins_fadeCanvas = (GameObject)Instantiate(_fadeCanvas, _fadeCanvas.transform.position, Quaternion.identity);
		Image fadeImage = ins_fadeCanvas.GetComponentInChildren<Image>();
		Color fadeColor = FadeColor;
		DontDestroyOnLoad(ins_fadeCanvas);
		//黒くなる
		while(fadeImage.color.a < 1){
			_timeCount += Time.deltaTime;
			fadeColor.a += Mathf.Lerp(0, FADE_TIME, _timeCount); 
			fadeImage.color = fadeColor;
			yield return new WaitForEndOfFrame();
			if(fadeImage.color.a > 1){
				break;
			}
		}

		//シーン遷移を行う
		SceneManager.LoadScene(sceneName);

		//透明になる
		while(fadeImage.color.a > 0){
			fadeColor.a = 0;
		}
		yield break;
	}
}
