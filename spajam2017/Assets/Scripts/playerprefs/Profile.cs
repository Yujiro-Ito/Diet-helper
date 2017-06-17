using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Profile : MonoBehaviour {

	public Text namefield;
	public Text sexfield;
	public Text tollfield;
	public Text	weightfield;
	public Text oldfield;
	public Text neta2field;

	public void GetName(){
		PlayerPrefs.SetString( "name", namefield.text );
		PlayerPrefs.SetString( "sex", sexfield.text );
		PlayerPrefs.SetString( "toll", tollfield.text );
		PlayerPrefs.SetString( "weight", weightfield.text );
		PlayerPrefs.SetString( "old", oldfield.text );
		PlayerPrefs.SetString( "neta2", neta2field.text );

	}
}
