using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Tmp : MonoBehaviour {
	public Text text;

	// Use this for initialization
	void Start () {
		if(Application.platform == RuntimePlatform.Android){
			string oriPath = System.IO.Path.Combine(Application.streamingAssetsPath, "savedata.json");
			text.text = Application.persistentDataPath;
			FileInfo info = new FileInfo(oriPath);
			if(!info.Exists){
				text.text += "\nなかったよ";
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
