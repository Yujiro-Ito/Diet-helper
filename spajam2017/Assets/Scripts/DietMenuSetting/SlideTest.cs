using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideTest : MonoBehaviour {

	Animator _animator;

	// Use this for initialization
	void Start () {
		_animator = GetComponent<Animator>();
	}

	public void slideInAnim(){
		_animator.SetBool ("running",true);
	}

	public void slideOutAnim(){
		_animator.SetBool ("runnning",false);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
