using UnityEngine;  
using System.Collections;  
public class PlayParticle : MonoBehaviour {  
     public ParticleSystem myParticle;  
     // Use this for initialization  
     void Start () {  
    }  
// Update is called once per frame  
void Update () {  
     }  
 void OnGUI () {  
          GUILayout.BeginArea(new Rect(10,10,100,200));  
          if (GUILayout.Button("Play Smoke")){  
                myParticle.Play();  
           }  
          if (GUILayout.Button("Stop Smoke")){  
                 myParticle.Stop();  
           }  
          GUILayout.EndArea();  
     }  
 }  
