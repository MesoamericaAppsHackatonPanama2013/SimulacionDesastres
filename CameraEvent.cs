using UnityEngine;
using System.Collections;

public class CameraEvent : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		StartCoroutine("Esperar");
	}
	
	// Update is called once per frame
	void Update () {
			
	}
	
	IEnumerator Esperar(){
		
		yield return new WaitForSeconds(5);
		GameObject.Find("Main Camera").GetComponent<SmoothFollow>().enabled = true;
		GameObject.Find("Player").GetComponent<BotControlScript>().enabled = true;
		
	}
}
