using UnityEngine;  
using System.Collections;  
public class CloneBall : MonoBehaviour {  
  public GameObject SpawnPoint;  
  public GameObject Ball;  
  GameObject cloneball;  
  // Use this for initialization  
  void Start () {  
      }  
   // Update is called once per frame  
   void Update () {  
       }  
   void OnGUI(){  
            GUILayout.BeginArea(new Rect(10,10,100,200));  
            if (GUILayout.Button("Create Ball")){  
	            GameObject temp = (GameObject) GameObject.Instantiate(Ball, SpawnPoint.transform.position, SpawnPoint.transform.rotation);  
	            Destroy(temp,5);  
	       }  
    GUILayout.EndArea();  
       }  
}  
