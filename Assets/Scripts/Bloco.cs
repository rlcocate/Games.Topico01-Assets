using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D c){
		print ("Houve colisão!");
		print (c.gameObject.transform.position);
		if (c.gameObject.tag == "Piso") Destroy (c.gameObject);
	}

	void OnCollisionStay2D(Collision2D c){
		print ("Colidindo...");
	}

	void OnCollisionExit2D(Collision2D c){
		print ("Parou de colidir!");
	}
}
