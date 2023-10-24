using UnityEngine;  
 using System.Collections;  
 public class WebCamera : MonoBehaviour {  
 int counter = 0;  
 string myText;  
 WebCamTexture webcamTexture;  
 WebCamDevice[] webcamDevices;  
 public string deviceName;  

 public string generateFilename(int width, int height) {  
           return string.Format("{0}/screenshot/picture_{1}x{2}_{3}.jpg",   
                           Application.dataPath,   
                           width, height,   
                           System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"));  
      }  
  // Use this for initialization  
  void Start () {  
           webcamDevices = WebCamTexture.devices;  
           deviceName = webcamDevices[0].name;   
           webcamTexture = new WebCamTexture(deviceName, Screen.width, 
                                             Screen.height);  
           GetComponent<Renderer>().material.mainTexture = webcamTexture;  
           webcamTexture.Play();  
      }  
  // Update is called once per frame  
  void Update () {  
      }  
  void OnGUI() {     
           GUILayout.BeginArea(new Rect(10,10,300,200));  
           if (GUILayout.Button("Photo!")){  
         TakePicture();  
    }  
            GUILayout.Label(myText);  
            GUILayout.EndArea();  
       }  
   void TakePicture(){  
            Texture2D pic = new Texture2D(webcamTexture.width, 
                                          webcamTexture.height);  
            pic.SetPixels(webcamTexture.GetPixels());  
            pic.Apply();  
            myText = generateFilename(800,600);  
            System.IO.File.WriteAllBytes(myText, pic.EncodeToJPG());  
            counter++;  
       }  
}  
