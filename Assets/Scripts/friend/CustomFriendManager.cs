using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using GameSparks.Api.Requests;
using GameSparks.Core;
using GameSparks.Api.Messages;

public class CustomFriendManager : MonoBehaviour {

	public Button backButton;
	public Button findMatchButton;
	public Button friendRequestButton;
	public Button acceptFriendRequestButton;
	public Button declineFriendRequestButton;


	public Text selectedIdText;
	public Text selectedPlayerText;

	public Text friendOnlineMessageText;
	public Text friendRequestMessageText;
	public Text friendAllMessageText;
	public Text errorText;


	private int selectedIdNumber = 0;
	private string requestId = null;

	List<string> playerIdList = new List<string>();
	List<string> playerNameList = new List<string>();

	void Awake()
	{
		Debug.Log ("Awake");
	}

	// Use this for initialization
	void Start () {

		Debug.Log ("Listener Message adding");

		ScriptMessage_friendOnlineMessage.Listener += GetFriendOnlineMessage;

		ScriptMessage_friendRequestMessage.Listener += GetFriendRequestMessage;

		ScriptMessage.Listener += GetMessages;

		Debug.Log ("Listener Message added Success");


		Button btnn = backButton.GetComponent<Button>();
		btnn.onClick.AddListener(BackScene);

		Button btn1 = findMatchButton.GetComponent<Button>();
		btn1.onClick.AddListener(FindMatch);

		Button btn2 = friendRequestButton.GetComponent<Button>();
		btn2.onClick.AddListener(FriendRequest);

		Button btn3 = acceptFriendRequestButton.GetComponent<Button>();
		btn3.onClick.AddListener(AcceptFriendRequest);

		Button btn4 = declineFriendRequestButton.GetComponent<Button>();
		btn4.onClick.AddListener(DeclineFriendRequest);

	}

	public void GetFriendRequestMessage(ScriptMessage_friendRequestMessage message)
	{

		Debug.Log ("Friend Request : "+message.Data.JSON);

		errorText.text = "Friend Request : " + message.Data.JSON;

		if (message.ExtCode == "friendRequestMessage")
		{
			requestId = message.Data.GetString ("playerId");

			Debug.Log ("Request Id : "+requestId);

			friendRequestMessageText.text = message.Data.GetString("playerName")+" have sent you friend request : ";
		}


	}

	public void GetFriendOnlineMessage(ScriptMessage_friendOnlineMessage message)
	{

		Debug.Log ("Online : "+message.Data.JSON);

		errorText.text = "Online : " + message.Data.JSON;

		if (message.ExtCode == "friendOnlineMessage")
		{
			friendOnlineMessageText.text = "Online : " + message.Data.GetString("playerName");
		}
	}


	public void GetMessages(ScriptMessage message)
	{

		string name = message.Data.GetString ("friendName");

		Debug.Log ("All messages : " + message.Data.JSON);

		errorText.text = "All messages : " + message.Data.JSON;

		friendAllMessageText.text = "All messages : " + message.Data.JSON;


		if (message.ExtCode == "friendAcceptedMessage")
		{
			friendAllMessageText.text = name+" accepted friend request ";

		}

		if (message.ExtCode == "friendRequestDeclined")
		{
			friendAllMessageText.text = name+" declined friend request ";
		}
	}


	void FindMatch()
	{
		new LogEventRequest ()
			.SetEventKey ("findPlayers")
			.Send ((response) => {
				
				if (!response.HasErrors) {
					Debug.Log ("success player finding");
					errorText.text = "success player finding";

					List<GSData> data = response.ScriptData.GetGSDataList("playerList");


					foreach(GSData entry in data)
					{
						Debug.Log("Name     : " + entry.GetString("displayName").ToString()); 	
						Debug.Log("Player ID: " + entry.GetString("playerId").ToString()); 
						playerIdList.Add(entry.GetString("playerId").ToString());
						playerNameList.Add(entry.GetString("displayName").ToString());

						selectedIdText.text = entry.GetString("playerId").ToString();
						selectedPlayerText.text = entry.GetString("displayName").ToString();

					}

					int count = playerIdList.Count;
					//Debug.Log("The count is :"+count);

					selectedIdNumber = Random.Range(0,count);

					//Debug.Log("The selected Id is   :"+playerIdList[selectedIdNumber]);
					//Debug.Log("The selected Name is :"+playerNameList[selectedIdNumber]);

					selectedIdText.text = playerIdList[selectedIdNumber];
					selectedPlayerText.text = playerNameList[selectedIdNumber];

				} 
				else 
				{
					Debug.Log ("error player finding");
					errorText.text = "error player finding";
				}
			});
	}



	void FriendRequest()
	{
		new LogEventRequest ()
			.SetEventKey ("friendRequest")
			.SetEventAttribute ("friendId",playerIdList[selectedIdNumber])
			.Send ((response) => {

				if (!response.HasErrors) {
					Debug.Log ("success fiend Request");
					errorText.text = "success friend request";

				} 
				else 
				{
					Debug.Log ("error friend Request"+response.Errors.JSON);
					errorText.text = "error friend Request"+response.Errors.JSON;
				}
			});
	
	}

	void AcceptFriendRequest()
	{
		new LogEventRequest ()
			.SetEventKey ("acceptFriendRequest")
			.SetEventAttribute ("friendId",requestId)
			.Send ((response) => {

				if (!response.HasErrors) {
					Debug.Log ("success accepting friend");
					errorText.text = "success accepting friend";

				} 
				else 
				{
					Debug.Log ("error accepting friend"+response.Errors.JSON);
					errorText.text = "error accepting friend"+response.Errors.JSON;
				}
			});

	}

	void DeclineFriendRequest()
	{
		new LogEventRequest ()
			.SetEventKey ("declineFriendRequest")
			.SetEventAttribute ("friendId",requestId)
			.Send ((response) => {

				if (!response.HasErrors) {
					Debug.Log ("success declining friend");
					errorText.text = "success declining friend";

				} 
				else 
				{
					Debug.Log ("error declining friend "+response.Errors.JSON);
					errorText.text = "error declining friend"+response.Errors.JSON;
				}
			});

	}

	public void BackScene()
	{
		SceneManager.LoadScene ("GamesparksScene");
	}
}
