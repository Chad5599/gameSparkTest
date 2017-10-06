using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Facebook.Unity;

public class FriendManager : MonoBehaviour {

	public Button friendButton;
	public Button backButton;

	public Text friendText;

	public Text loginText;
	// Use this for initialization
	void Start () {

		if (FB.IsLoggedIn) {
			GameObject canvas = GameObject.FindGameObjectWithTag("friendCanvas");

			//Debug.Log("the canvas is : "+canvas.name);

			foreach (Transform child in canvas.transform)
			{
				if (child.tag == "loginText") 
				{
					//		Debug.Log("the child name  : "+child.name);
					loginText= child.gameObject.GetComponent<Text>();
					loginText.text = "success";
				}
			}

		} else {
			GameObject canvas = GameObject.FindGameObjectWithTag("friendCanvas");

			//Debug.Log("the canvas is : "+canvas.name);

			foreach (Transform child in canvas.transform)
			{
				if (child.tag == "loginText") 
				{
					//		Debug.Log("the child name  : "+child.name);
					loginText= child.gameObject.GetComponent<Text>();
					loginText.text = "fail";
				}
			}
		}

		Button btn = friendButton.GetComponent<Button>();
		btn.onClick.AddListener(GetFriends);

		Button btn1 = backButton.GetComponent<Button>();
		btn1.onClick.AddListener(BackScene);

	}

	public void GetFriends()
	{
		//get list of friends  
		FB.AppRequest(
			"Come play this great game!",
			null, null, null, null, null, null,
			delegate (IAppRequestResult result) {
				Debug.Log(result.RawResult);

				GameObject canvas = GameObject.FindGameObjectWithTag("friendCanvas");

				//Debug.Log("the canvas is : "+canvas.name);

				foreach (Transform child in canvas.transform)
				{
					if (child.tag == "friendText") 
					{
						//		Debug.Log("the child name  : "+child.name);
						friendText = child.gameObject.GetComponent<Text>();
						friendText.text = result.RawResult;
					}
				}



			}
		);
	
	}

	public void BackScene()
	{
		SceneManager.LoadScene ("GamesparksScene");
	}
}
