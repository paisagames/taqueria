using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;


public class imagen : MonoBehaviour {
public Image imagencita;
public Sprite spritex;
public Sprite spriteN;
public Text texto;
public GameObject objs;
///"http://puntobit.com.mx/images/slide05.jpg"
 string url = "https://www.google.com/images/branding/googlelogo/2x/googlelogo_color_120x44dp.png";
 string urlquesadilla="https://drive.google.com/drive/u/2/folders/1KpKC6Fwacu3qgRlwWozFJsP1PKAPbZvv/quesadilla.prefab";
	// Use this for initialization
	WWW www;
	WWW www2;
	bool cargado;
	double tiempo;
	void Start () {
		tiempo=0;
		cargado=false;
		llamar();
		//llamadr2();
		//buscar la funcion para esperar a que se termine de cargar el anterior
	}
	private bool llamadr2(){
		string urlx="https://cgtfiles.s3.amazonaws.com/uploads/files/778160/can.obj";
		var uwr = UnityWebRequestAssetBundle.GetAssetBundle(urlx);
        //yield return uwr.SendWebRequest();

        // Get the designated main asset and instantiate it.
        Instantiate(DownloadHandlerAssetBundle.GetContent(uwr).mainAsset);
		return true;
	}
	private bool llamar(){
		www = new WWW(url);
		www2=new WWW(urlquesadilla);
		GameObject xcc=new GameObject("https://drive.google.com/open?id=1nxpOXlg12ggcwjI6Z4AsuSo86dew_XoH");
	
		Vector3 vc=new Vector3(0,0,0);
		GameObject xx= Instantiate(objs,vc,transform.rotation);
		Instantiate(xcc,vc,transform.rotation);
		
		
		
		//yield return www;
		
		 return true;
	}
	// Update is called once per frame
	void Update () {
		tiempo=tiempo+Time.deltaTime;
		if(tiempo>2&&tiempo<3){
			imagencita.sprite = Sprite.Create(www.texture, new Rect(0, 0, www.texture.width, www.texture.height), new Vector2(0, 0));
			//GameObject dd=Instantiate()
		}
		
		texto.text=""+tiempo;
		if(cargado==false){
		//imagencita.sprite = Sprite.Create(www.texture, new Rect(0, 0, www.texture.width, www.texture.height), new Vector2(0, 0));
		cargado=true;
		}
		
		//spriteN=Resources.Load("", typeof(Sprite)) as Sprite;
		//spriteN=Resources.Load("http://puntobit.com.mx/images/slide05.jpg") as Sprite;
		
	}
	
}
