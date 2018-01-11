using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;

public class SaveData {
	public SaveNodeContainer GetSaveData(){
		string filePath;
#if UNITY_EDITOR
		filePath = Application.streamingAssetsPath + "/savedata.json";
#elif UNITY_ANDROID
		filePath = Application.persistentDataPath + "/savedata.json";
#endif
		FileInfo info = new FileInfo(filePath);
		Debug.Log(filePath);
		SaveNodeContainer result;
		//ファイル検索
		if(!info.Exists){
			Debug.LogError("Fileが見つかりません");
			return null;
		}
		//ファイルから読み込む
		using(StreamReader sr = info.OpenText()){
			result = JsonUtility.FromJson<SaveNodeContainer>(sr.ReadToEnd());
		}

		//nullなら新しく作っちゃえ
		if(result == null) result = new SaveNodeContainer();

		return result;
	}

	private void Save(SaveNodeContainer data){
		string filePath;
#if UNITY_EDITOR
		filePath = Application.streamingAssetsPath + "/savedata.json";
#elif UNITY_ANDROID
		filePath = Application.persistentDataPath + "/savedata.json";
#endif
		FileInfo info = new FileInfo(filePath);
		
		//データを移す
		using(StreamWriter sw = info.CreateText()){
			sw.WriteLine(JsonUtility.ToJson(data));
		}
	}

	public void Add(SaveNode node){
		SaveNodeContainer saveData = GetSaveData();
		saveData.saveNode.Add(node);
		Save(saveData);
	}

	public void Delete(SaveNode node){
		SaveNodeContainer saveData = GetSaveData();
		//削除
		if(saveData.saveNode.Count != 0){
			int count = 0;
			foreach(SaveNode data in  saveData.saveNode){
				if(data.foodName == node.foodName && data.menu == node.menu){
					saveData.saveNode.RemoveAt(count);
					Debug.Log("データを削除しました。");
					//セーブ
					Save(saveData);
					return;
				}
				count++;
			}
		}
		Debug.Log("データの削除ができませんでした。");
	}
}

[System.SerializableAttribute]
public class SaveNodeContainer{
	public List<SaveNode> saveNode = new List<SaveNode>();
}

[System.SerializableAttribute]
public class SaveNode{
	public int cal;
	public string foodName;
	public string menu;
}
