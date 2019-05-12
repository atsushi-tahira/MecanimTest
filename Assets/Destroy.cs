using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void Update() {
		
	}

	void OnCollisionEnter(){
		Destroy (this.gameObject, 10f);
	}
}
