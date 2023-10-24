using UnityEngine;  
using System.Collections;  
public class CubeScript : MonoBehaviour {  
  public bool Cube1,Cube2,Cube3, Cube4;  
  public string WhichCube, WhatTag;  
  public GameObject WhoAmI;  
  // Use this for initialization  
  void Start () {  
      }  
   // Update is called once per frame  
   void Update () {  
            if (Cube1) transform.Rotate(1,0,0);  
            if (Cube2) GameObject.Find(WhichCube). 
	transform.Rotate(0,1,0);  
            if (Cube3) GameObject.FindGameObjectWithTag(WhatTag). 
	transform.Rotate(0,0,1);  
            if (Cube4 && WhoAmI != null) WhoAmI.transform.Rotate(1,1,1);  
       }  
}  
