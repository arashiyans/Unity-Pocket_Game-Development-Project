using UnityEngine;  
using System.Collections;  
public class ShootingTarget : MonoBehaviour {  
public GameObject SpawnPoint;  
public GameObject Ball;  
GameObject shootingball;  
GameObject temp;  
GameObject camera;  
bool goRight = true;  
 // Use this for initialization  
 void Start () {  
          camera = GameObject.Find("Main Camera");  
     }  
 // Update is called once per frame  
 void Update () {  
          if (goRight){  
           camera.transform.Rotate(0,0.3f,0);  
           if (camera.transform.eulerAngles.y > 110){  
                     goRight = false;  
                }   
      } else {  
           camera.transform.Rotate(0,-0.3f,0);  
           if (camera.transform.eulerAngles.y < 70){  
                     goRight = true;  
                }  
      }  
  if(Input.GetKeyUp(KeyCode.Space)){  
           temp = (GameObject) GameObject.Instantiate(Ball, 
                                                      SpawnPoint.transform.position, 
                                                      SpawnPoint.transform.rotation);  
           Destroy(temp,5);       
      }  
  if (temp){  
          temp.GetComponent<Rigidbody>().
		AddRelativeForce(Vector3.forward * 500);  
	           }       
	       }  
	 }  
