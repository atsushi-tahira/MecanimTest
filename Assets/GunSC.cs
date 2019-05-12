using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSC : MonoBehaviour {

	[SerializeField]
	private GameObject bullet;
	[SerializeField]
	private Transform muzzle;
	[SerializeField]
	public float bulletPower = 500f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Shot ();
		}
	}

	void Shot() {
		var bulletInstance = GameObject.Instantiate(bullet, muzzle.position, muzzle.rotation) as GameObject;
		bulletInstance.GetComponent<Rigidbody> ().AddForce (bulletInstance.transform.forward * bulletPower);
		Destroy(bulletInstance, 5f);
	}
}
