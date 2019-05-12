using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugRay : MonoBehaviour {

	public GameObject target;
	Vector3 origin;
	Vector3 direction;
	// Use this for initialization
	void Start () {
		origin = this.gameObject.transform.position;
		direction = this.gameObject.transform.forward;
		//		Ray ray = new Ray(origin, direction);
	}

	// Update is called once per frame
	void Update () {
		Debug.DrawRay (origin, direction * 10, Color.red);
	}
}