using UnityEngine;  
using System.Collections;  
public class AudioOption : MonoBehaviour {  
 AudioSource myAudio;  
 string btn;  
 float vol = 1, pit = 1;  
 // Use this for initialization  
 void Start () {  
           myAudio = GetComponent<AudioSource>();  
           btn = "Stop";  
           vol = PlayerPrefs.GetFloat("paramSuara");  
           pit = PlayerPrefs.GetFloat("paramNada");  
		   if (vol == 0) vol = 1;
		   if (pit == 0) pit = 1;
      }  
  // Update is called once per frame  
  void Update () {  
      }  

  void OnGUI () {  
           GUILayout.BeginArea(new Rect(10,10,200,200));  
           vol = GUILayout.HorizontalSlider(vol, 0, 1);  
           pit = GUILayout.HorizontalSlider(pit, 0, 1);  
           myAudio.volume = vol;  
           myAudio.pitch = pit;  
           if (GUILayout.Button(btn)){  
            if (btn == "Stop"){  
                     myAudio.Stop();  
                     btn = "Play";  
                } else {  
                     myAudio.Play();  
                     btn = "Stop";  
                }  
       }  
   if (GUILayout.Button("Simpan")){  
            PlayerPrefs.SetFloat("paramSuara",vol);  
            PlayerPrefs.SetFloat("paramNada",pit);  
       }  
   GUILayout.EndArea();  
      }  
}  
