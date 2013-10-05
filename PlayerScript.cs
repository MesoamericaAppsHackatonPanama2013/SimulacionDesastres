using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	
	public GameObject Gente;
	public GameObject Gente2;
	public GameObject Gente3;
	public GameObject Gente4;
	public GameObject Base;
	public GUIText Puntosgui;
	public int Puntos;
	public bool FinDelJuego = false;

	// Use this for initialization
	void Start () {
		
		Puntosgui.text = "Gente Salvada: "+Puntos;
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Puntosgui.text = "Gente Salvada: "+Puntos;
		
		if(Puntos >= 5){
			
			FinDelJuego = true;
			Finjuego();
			
		}
		
	}
	void OnCollisionEnter(Collision Col){
		
		if(Col.collider.gameObject == Gente){			
			Puntos+=1;
			Debug.Log("punto");
			}
		if(Col.collider.gameObject == Gente2){			
			Puntos+=1;
			Debug.Log("punto");
			}
		if(Col.collider.gameObject == Gente3){			
			Puntos+=1;
			Debug.Log("punto");
			}
		if(Col.collider.gameObject == Gente4){			
			Puntos+=1;
			Debug.Log("punto");
			}
	}
	
	public void Finjuego(){
		
		Application.LoadLevel(2);
		FinDelJuego = false;
		
	}
}
