using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

using GameSparks.Api.Requests;

public class RegisterPlayer : MonoBehaviour
{

	public InputField displayNameRegister, userNameRegister, passwordRegister;
	public InputField userNameAuthorise, passwordAuthorise;
	public Text displayNameResponce;
	private bool authoriseFlag = false;

	public void RegisterPlayerButton ()
	{
		new RegistrationRequest ()
			.SetDisplayName (displayNameRegister.text)
			.SetPassword (passwordRegister.text)
			.SetUserName (userNameRegister.text)
			.Send ((response) => {
			if (!response.HasErrors) 
			{
				Debug.Log ("Player Registered");
			} 
			else 
			{
				Debug.Log ("Error Registering Player");
			}
		}
		);
	}

	public void AuthorizedPlayerButton ()
	{
		new AuthenticationRequest ().SetUserName (userNameAuthorise.text).SetPassword (passwordAuthorise.text).Send ((response) => {
			if (!response.HasErrors) 
			{
				Debug.Log ("Player Authenticated...\n");
				displayNameResponce.text = response.DisplayName;

				authoriseFlag = true;
			} 
			else 
			{
				Debug.Log ("Error Authenticating Player..." + response.Errors.JSON.ToString ());
			}
		});
	}

	public void GameSceneButton()
	{
        if (authoriseFlag) {
			//Application.LoadLevel ("multiPlayerScene");
            //Application.LoadLevel ("MainGameScene");
            //Application.LoadLevel ("AppPurchase");
			Application.LoadLevel ("Leaderboard");
		}
		else 
		{
			Debug.Log ("Error Authentication");
		}
	}

}
