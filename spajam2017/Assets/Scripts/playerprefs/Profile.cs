using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

public class Profile : MonoBehaviour {

	public ToggleGroup toggleGroup;

	public Text namefield;

	public Text tollfield;
	public Text	weightfield;
	public Text oldfield;
	public Text neta2field;

	public Toggle man;
	public Toggle women;
	public Toggle other;

	public void GetName(){
		PlayerPrefs.SetString( "name", namefield.text );

		PlayerPrefs.SetString( "toll", tollfield.text );
		PlayerPrefs.SetString( "weight", weightfield.text );
		PlayerPrefs.SetString( "old", oldfield.text );
		PlayerPrefs.SetString( "neta2", neta2field.text );
	}

	public void GetCheck(){
		
		string name = PlayerPrefs.GetString ("name");
		string toll = PlayerPrefs.GetString ("toll");
		string weight = PlayerPrefs.GetString ("weight");
		string old = PlayerPrefs.GetString ("old");
		string neta2 = PlayerPrefs.GetString ("neta2");

		if (man.isOn == true || women.isOn == true || other.isOn == true) {
			if (name != "" && toll != "" && weight != "" && old != "" && neta2 != "") {
				SceneManager.LoadScene ("Title");
			}
		}
	}
}
						