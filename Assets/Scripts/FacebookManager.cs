using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Facebook.Unity;
using UnityEngine.UI;

public class FacebookManager : MonoBehaviour
{

	public Text loginText;

	void Awake ()
	{
		FB.Init (SetInit, OnHideUnity);
//		Debug.Log ("Awake");
	}

	private void SetInit ()
	{
		Debug.Log ("FB Init done.");

		if (FB.IsLoggedIn) {
			Debug.Log ("FB logged In");
			GameObject canvas = GameObject.FindGameObjectWithTag ("canvas");

			//Debug.Log("the canvas is : "+canvas.name);

			foreach (Transform child in canvas.transform) {
				if (child.tag == "loginText") {
					loginText = child.gameObject.GetComponent<Text> ();
					loginText.text = "success";
				}
			}

		} else {
			GameObject canvas = GameObject.FindGameObjectWithTag ("canvas");

			foreach (Transform child in canvas.transform) {
				if (child.tag == "loginText") {
					loginText = child.gameObject.GetComponent<Text> ();
					loginText.text = "start login";
				}
			}
			FBLogin ();
		}
	}

	private void OnHideUnity (bool isGameShown)
	{

		if (!isGameShown) {
			Time.timeScale = 0;
		} else {
			Time.timeScale = 1;	
		}
	}


	public void FBLogin ()
	{
		FB.LogInWithReadPermissions (new List<string> () { "public_profile", "email", "user_friends" }, AuthCallback);
	}

	public void AuthCallback (IResult result)
	{
		if (FB.IsLoggedIn) {
			GameObject canvas = GameObject.FindGameObjectWithTag ("canvas");

			foreach (Transform child in canvas.transform) {
				if (child.tag == "loginText") {
					loginText = child.gameObject.GetComponent<Text> ();
					loginText.text = "success";
				}
			}
		} else {
			FBLogin ();
			GameObject canvas = GameObject.FindGameObjectWithTag ("canvas");

			foreach (Transform child in canvas.transform) {
				if (child.tag == "loginText") {
					loginText = child.gameObject.GetComponent<Text> ();
					loginText.text = "fail";
				}
			}
		}
	}
}
