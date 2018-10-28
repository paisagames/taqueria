using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sendmail : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void SendEmail ()
 {
  string email = "juanhregules@paisagames.com";
  string subject = MyEscapeURL("become a Member in ARestaurant");
  string body = MyEscapeURL("My Body\r\nFull of non-escaped chars");
  Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
 }
 string MyEscapeURL (string url)
 {
  return WWW.EscapeURL(url).Replace("+","%20");
 }
}
