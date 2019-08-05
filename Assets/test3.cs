using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		AnimManager.current.PlayAnim(new Anim(this.transform,"skill3"));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
