using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance2D : MonoBehaviour
{

	private List<string> redtags = new List<string>(){};
    private List<string> bluetags = new List<string>(){};
    
    private List<string> redtagots = new List<string>(){};
    private List<string> bluetagots = new List<string>(){};
    
    private List<string> redtageqts = new List<string>();
    private List<string> bluetageqts = new List<string>();

    private Transform transform;
    
    private void Awake()
    {
	    this.transform = this.GetComponent<Transform>();
    }


    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
