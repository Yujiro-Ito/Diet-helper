using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DietMenuNode : MonoBehaviour {
	public Text foodName;
	public Text calorie;
	public Text menu;
	private SaveNode _node;
	
	public void AssignText(SaveNode node){
		foodName.text = node.foodName;
		calorie.text = node.cal + "kcal";
		menu.text = node.menu;
		_node = node;
	}

	public void DeleteButton(){
		MenuManager.Instance().Save.Delete(_node);
		Destroy(this.gameObject);
	}
}
