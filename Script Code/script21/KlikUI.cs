using UnityEngine;  
using System.Collections;  
using UnityEngine.UI;  
public class KlikUI : MonoBehaviour {  
	  public GameObject TargetText, InputText;  
	  // Use this for initialization  
	  void Start () {  
	      }  
	  // Update is called once per frame  
	   void Update () {  
	       }  
	   public void ClickMe(){  
	            TargetText.GetComponent<Text>().text = 
		InputText.GetComponent<InputField>().text;  
	       }  
	}  
