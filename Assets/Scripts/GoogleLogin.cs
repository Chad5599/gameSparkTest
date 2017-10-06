using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using GameSparks.Api.Requests;
using GooglePlayGames;
using GooglePlayGames.BasicApi;

public class GoogleLogin : MonoBehaviour
{

	public Text log;
	public Text authCodeText;
	public Text tokenIdText;

	public Button connectGoogle;
	public Button authGoogle;
	public Button getAuthCode;

	private string authCode;
	private string tokenId;
	private string userName;

	private void Awake()
	{
 
		PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder()

			// requests a server auth code be generated so it can be passed to an
			//  associated back end server application and exchanged for an OAuth token.
			.RequestServerAuthCode(false)
			// requests an ID token be generated.  This OAuth token can be used to
			//  identify the player to other services such as Firebase.
			.RequestIdToken()
			.Build();

		PlayGamesPlatform.InitializeInstance(config);
		// recommended for debugging:
		PlayGamesPlatform.DebugLogEnabled = true;
	

		//Initialize Google Play
		PlayGamesPlatform.Activate ();

	}


	public void Start ()
	{
		Button btn = connectGoogle.GetComponent<Button>();
		btn.onClick.AddListener(GooglePlayStart);

		Button btn1 = authGoogle.GetComponent<Button>();
		btn1.onClick.AddListener(GooglePlayAuthentication);

		Button btn2 = getAuthCode.GetComponent<Button>();
		btn2.onClick.AddListener(GetAuthCodeGoogle);

		log.text = "Google Active";

		if (Social.localUser.authenticated) {
			log.text = "social authenticated";
		}

	
	}

	//Called from a UI Button
	public void GooglePlayStart ()
	{
		log.text = "connect press";

		//Start the Google Plus Overlay Login
		Social.localUser.Authenticate ((bool success) => {
			if(success) {
				log.text = "SUCCESS AUTHENTICATED";
				//GooglePlayAuthentication();
			} else{
				log.text = "FAILED AUTHENTICATED";
			}
		});



	}

	public void GetAuthCodeGoogle()
	{
		log.text = "get auth press";

		if(PlayGamesPlatform.Instance.IsAuthenticated()) {

			authCode = PlayGamesPlatform.Instance.GetServerAuthCode();
			authCodeText.text = authCode;


			tokenId = PlayGamesPlatform.Instance.GetIdToken();
			tokenIdText.text = tokenId;

			userName = PlayGamesPlatform.Instance.GetUserDisplayName();

			log.text = "Google Play Login success";


		} else {
			log.text = "Google Play Login Failed";
		}
	}

	//Called from a UI Button
	public void GooglePlayAuthentication() {

		log.text = "auth gamesparks";

		if(PlayGamesPlatform.Instance.IsAuthenticated()) {

			authCodeText.text = authCode;
			tokenIdText.text = userName;

			new GooglePlayConnectRequest ()
				.SetCode (authCode)
				//.SetAccessToken (PlayGamesPlatform.Instance.GetAccessToken ())
				.SetDoNotLinkToCurrentPlayer (false)
				.SetSwitchIfPossible(true)
				.SetRedirectUri ("https://www.gamesparks.com/oauth2callback")
				.SetDisplayName(userName)
				.Send ((response) => {
					if (!response.HasErrors) {
						Debug.Log (response.DisplayName + " Logged In !");
						tokenIdText.text = "Success "+ response.DisplayName + "   :   " + response.UserId + "   :   " + "Logged In! \n " + response.JSONString;
					} else {
						Debug.Log ("Failed To Login");
						tokenIdText.text = "ERRRRORRRR  GameSparks"+ response.JSONString;
					}
				});



		} else {
			log.text = "Google Play Login failed In gamesparks Authentication";
		}
	}


}
