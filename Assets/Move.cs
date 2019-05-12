using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Move : MonoBehaviour
{

	// Update is called once per frame
	void Update()
	{
		var x = CrossPlatformInputManager.GetAxis("Horizontal");
		var y = CrossPlatformInputManager.GetAxis("Vertical");
		transform.position += (Vector3.right * x + Vector3.up * y) * Time.deltaTime;

		if (CrossPlatformInputManager.GetButton("Jump"))
		{
			this.GetComponent<Renderer>().material.color = Color.red;
		} else
		{
			this.GetComponent<Renderer>().material.color = Color.white;
		}
	}
}