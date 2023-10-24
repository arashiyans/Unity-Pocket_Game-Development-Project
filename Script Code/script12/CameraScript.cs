using UnityEngine;  
using System.Collections;  
public class CameraScript : MonoBehaviour {  
  public Camera MainCamera;  
  public Camera Camera1;  
  public Camera Camera2;  
  public Camera Camera3;  
  // Use this for initialization  
  void Start () {  
            CameraStatus(false);  
            MainCamera.GetComponent<Camera>().enabled = true;  
       }  
   void CameraStatus(bool enabled){  
            MainCamera.GetComponent<Camera>().enabled = enabled;  
            Camera1.GetComponent<Camera>().enabled = enabled;  
            Camera2.GetComponent<Camera>().enabled = enabled;  
            Camera3.GetComponent<Camera>().enabled = enabled;  
       }  
   void CameraSplit(){  
            CameraStatus(true);  
            MainCamera.GetComponent<Camera>().rect = new 
	Rect(0,0,0.5f,0.5f);  
            Camera1.GetComponent<Camera>().rect = new 
	Rect(0.5f,0,1f,0.5f);  
            Camera2.GetComponent<Camera>().rect = new 
	Rect(0f,0.5f,0.5f,1f);  
            Camera3.GetComponent<Camera>().rect = new 
	Rect(0.5f,0.5f,1f,1f);  
       }  
   // Update is called once per frame  
   void Update () {  
            if (Input.GetKey("1")){  
	               CameraStatus(false);  
	               MainCamera.GetComponent<Camera>().enabled = true;  
	               MainCamera.GetComponent<Camera>().rect = new Rect(0, 0, 1, 1);  
	          }  
	      if (Input.GetKey("2")){  
	               CameraStatus(false);  
	               Camera1.GetComponent<Camera>().enabled = true;  
	               Camera1.GetComponent<Camera>().rect = new Rect(0, 0, 1, 1);  
	          }  
	      if (Input.GetKey("3")){  
	               CameraStatus(false);  
	               Camera2.GetComponent<Camera>().enabled = true;  
	               Camera2.GetComponent<Camera>().rect = new Rect(0, 0, 1, 1);  
	          }  
	      if (Input.GetKey("4")){  
	               CameraStatus(false);  
	               Camera3.GetComponent<Camera>().enabled = true;  
	               Camera3.GetComponent<Camera>().rect = new Rect(0, 0, 1, 1);  
	          }  
	      if (Input.GetKey("5")){  
	               CameraSplit();  
	          }  
	 }  
	 } 
