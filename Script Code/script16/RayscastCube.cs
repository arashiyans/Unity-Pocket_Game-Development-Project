using UnityEngine;  
using System.Collections;  

public class RayscastCube : MonoBehaviour {  
   Ray myRay;  
   RaycastHit myRaycasthit;  
   public GameObject target;  
   public bool isDebug = true;  
   public bool isMoving = false;  
   // Use this for initialization  
    void Start () {  
    }  

	// Update is called once per frame  
	void Update () {  
    if (Input.GetMouseButtonUp(1)){  
           myRay = Camera.main.ScreenPointToRay(Input.mousePosition);  
           Physics.Raycast(myRay, out myRaycasthit, 300);  
           target.transform.position = myRaycasthit.point + new Vector3(0,0.01f,0);  
           transform.LookAt(target.transform);  
     }       
     if (isMoving && Vector3.Distance(transform.position, target.transform.position) > 0.6f){  
                transform.position = Vector3.MoveTowards(transform.position, target.transform.position,10*Time.deltaTime);  
           }  
     if (isDebug){  
                Debug.DrawLine (GameObject.Find("Main Camera"). 
                                gameObject.transform.position, myRaycasthit.point, 
                                Color.red);  
           }  
}  
 }  
