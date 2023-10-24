using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingSceneManager : MonoBehaviour {

	public static int SceneIndex;
	public Slider LoadingBar;
	AsyncOperation async;

	// Use this for initialization
	void Start () {
		if (SceneIndex != 0) {
			StartCoroutine (StartLoadingProgress(SceneIndex));
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LoadingScene(int index){
		SceneIndex = index;
		SceneManager.LoadScene ("LoadingScene");
	}

	IEnumerator StartLoadingProgress(int index){
		async = SceneManager.LoadSceneAsync (index);
		async.allowSceneActivation = false;
		while (async.isDone == false) {
			LoadingBar.value = async.progress;
			if (async.progress >= 0.9f){
				LoadingBar.value = 1;
				async.allowSceneActivation = true;
			}
			yield return new WaitForSeconds (1); //demo only
			yield return null;
		}
		
	}
}
