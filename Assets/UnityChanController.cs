using UnityEngine;
using System.Collections;

public class UnityChanController : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		// マウスがクリックされた場合
		if (Input.GetMouseButtonDown (0)) {
			// Animatorコンポーネントを取得し、"jumpTrigger"をtrueにする
			GetComponent<Animator> ().SetTrigger ("jumpTrigger");
		}
	}
}
