using UnityEngine;  
using System.Collections;  
public class AndroidInput : MonoBehaviour {  
Vector3 tempaccel;  
Vector2 startpos, currpos;  
string myText1, myText2, myText3, myText4;  
int temptouch;  
// Use this for initialization  
void Start () {  
          temptouch = 0;        
     }  
 // Update is called once per frame  
 void Update () {  
          tempaccel = Input.acceleration;  
          if (Input.touchCount > 0){  
       temptouch++;       
       foreach (Touch t in Input.touches){  
                 switch(t.phase){  
                      case TouchPhase.Began:  
                           startpos = t.position;            
                          break;  
                      case TouchPhase.Moved:  
                           currpos = t.position;            
                          break;  
                     }  
            }  
  }  
          myText1 = "Total Touch: "+temptouch.ToString();  
          myText2 = "Acceleration: "+tempaccel.ToString();  
          myText3 = "StartPos: "+startpos.ToString();  
          myText4 = "CurrPos: "+currpos.ToString();  
     }  
 void OnGUI(){  
          if (GUI.Button(new Rect(Screen.width - 60, 10, 50, 50), "X")){  
       Application.Quit();  
  }  
           GUILayout.BeginArea(new Rect(10,10,300,200));  
           GUILayout.Label(myText1);  
           GUILayout.Label(myText2);  
           GUILayout.Label(myText3);  
           GUILayout.Label(myText4);  
           GUILayout.EndArea();  
      }  
 }  
