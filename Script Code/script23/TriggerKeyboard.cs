using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerKeyboard : MonoBehaviour {

	public bool TouchScreenMode = false;
	bool IsKeyboardShow = false;
	VirtualKeyboard vkeyboard;

	// Use this for initialization
	void Start () {
		vkeyboard = new VirtualKeyboard ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ToggleKeyboard () {
		if (TouchScreenMode){
			IsKeyboardShow = !IsKeyboardShow;
			if (IsKeyboardShow) {
				vkeyboard.ShowTouchKeyboard ();
			} else {
				vkeyboard.HideTouchKeyboard ();
			}
		} else {
			IsKeyboardShow = !IsKeyboardShow;
			if (IsKeyboardShow) {
				vkeyboard.ShowOnScreenKeyboard ();
			} else {
				vkeyboard.HideOnScreenKeyboard ();
			}
		}

	}	
}

