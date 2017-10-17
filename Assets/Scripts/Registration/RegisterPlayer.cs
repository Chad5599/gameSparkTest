using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

using GameSparks.Api.Requests;
using GameSparks.Core;
using Facebook.Unity;
using GameSparks.Api.Responses;
using System;
using UnityEngine.SceneManagement;

public class RegisterPlayer : MonoBehaviour
{

	public InputField displayNameRegister, userNameRegister, passwordRegister;
	public InputField userNameAuthorise, passwordAuthorise;
	public Text displayNameResponce;
	private bool authoriseFlag = false;

	public Text fbUserName;
    public RawImage profilePic;

	void Awake ()
	{
		if (FB.IsInitialized) {
			FB.ActivateApp();
		} else {
			//Handle FB.Init
			FB.Init( () => {
				FB.ActivateApp();
			});
		}
	}


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

	public void RegisterPlayerWithLeague ()
	{
		GSRequestData segdata = new GSRequestData();
		segdata.AddString("league","placement");
		//Dictionary<string, int> dict = new Dictionary<string, int>();
		new RegistrationRequest ()
			.SetDisplayName (displayNameRegister.text)
			.SetPassword (passwordRegister.text)
			.SetUserName (userNameRegister.text)
			.SetSegments(segdata)
			//.SetSegments(new GameSparks.Core.GSRequestData(new Dictionary<string,object>() {{"league","placement"}}))
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
		if (authoriseFlag || true) {
			SceneManager.LoadScene("multiPlayerScene");
			//SceneManager.LoadScene ("MainGameScene");
			//SceneManager.LoadScene ("AppPurchase");
			//SceneManager.LoadScene("Leaderboard");
			//SceneManager.LoadScene ("LeagueAndDivision");
			//SceneManager.LoadScene ("FacebookFriend");
			//SceneManager.LoadScene ("CustomFriends");
			//SceneManager.LoadScene ("FriendsDetail");
		}
		else 
		{
			Debug.Log ("Error Authentication");
		}
	}







	public void FacebookConnect_bttn()
	{
		Debug.Log("Connecting Facebook With GameSparks...");// first check if FB is ready, and then login //
		// if it's not ready we just init FB and use the login method as the callback for the init method //
		if(!FB.IsInitialized){
			Debug.Log("Initializing Facebook...");
			FB.Init(ConnectGameSparksToGameSparks, null);
		}
		else{
			FB.ActivateApp();
			ConnectGameSparksToGameSparks();
		}
	}

	///<summary>
	///This method is used as the delegate for FB initialization. It logs in FB
	/// </summary>//


	private void ConnectGameSparksToGameSparks()
	{
		if(FB.IsInitialized)
		{
			FB.ActivateApp();
			Debug.Log("Logging Into Facebook...");
			var perms = new List<string>(){"public_profile", "email", "user_friends"};
			FB.LogInWithReadPermissions(perms,(result) => {

                if(FB.IsLoggedIn)
                {
					Debug.Log("Logged In, Connecting GS via FB..");                        
				
					new FacebookConnectRequest()
						.SetAccessToken(AccessToken.CurrentAccessToken.TokenString)
						.SetDoNotLinkToCurrentPlayer(false)// we don't want to create a new account so link to the player that is currently logged in
						.SetSwitchIfPossible(true)//this will switch to the player with this FB account id they already have an account from a separate login
						.Send((fbauth_response) => {
							
                            if(!fbauth_response.HasErrors)
                            {
                                Debug.Log("GameSparks Authenticated With Facebook...");
                                //fbUserName.text = fbauth_response.DisplayName;
                                //Debug.Log("The name of fb user is : "+fbauth_response.DisplayName);
                                string nameUser = fbauth_response.DisplayName;
								//Debug.Log("The name of fb user iss : "+(fbUserName==null));
                                
								GameObject canvas = GameObject.FindGameObjectWithTag("canvas");

								//Debug.Log("the canvas is : "+canvas.name);

								foreach (Transform child in canvas.transform)
								{
									if (child.tag == "profileName") 
									{
								//		Debug.Log("the child name  : "+child.name);
										fbUserName = child.gameObject.GetComponent<Text>();
										fbUserName.text = nameUser;
									}
								}


							}
							else{
								Debug.LogWarning(fbauth_response.Errors.JSON);//if we have errors, print them out
							}
						});
				}
				else{
					Debug.LogWarning("Facebook Login Failed:"+result.Error);
				}
			});// lastly call another method to login, and when logged in we have a callback
		}
		else{
			FacebookConnect_bttn();// if we are still not connected, then try to process again
		}
	}


    public void FacebookFriends()
    {
            new ListGameFriendsRequest()
            .Send((response) => {
                
                var friends = response.Friends;


                GSData scriptData = response.ScriptData;

                foreach(ListGameFriendsResponse._Player friend in friends)
                {
                    Debug.Log("Fb Friends  : "+friend.DisplayName);

                }
            
                Debug.Log("Friends ends");
                //Debug.Log("Fb freind result : "+scriptData);
            });


		   
    }





	public void canShow()
	{
	
	}

    public void getFacebookPic()
    {

        new AccountDetailsRequest().Send((response) =>
            {
                string fbID;
                fbID = response.ExternalIds.GetString("FB");
                Debug.Log("the fb id is : "+fbID);

                FB.API(fbID + "/picture?width=256&height=256&redirect=false", HttpMethod.GET, OnGetProfilePicture);

                //var www = new WWW("http://graph.facebook.com/" + fbID + "/picture?width=100&height=100");

               // int counter = 0;
               // while (!www.isDone)
                //{
                  //  Debug.Log(www.isDone);
                   // Debug.Log("Waiting Download to finish..."+ "LINK : http://graph.facebook.com/"+fbID+"/picture?width=100&height=100");
                   // ++counter;

                    //if(counter == 100000)
                      //  break;
              //  }

                //Debug.Log("Download Finished");
                //Image userAvatar = GameObject.FindGameObjectWithTag("profilePic").GetComponent<image>();
               // profilePic.sprite = Sprite.Create(www.texture, new Rect(0, 0, 100, 100), new Vector2(0, 0));

            });
    }

    private void OnGetProfilePicture(IGraphResult result)
    {
        if (string.IsNullOrEmpty(result.Error)) // Success
        {
            IDictionary data = result.ResultDictionary["data"] as IDictionary;
            string url = data["url"] as string;
            StartCoroutine(GetProfilePictureCR(url));
        }
        else // Failure
        {
            Debug.Log("error 1");
        }
    }

    private IEnumerator GetProfilePictureCR(string url)
    {
        WWW www = new WWW(url);
        yield return www;

        if (string.IsNullOrEmpty(www.error)) // Success
        {
            Texture2D texture = www.texture;

			GameObject canvas = GameObject.FindGameObjectWithTag("canvas");

			//Debug.Log("the canvas is : "+canvas.name);

			foreach (Transform child in canvas.transform)
			{
				if (child.tag == "profilePic") 
				{
							Debug.Log("the child name  : "+child.name);
					profilePic = child.gameObject.GetComponent<RawImage>();
					profilePic.texture = texture;
					authoriseFlag = true;
				}
			}

            
        }
        else // Failure
        {
            Debug.Log("error 2");
        }
    }



}
