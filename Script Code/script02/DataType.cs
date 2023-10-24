using UnityEngine;  
using System.Collections;  
public class DataType : MonoBehaviour {  
      public int Bulat;  
      public float Desimal;  
      public char Karakter;  
      public string Text;  
      public enum vote { Bagus, Lumayan, Garing }   
      public vote Comment;  
      string myText;  
      public Vector2 Koordinat2D;  
      public Vector3 Koordinat3D;  
      // Use this for initialization  
      void Start () {  
            if (Comment == vote.Bagus){  
                 myText = "Bagus Banget Euy!";  
            } else {  
                 myText = "Ya gitu deh!";  
            }  
       }  
       // Update is called once per frame  
       void Update () {  
       }  
       void OnGUI(){  
	           GUILayout.BeginArea(new Rect(10,10,200,200));  
	           GUILayout.Label("Bilangan Bulat: "+Bulat.ToString());  
	           GUILayout.Label("Bilangan Desimal: "+Desimal.ToString());  
	           GUILayout.Label("Satu Karakter: "+Karakter.ToString());  
	           GUILayout.Label("Tulisan: "+Text.ToString());  
	           GUILayout.Label("Komentar: "+myText.ToString());  
	           GUILayout.Label("2D: "+Koordinat2D.ToString());  
	           GUILayout.Label("3D: "+Koordinat3D.ToString());  
	           GUILayout.EndArea();  
	      }  
}  
