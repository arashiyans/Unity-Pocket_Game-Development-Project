using UnityEngine;  
using System.Collections;  
public class ArrayClass : MonoBehaviour {  
 public int[] Numbers;  
     public string[] Texts;  
     [System.Serializable]  
     public class Collection{  
         public int ID;  
         public string AnyValue;  
     }  
 string myText1, myText2, myText3;  
 public Collection[] Collections;   
 // Use this for initialization  
 void Start () {  
          myText1 = "";  
          for (int c=0; c<Numbers.Length; c++){  
                myText1 = myText1 + Numbers[c].ToString()+' ';  
           }  
       myText2 = "";  
       for (int c=0; c<Texts.Length; c++){  
                myText2 = myText2 + Texts[c] +' ';  
           }  
       myText3 = "";  
       for (int c=0; c<Collections.Length; c++){  
                myText3 = myText3 + Collections[c].ID.ToString()+ 	":"+Collections[c].AnyValue+" ";  
           }  
  }  
 // Update is called once per frame  
 void Update () {  
     }  

 void OnGUI(){  
          GUILayout.BeginArea(new Rect(10,10,400,200));  
          GUILayout.Label("Array Integer: "+myText1);  
          GUILayout.Label("Array String: "+myText2);  
		            GUILayout.Label("Array Object: "+myText3);  
		            GUILayout.EndArea();  
		       }  
	  }  
