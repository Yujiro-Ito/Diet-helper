using UnityEngine;
using UnityEngine.UI;

public class ChooseFood : MonoBehaviour {
	public Image back;
	public void Push(){
		back.color = Color.yellow;
		FindObjectOfType<DecideFood>().AssignData(back, GetComponentInParent<Node>());
	}
}
