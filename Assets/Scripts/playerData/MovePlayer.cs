using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {


	public float playerSpeed = 0;

	void Update () {
		if (Input.GetKey (KeyCode.W)) 
		{
			transform.Translate (0,0, Time.deltaTime * playerSpeed);
		}
		else if(Input.GetKey (KeyCode.S)) 
		{
			transform.Translate (0,0, -Time.deltaTime * playerSpeed);
		}
		else if(Input.GetKey (KeyCode.A)) 
		{
			transform.Translate (-Time.deltaTime * playerSpeed,0,0);
		}
		else if (Input.GetKey (KeyCode.D)) 
		{
			transform.Translate (Time.deltaTime * playerSpeed,0,0);
		}
	}
}
