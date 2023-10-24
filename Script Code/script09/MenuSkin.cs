using UnityEngine;  
using System.Collections;  
public class MenuSkin : MonoBehaviour {  
public GUISkin mySkin;  
bool value = true;  
// Use this for initialization  
void Start () {  
    }  
// Update is called once per frame  
 void Update () {  
     }  
 void OnGUI () {  
          GUI.skin = mySkin;  
          value = GUI.Toggle(new Rect(20, 20, 60,60), value, "");  
          if (GUI.Button(new Rect(20, Screen.height-70, 200,60), 
                         "Mulai")){  
                 Debug.Log("Mulai diklik!");  
            }  
          if (GUI.Button(new Rect(240, Screen.height-70, 200,60), 
                         "Pilihan")){  
                 Debug.Log("Pilihan diklik!");  
            }  
          if (GUI.Button(new Rect(460, Screen.height-70, 200,60), 
                         "Keluar")){  
                 Application.Quit();  
            }  
     }  
}  
