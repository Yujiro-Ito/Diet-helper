using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ad : MonoBehaviour {
	public Sprite[] adImages; 
	public Image image;
	public int count;

	// Use this for initialization
	void Start () {
		count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		count++;
		if (count >= 1200) {
			image.sprite = adImages [Random.Range (0, adImages.Length)];
			count = 0;
		}
	}
}
