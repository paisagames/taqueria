using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class changescene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void changesceneAR(){
		SceneManager.LoadScene("easyAR1");
	}
	public void backtomenu(){
		SceneManager.LoadScene("menu");
	}
	public void becomeamember(){
		SceneManager.LoadScene("member");
	}
}
