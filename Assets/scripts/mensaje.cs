using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mensaje : MonoBehaviour {

	public Image mensajeimg;
	public Button mensajebtn;
	bool quitaomuestra;
	// Use this for initialization
	void Start () {
		quitaomuestra=false;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void muestra(){
		if(quitaomuestra==false){
			mensajeimg.enabled=true;
			mensajebtn.enabled=true;
			quitaomuestra=true;
		}else{mensajeimg.enabled=false;
			mensajebtn.enabled=false;
			quitaomuestra=false;}
	}
	
}
