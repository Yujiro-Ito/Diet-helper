using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DietMenuList : MonoBehaviour {
	private GameObject _dietMenuNodePrefab;
	public GameObject Content;

	// Use this for initialization
	void Start () {
		_dietMenuNodePrefab = Resources.Load("Prefabs/DietMenuNode") as GameObject;
		//必用分だけインスタンス
		SaveNodeContainer saveData = MenuManager.Instance().Save.GetSaveData();
		if(saveData.saveNode.Count != 0){
			foreach(SaveNode node in saveData.saveNode){
				GameObject ins = (GameObject)Instantiate(_dietMenuNodePrefab, Vector3.zero, Quaternion.identity);
				ins.GetComponent<DietMenuNode>().AssignText(node);
				ins.transform.SetParent(Content.transform);
				ins.transform.localScale = Vector3.one;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
