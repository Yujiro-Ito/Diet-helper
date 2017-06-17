using UnityEngine.UI;
using UnityEngine;

public class DecideFood : MonoBehaviour {
	public GetName getName;
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
			getName.SetNameText(_currentChoose.FoodName, _currentChoose.Calorie.ToString() + "kcal");
			buttonScript.ButtonPush();
		}
	}

	public void AssignData(Image newBack, Node newNode){
		_currentChoose = newNode;
		if(_currentNodeBackground != null)_currentNodeBackground.color = Color.white;
		_currentNodeBackground = newBack;
	}
}
