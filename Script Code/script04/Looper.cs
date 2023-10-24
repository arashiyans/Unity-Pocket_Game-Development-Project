using UnityEngine;  
using System.Collections;  
public class Looper : MonoBehaviour {  
 int number1, number2, number3, number4, number5, countdown;  
     // Use this for initialization  
     void Start () {  
        number1 = 0;  
        number2 = 0;  
        number3 = 0;  
        number4 = 0;  
        number5 = 0;  
        countdown = 3;  
        InvokeRepeating("CountDown",1,1);  
    }  
// Update is called once per frame  
void Update () {  
         if (countdown == 0){  
                 number1++;  
            }  
    }  
void FixedUpdate () {  
         if (countdown == 0){  
                 number2++;  
            }  
    }  
void CountDown(){  
         countdown--;  
         if (countdown == 0){  
                 InvokeRepeating("Looping1",1,1);  
                 InvokeRepeating("Looping2",5,0.5f);  
                 Invoke("NoLooping",10);  
                 CancelInvoke("CountDown");  
            }  
    }  
      void Looping1(){  
           number3++;  
      }  
  void Looping2(){  
           number4++;  
      }  
  void NoLooping(){  
           number5++;  
      }  

  void OnGUI(){  
           GUILayout.BeginArea(new Rect(10,10,400,200));  
           if (countdown == 0){  
                 GUILayout.Label("Update Increment: "+number1.ToString());  
                 GUILayout.Label("FixedUpdate Increment: "+number2.ToString());  
                 GUILayout.Label("Start At: 1 Sec (Interval 1): "+number3.ToString());  
                 GUILayout.Label("Start At: 5 Sec (Interval 0.5): "+number4.ToString());  
                 GUILayout.Label("Start At: 10 Sec (No Looping): "+number5.ToString());  
		            } else {  
		                 GUILayout.Label("Count Down: "+countdown.ToString());  
		            }  
		            GUILayout.EndArea();  
		       }  
	  }  
