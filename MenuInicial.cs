using UnityEngine;
using System.Collections;

public class MenuInicial : MonoBehaviour {
	
	public GUISkin MyguiStyle;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {	
				
	}
	
	void OnGUI(){
		
		GUI.skin = MyguiStyle;
		
		GUI.Box(new Rect(Screen.width/2-155, 10, 320, 60), "Video-Juego Prevencion");	
		GUI.Box(new Rect(Screen.width/2-155,Screen.height/2-160, 320, 190), "");
		if(GUI.Button(new Rect(Screen.width/2-120, Screen.height/2-120, 250, 60), "Empezar"))
		{
			Application.LoadLevel(1);
		}
		if(GUI.Button(new Rect(Screen.width/2-120, Screen.height/2-50, 250, 60), "Salir"))
		{			
			Application.Quit();			
		}
		
		GUI.Box(new Rect(10, Screen.height/2+150, 1000, 200), "");
		GUI.Label(new Rect(Screen.height/2-110, Screen.height/2+200, 500, 40), "instrucciones");
		GUI.skin = null;
		GUI.Box(new Rect(70, Screen.height/2+240, 880, 60), "El juego por motivos de Tiempo, solo hay una mision, la cual es evacuar un pueblo Indigena al PUNTO DE SALVADOS. En tiempo limite.");
		
	}
}
