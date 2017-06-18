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

		//nullなら新しく作っちゃえ
		if(result == null) result = new Data();

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
public class Data{
	public List<SaveNode> saveNode = new List<SaveNode>();
}

[System.SerializableAttribute]
public class SaveNode{
	public int cal;
	public string foodName;
	public string menu;
}
