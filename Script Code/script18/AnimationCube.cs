using UnityEngine;  
using System.Collections;  
public class AnimationCube : MonoBehaviour {  
    Animator myAnim;  
    // Use this for initialization  
    void Start () {  
        myAnim = GetComponent<Animator>();  
   }  
// Update is called once per frame  
void Update () {  
    }  
void OnGUI(){  
         GUILayout.BeginArea(new Rect(10,10,100,200));  
         if (GUILayout.Button("Animation 1")){  
            myAnim.Play("Animasi1");  
       }  
  if (GUILayout.Button("Animation 2")){  
            myAnim.Play("Animasi2");  
       }  
  if (GUILayout.Button("Animation 3")){  
            myAnim.Play("Animasi3");  
       }  
  GUILayout.EndArea();  
    }  
}  
