using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextManagerSC : MonoBehaviour {

	float lastTime = 90;
	private Text countTime;
	private Text countTarget;
	private Text endText;
	private int lastTargets;

	void Start (){
		countTime = GameObject.Find ("Timer").GetComponent<Text> ();
		countTarget = GameObject.Find ("CountTarget").GetComponent<Text> ();
		endText = GameObject.Find ("GameEndText").GetComponent<Text> ();
	}

	void Update(){

		bool gameEnd = lastTargets == 0 ? true : (lastTime < 0 ? true : false);
		lastTargets = GameObject.FindGameObjectsWithTag("Target").Length;
		countTarget.text = "残りターゲット数: " + lastTargets.ToString();

		if (gameEnd != true){
			lastTime -= Time.deltaTime;	
		} else if (gameEnd == true && lastTargets == 0){
			endText.text = "Congratulation!!!";
		} else if (gameEnd == true && lastTime < 0) {
			endText.text = "GameOver";
			lastTime = 0.00f;
		}
		countTime.text = lastTime.ToString ("f1");
	}
}
