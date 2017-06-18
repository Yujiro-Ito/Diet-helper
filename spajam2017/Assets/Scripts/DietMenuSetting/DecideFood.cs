using UnityEngine.UI;
using UnityEngine;

public class DecideFood : MonoBehaviour {
	public GetName getName;
	public MenuData menuData;
	private Node _currentChoose;
	private Image _currentNodeBackground;
	public ButtonScript buttonScript;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Push(){
		if(_currentChoose != null){
			getName.SetFoodText(_currentChoose.FoodName, _currentChoose.Calorie);
			menuData.SetFoodText(_currentChoose.FoodName, _currentChoose.Calorie);
			buttonScript.ButtonPush();
		}
	}

	public void AssignData(Image newBack, Node newNode){
		if(_currentNodeBackground != null){
			if(_currentChoose == null || _currentChoose.FoodName != newNode.FoodName){
				_currentChoose = newNode;
				_currentNodeBackground.color = Color.white;
			}
		}
		_currentNodeBackground = newBack;
	}
}
