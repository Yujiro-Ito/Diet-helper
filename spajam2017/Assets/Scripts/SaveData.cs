using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;

public class SaveData {
	public Data GetSaveData(){
		string filePath = Application.dataPath + "/savedata.json";
		Data result;
		//ファイル検索
		if(!File.Exists(filePath)){
			Debug.LogError("Fileが見つかりません");
			return null;
		}
		//ファイルから読み込む
		using(FileStream st = new FileStream(filePath, FileMode.Open)){
			using(StreamReader sr = new StreamReader(st)){
				result = JsonUtility.FromJson<Data>(sr.ReadToEnd());
			}
		}

		return result;
	}

	private void Save(Data data){
		string filePath = Application.dataPath + "/savedata.json";
		//データを移す
		using(FileStream st = new FileStream(filePath, FileMode.Create, FileAccess.Write)){
			using(StreamWriter sw = new StreamWriter(st)){
				sw.WriteLine(JsonUtility.ToJson(data));
			}
		}
	}

	public void Add(SaveNode node){
		Data saveData = GetSaveData();
		saveData.saveNode.Add(node);
		Save(saveData);
	}

	public void Delete(SaveNode node){
		Data saveData = GetSaveData();
		//削除
		if(saveData.saveNode.Remove(node))Debug.Log("データの削除が完了しました。");
		else Debug.Log("データの削除ができませんでした。");
		//セーブ
		Save(saveData);
	}
}

[System.SerializableAttribute]
public class Data{
	public List<SaveNode> saveNode;
}

[System.SerializableAttribute]
public class SaveNode{
	public int cal;
	public string foodName;
	public string menu;
}
