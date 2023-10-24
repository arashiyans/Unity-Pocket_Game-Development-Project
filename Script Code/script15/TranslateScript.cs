using UnityEngine;  
public class TranslateScript : MonoBehaviour {  
 float maxjump = 2;  
 float power = 300;  
 float distGround;  
 Rigidbody myRigidbody;  
 // Use this for initialization  
 void Start () {  
           myRigidbody = GetComponent<Rigidbody>();  
           distGround = GetComponent<BoxCollider>().bounds.extents.y;  
      }  
  // Update is called once per frame  
  void Update () {  
           if (Input.GetKey(KeyCode.UpArrow)){  
           transform.Translate(Vector3.forward * Time.deltaTime);  
      }  
  if (Input.GetKey(KeyCode.DownArrow)){  
           transform.Translate(Vector3.back * Time.deltaTime);  
      }  
  if (Input.GetKey(KeyCode.LeftShift) && 
      Input.GetKey(KeyCode.RightArrow)){  
           transform.Translate(Vector3.right * Time.deltaTime);  
      } else  
  if (Input.GetKey(KeyCode.RightArrow)){  
           transform.Rotate(0,1,0);  
      }  
  if (Input.GetKey(KeyCode.LeftShift) && 
      Input.GetKey(KeyCode.LeftArrow)){  
           transform.Translate(Vector3.left * Time.deltaTime);  
      } else  
  if (Input.GetKey(KeyCode.LeftArrow)){  
           transform.Rotate(0,-1,0);  
      }  
  if (isGrounded () && Input.GetKeyUp(KeyCode.Space)){  
	                 myRigidbody.AddForce(transform.up * power);  
	            }  
       }  
	       bool isGrounded () {  
		            return Physics.Raycast(transform.position, -Vector3.up, 
		                                      distGround + 0.1f);  
		       }  
 }  
