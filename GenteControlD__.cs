using UnityEngine;
using System.Collections;

public class GenteControlD__ : MonoBehaviour {

	void OnCollisionEnter(Collision col){
		if(col.collider.tag == "Player"){
		Debug.Log("toca");
		Destroy(gameObject);}
	}
}
