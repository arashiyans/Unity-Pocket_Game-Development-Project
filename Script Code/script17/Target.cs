using UnityEngine;  
using System.Collections;  
public class Target : MonoBehaviour {  
public GameObject text3d;  
    public string MyText;  
    int score;  
    // Use this for initialization  
    void Start () {  
        HideAgain();  
        text3d.GetComponent<TextMesh>().text = MyText;  
        score = 0;  
    }  
// Update is called once per frame  
void Update () {  
    }  
void HideAgain(){  
         text3d.GetComponent<MeshRenderer>().enabled = false;  
    }  
void OnTriggerEnter(Collider other){  
         if (other.gameObject.tag == "Ball"){  
                Destroy(other.gameObject);  
                score++;  
                text3d.GetComponent<MeshRenderer>().enabled = true;  
                Invoke("HideAgain", 3);  
           }  
    }  
void OnGUI(){  
        GUILayout.BeginArea(new Rect(10,10,400,200));  
        GUILayout.Label("Score : "+score.ToString());  
        GUILayout.EndArea();  
   }  
  } 
