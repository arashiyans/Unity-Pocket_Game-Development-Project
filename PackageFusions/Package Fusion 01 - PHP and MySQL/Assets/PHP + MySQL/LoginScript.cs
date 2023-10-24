using UnityEngine;
using System.Collections;
using UnityEngine.UI;  

public class LoginScript : MonoBehaviour {

	public string URL; 
	public InputField txtUser;  
	public InputField txtPassword;  
	public Text txtStatus;  
	string vText;
	WWW php_login; 
	WWWForm php_form; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator PostLogin(){  
		php_form = new WWWForm();
		php_form.AddField("unity_user",txtUser.text); 
		php_form.AddField("unity_pass",txtPassword.text);
		php_login = new WWW(URL, php_form);
		yield return php_login;
		vText = php_login.text;
		if (vText != "" && vText != "INVALID"){  
			txtStatus.text = "Login sukses. Selamat datang, "+vText;
		}
	}
	
	public void FusionLogin () {
		StartCoroutine(PostLogin());
	}
}
