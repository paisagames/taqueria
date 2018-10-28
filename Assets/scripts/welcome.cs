using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class welcome : MonoBehaviour {
	public MeshRenderer logorender;
	public AudioSource welcomeaudio;
	public int escena;
	public Animator animatorr;

	// Use this for initialization
	void Start () {
		if(escena==1){
			animatorr.SetInteger("inicio",1);
		}
		if(escena==2){
			animatorr.SetInteger("inicio",2);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void welcomeaudiorep(){
		
		welcomeaudio.Play();
	}
	public void youarenow(){
		welcomeaudio.Play();
	}
	public void quitalogo(){
		logorender.enabled=false;
	}
}
