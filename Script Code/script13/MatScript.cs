using UnityEngine;  
using System.Collections;  
public class MatScript : MonoBehaviour {  
  public Material[] Mats;  
  Material CurrMat;  
  Renderer renderer;  
  // Use this for initialization  
  void Start () {  
           renderer = this.GetComponent<Renderer>();  
       }  
   // Update is called once per frame  
   void Update () {  
            transform.Rotate(0,1,0);  
       }  
   void OnMouseOver(){  
            renderer.material = Mats[3];  
       }  
   void OnMouseExit(){  
            renderer.material = CurrMat;  
       }  
   void OnGUI () {  
            GUILayout.BeginArea(new Rect(10,10,100,200));  
            if (GUILayout.Button("Merah")){  
	                 renderer.material = Mats[0];  
	                 CurrMat = renderer.material;  
	            }  
         if (GUILayout.Button("Hijau")){  
	                 renderer.material = Mats[1];  
	                 CurrMat = renderer.material;  
	            }  
         if (GUILayout.Button("Biru")){  
	                 renderer.material = Mats[2];  
	                 CurrMat = renderer.material;  
	            }  
            GUILayout.EndArea();  
       }  
	}  
