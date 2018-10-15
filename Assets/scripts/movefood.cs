using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movefood : MonoBehaviour {
	public Transform pos1;
	public Transform pos2;
	public Transform pos3;
	public Transform coca;
	public Transform banana;
	public Transform cafe;
	int num;

	// Use this for initialization
	void Start () {
		num=1;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void NEXT(){
		num++;
		if(num>=4){num=1;}
		changefood();
	}
	public void BEFORE(){
		num--;
		if(num<=0){
			num=3;
		}
		changefood();
	}
	public void changefood(){
		switch(num){
			case 1:coca.position=pos1.position;
					banana.position=pos2.position;
					cafe.position=pos3.position;break;
			case 2:coca.position=pos2.position;
					banana.position=pos3.position;
					cafe.position=pos1.position;break;

			case 3:coca.position=pos3.position;
					banana.position=pos1.position;
					cafe.position=pos2.position;break;
		}
	}
}
