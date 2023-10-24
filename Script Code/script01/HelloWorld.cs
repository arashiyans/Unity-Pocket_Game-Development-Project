using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour {

	public string myText;  

	// Use this for initialization
	void Start () {
		Debug.Log ("Hello World");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI(){  
		GUILayout.BeginArea(new Rect(10,10,200,200));  
		GUILayout.Label(myText);  
		GUILayout.EndArea();  
	}  

}
