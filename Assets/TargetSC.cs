using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSC : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other){
		if(other.gameObject.tag == "Bullet"){
			GetComponent<Renderer>().material.color = Color.blue;
			Destroy (this.gameObject);
		}
	}

}

