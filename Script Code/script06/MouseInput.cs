using UnityEngine;  
using System.Collections;  
public class MouseInput : MonoBehaviour {  
string myText, myText2, myText3, myText4;  
int number;  
float delta;  
// Use this for initialization  
void Start () {  
         number = 0;  
     }  
 // Update is called once per frame  
 void Update () {  
          if (Input.GetKey(KeyCode.Mouse0)){  
         myText = "Mouse: Tombol Kiri";  
    }   
if (Input.GetMouseButton(1)){  
         myText = "Mouse: Tombol Kanan";  
    }   
myText2 = "Position: "+Input.mousePosition.ToString();  
if (Input.mouseScrollDelta.y > 0){  
         delta = Input.mouseScrollDelta.y;  
         number++;  
    } else if (Input.mouseScrollDelta.y < 0) {  
         delta = Input.mouseScrollDelta.y;  
         number--;  
    }  
myText3 = "Scroll: "+delta.ToString();  
          myText4 = "Value: "+number.ToString();  
     }  
 void OnGUI(){  
          GUILayout.BeginArea(new Rect(10,10,300,200));  
          GUILayout.Label(myText);  
          GUILayout.Label(myText2);  
          GUILayout.Label(myText3);  
          GUILayout.Label(myText4);  
          GUILayout.EndArea();  
     }  
  }  
