using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using GameSparks.Api.Requests;
using GameSparks.Core;
using GameSparks.Api.Messages;

public class FriendDetailManager : MonoBehaviour
{

	public Button backButton;
	public Button resetButton;
	public Button showButton;
	public Button friendOnlineButton;
	public Button friendOfflineButton;
	public Button requestSentButton;
	public Button requestReceivedButton;

	public GameObject onlineFriendScroll;
	public GameObject offlineFriendScroll;
	public GameObject requestSentScroll;
	public GameObject requestReceivedScroll;

	public Text logText;

	List<string> onlineFriendId = new List<string> ();
	List<string> offlineFriendId = new List<string> ();
	List<string> requestReceivedFriendId = new List<string> ();
	List<string> requestSentFriendId = new List<string> ();

	List<string> onlineFriendName = new List<string> ();
	List<string> offlineFriendName = new List<string> ();
	List<string> requestReceivedFriendName = new List<string> ();
	List<string> requestSentFriendName = new List<string> ();

	List<GameObject> onlineFriendGridPrefab = new List<GameObject> ();
	List<GameObject> offlineFriendGridPrefab = new List<GameObject> ();
	List<GameObject> requestSentFriendGridPrefab = new List<GameObject> ();
	List<GameObject> requestReceivedFriendGridPrefab = new List<GameObject> ();

	void Start ()
	{
		ScriptMessage_friendOnlineMessage.Listener += GetFriendOnlineMessage;

		ScriptMessage_friendOfflineMessage.Listener += GetFriendOfflineMessage;

		ScriptMessage_friendRequestMessage.Listener += GetFriendRequestMessage;

		ScriptMessage.Listener += GetMessages;


		//getting friends of player
		GetFriendDetailMethod ();

		Button btn = backButton.GetComponent<Button> ();
		btn.onClick.AddListener (BackScene);

		Button btn1 = friendOnlineButton.GetComponent<Button> ();
		btn1.onClick.AddListener (OnlineFriendMethod);

		Button btn2 = friendOfflineButton.GetComponent<Button> ();
		btn2.onClick.AddListener (OfflineFriendMethod);

		Button btn3 = requestSentButton.GetComponent<Button> ();
		btn3.onClick.AddListener (RequestSentMethod);

		Button btn4 = requestReceivedButton.GetComponent<Button> ();
		btn4.onClick.AddListener (RequestReceivedMethod);

		Button btn5 = resetButton.GetComponent<Button> ();
		btn5.onClick.AddListener (ResetMethod);

		Button btn6 = showButton.GetComponent<Button> ();
		btn6.onClick.AddListener (showFriendData);

	

	}

	public void GetFriendRequestMessage (ScriptMessage_friendRequestMessage message)
	{

		Debug.Log ("Friend Request : " + message.Data.JSON);

		logText.text = "Friend Request : " + message.Data.JSON;

		if (message.ExtCode == "friendRequestMessage") {
			requestReceivedFriendId.Add (message.Data.GetString ("playerId"));
			requestReceivedFriendName.Add (message.Data.GetString ("playerName"));

			logText.text = message.Data.GetString ("playerName") + " have sent you friend request : ";

			showFriendData ();
		}


	}

	public void GetFriendOnlineMessage (ScriptMessage_friendOnlineMessage message)
	{

		Debug.Log ("Online : " + message.Data.JSON);

		logText.text = "Online : " + message.Data.JSON;

		if (message.ExtCode == "friendOnlineMessage") {
			onlineFriendId.Add (message.Data.GetString ("playerId"));
			onlineFriendName.Add (message.Data.GetString ("playerName"));

			int index = offlineFriendId.IndexOf (message.Data.GetString ("playerId"));

			offlineFriendId.RemoveAt (index);
			offlineFriendName.RemoveAt (index);

			logText.text = "Online : " + message.Data.GetString ("playerName");

			showFriendData ();
		}
	}

	public void GetFriendOfflineMessage (ScriptMessage_friendOfflineMessage message)
	{

		Debug.Log ("Offline : " + message.Data.JSON);

		logText.text = "offline : " + message.Data.JSON;

		if (message.ExtCode == "friendOfflineMessage") {
			offlineFriendId.Add (message.Data.GetString ("playerId"));
			offlineFriendName.Add (message.Data.GetString ("playerName"));

			int index = onlineFriendId.IndexOf (message.Data.GetString ("playerId"));

			onlineFriendId.RemoveAt (index);
			onlineFriendName.RemoveAt (index);

			logText.text = "offline : " + message.Data.GetString ("playerName");

			showFriendData ();
		}
	}


	public void GetMessages (ScriptMessage message)
	{

		string name = message.Data.GetString ("playerName");

		Debug.Log ("All messages : " + message.Data.JSON);

		logText.text = "All messages : " + message.Data.JSON;


		if (message.ExtCode == "friendAcceptedMessage") {
			int index = requestSentFriendId.IndexOf (message.Data.GetString ("playerId"));
			requestSentFriendId.RemoveAt (index);
			requestSentFriendName.RemoveAt (index);


			onlineFriendId.Add (message.Data.GetString ("playerId"));
			onlineFriendName.Add (message.Data.GetString ("playerName"));

			logText.text = name + " accepted friend request ";

			showFriendData ();

		}

		if (message.ExtCode == "friendRequestDeclined") {
			int index = requestSentFriendId.IndexOf (message.Data.GetString ("playerId"));
			requestSentFriendId.RemoveAt (index);
			requestSentFriendName.RemoveAt (index);

			logText.text = name + " declined friend request ";

			showFriendData ();
		}
	}

	public void GetFriendDetailMethod ()
	{
		int responseCount = 0;

		new LogEventRequest ()
			.SetEventKey ("getPlayerOnlineFriends")
			.Send ((response) => {

			if (!response.HasErrors) {
				Debug.Log ("success getting online fiend Request");
				//logText.text = "success getting player online friends";

				List<GSData> data = response.ScriptData.GetGSDataList ("friendsList");

				foreach (GSData entry in data) {
					onlineFriendId.Add (entry.GetString ("friendId"));
					onlineFriendName.Add (entry.GetString ("friendName"));

				}

					++responseCount;
					if(responseCount == 4)
					{showFriendData();}

			} else {
				Debug.Log ("error online friend Request" + response.Errors.JSON);
				logText.text = "error getting player online friends " + response.Errors.JSON;
			}
		});
				
		new LogEventRequest ()
			.SetEventKey ("getPlayerOfflineFriends")
			.Send ((response) => {

			if (!response.HasErrors) {
				Debug.Log ("success getting offline fiend Request");
				//logText.text = "success getting player offline friends";

				List<GSData> data = response.ScriptData.GetGSDataList ("friendsList");

				foreach (GSData entry in data) {
					offlineFriendId.Add (entry.GetString ("friendId"));
					offlineFriendName.Add (entry.GetString ("friendName"));

				}
					++responseCount;
					if(responseCount == 4)
					{showFriendData();}

			} else {
				Debug.Log ("error offline friend Request" + response.Errors.JSON);
				logText.text = "error getting player offline friends " + response.Errors.JSON;
			}
		});
				
		new LogEventRequest ()
			.SetEventKey ("friendRequestSent")
			.Send ((response) => {

			if (!response.HasErrors) {
				Debug.Log ("success get friend request sent");
				//logText.text = "success getting player offline friends";

				List<GSData> data = response.ScriptData.GetGSDataList ("friendsList");


				foreach (GSData entry in data) {

					requestSentFriendId.Add (entry.GetString ("friendId"));
					requestSentFriendName.Add (entry.GetString ("friendName"));

				}

					++responseCount;
					if(responseCount == 4)
					{showFriendData();}

			} else {
				Debug.Log ("error get friend request sent" + response.Errors.JSON);
				logText.text = "error get friend request sent " + response.Errors.JSON;
			}
		});
				
		new LogEventRequest ()
			.SetEventKey ("friendRequestReceived")
			.Send ((response) => {

			if (!response.HasErrors) {
				Debug.Log ("success get friend request received");
				//logText.text = "success getting player offline friends";

				List<GSData> data = response.ScriptData.GetGSDataList ("friendsList");


				foreach (GSData entry in data) {
					requestReceivedFriendId.Add (entry.GetString ("friendId"));
					requestReceivedFriendName.Add (entry.GetString ("friendName"));
				}

					++responseCount;
					if(responseCount == 4)
					{showFriendData();}

			} else {
				Debug.Log ("error get friend request received" + response.Errors.JSON);
				logText.text = "error get friend request received " + response.Errors.JSON;
			}
		});

	}







	public void showFriendData ()
	{
		logText.text = "";

		foreach (GameObject entry in onlineFriendGridPrefab) {
			Destroy (entry);
		}
		onlineFriendGridPrefab.Clear ();

		foreach (GameObject entry in offlineFriendGridPrefab) {
			Destroy (entry);
		}
		offlineFriendGridPrefab.Clear ();

		foreach (GameObject entry in requestSentFriendGridPrefab) {
			Destroy (entry);
		}
		requestSentFriendGridPrefab.Clear ();

		foreach (GameObject entry in requestReceivedFriendGridPrefab) {
			Destroy (entry);
		}
		requestReceivedFriendGridPrefab.Clear ();

		//onlineFriendGridPrefab.RemoveAll (delegate (GameObject o) { return o == null; });
		//offlineFriendGridPrefab.RemoveAll (delegate (GameObject o) { return o == null; });

		GameObject friendContent = null;
		GameObject gridFriend = null;
		int count = 0;

		Transform[] childrenOnline = onlineFriendScroll.GetComponentsInChildren<Transform> ();
		foreach (Transform child in childrenOnline) {
			if (child.CompareTag ("grid1")) {
				gridFriend = child.gameObject;
			}
			if (child.CompareTag ("gridText")) {
			}
			if (child.CompareTag ("parentContent")) {
				friendContent = child.gameObject;
			}
		}    


		Vector3 gridFriendNewPos = gridFriend.transform.localPosition;
	
		foreach (string entry in onlineFriendName) {
			
			gridFriendNewPos = new Vector3 (gridFriendNewPos.x, gridFriendNewPos.y - 105, gridFriendNewPos.z);

			onlineFriendGridPrefab.Add (Instantiate (Resources.Load ("gridFriend")) as GameObject);

			onlineFriendGridPrefab [count].transform.parent = friendContent.transform;
			onlineFriendGridPrefab [count].transform.localPosition = gridFriendNewPos;
			onlineFriendGridPrefab [count].transform.localScale = new Vector3 (1.78F, 1, 1);

			Transform[] childOnline = onlineFriendGridPrefab [count].GetComponentsInChildren<Transform> ();
			foreach (Transform child in childOnline) {
				if (child.CompareTag ("friendTextPrefab")) {
					GameObject gridTextObj = child.gameObject;
					Text gridText = gridTextObj.GetComponent<Text> ();
					gridText.text = entry + " is oline\n";
				}
			}

			logText.text += entry + " is Online\n"; 	
			++count;
		}
		count = 0;










		friendContent = null;
		gridFriend = null;


		Transform[] childrenOffline = offlineFriendScroll.GetComponentsInChildren<Transform> ();
		foreach (Transform child in childrenOffline) {
			if (child.CompareTag ("grid1")) {
				gridFriend = child.gameObject;
			}
			if (child.CompareTag ("gridText")) {
			}
			if (child.CompareTag ("parentContent")) {
				friendContent = child.gameObject;
			}
		}    


		gridFriendNewPos = gridFriend.transform.localPosition;

		foreach (string entry in offlineFriendName) {



			gridFriendNewPos = new Vector3 (gridFriendNewPos.x, gridFriendNewPos.y - 105, gridFriendNewPos.z);
		
			offlineFriendGridPrefab.Add (Instantiate (Resources.Load ("gridFriend")) as GameObject);

			Debug.Log ("The offline is : " + offlineFriendGridPrefab [count]);

			offlineFriendGridPrefab [count].transform.parent = friendContent.transform;
			offlineFriendGridPrefab [count].transform.localPosition = gridFriendNewPos;
			offlineFriendGridPrefab [count].transform.localScale = new Vector3 (1.78F, 1, 1);

			Transform[] childOnline = offlineFriendGridPrefab [count].GetComponentsInChildren<Transform> ();
			foreach (Transform child in childOnline) {
				if (child.CompareTag ("friendTextPrefab")) {
					GameObject gridTextObj = child.gameObject;
					Text gridText = gridTextObj.GetComponent<Text> ();
					gridText.text = entry + " is Offline\n";
				}
			}

			logText.text += entry + " is Offline\n"; 
			++count;
		}
		count = 0;










		friendContent = null;
		gridFriend = null;

		Transform[] childrenRequestSent = requestSentScroll.GetComponentsInChildren<Transform> ();
		foreach (Transform child in childrenRequestSent) {
			if (child.CompareTag ("grid1")) {
				gridFriend = child.gameObject;
			}
			if (child.CompareTag ("gridText")) {
			}
			if (child.CompareTag ("parentContent")) {
				friendContent = child.gameObject;
			}
		}    


		gridFriendNewPos = gridFriend.transform.localPosition;


		foreach (string entry in requestSentFriendName) {
			gridFriendNewPos = new Vector3 (gridFriendNewPos.x, gridFriendNewPos.y - 105, gridFriendNewPos.z);

			requestSentFriendGridPrefab.Add (Instantiate (Resources.Load ("gridFriend")) as GameObject);

			requestSentFriendGridPrefab [count].transform.parent = friendContent.transform;
			requestSentFriendGridPrefab [count].transform.localPosition = gridFriendNewPos;
			requestSentFriendGridPrefab [count].transform.localScale = new Vector3 (1.78F, 1, 1);

			Transform[] childRequestSent = requestSentFriendGridPrefab [count].GetComponentsInChildren<Transform> ();
			foreach (Transform child in childRequestSent) {
				if (child.CompareTag ("friendTextPrefab")) {
					GameObject gridTextObj = child.gameObject;
					Text gridText = gridTextObj.GetComponent<Text> ();
					gridText.text = "request sent to " + entry + "\n";
				}
			}

			logText.text += "request sent to " + entry + "\n"; 	
			++count;
		}
		count = 0;


		 





		friendContent = null;
		gridFriend = null;


		Transform[] childrenRequestReceived = requestReceivedScroll.GetComponentsInChildren<Transform> ();
		foreach (Transform child in childrenRequestReceived) {
			if (child.CompareTag ("grid1")) {
				gridFriend = child.gameObject;
			}
			if (child.CompareTag ("gridText")) {
			}
			if (child.CompareTag ("parentContent")) {
				friendContent = child.gameObject;
			}
		}    


		gridFriendNewPos = gridFriend.transform.localPosition;

		foreach (string entry in requestReceivedFriendName) {
			gridFriendNewPos = new Vector3 (gridFriendNewPos.x, gridFriendNewPos.y - 105, gridFriendNewPos.z);

			requestReceivedFriendGridPrefab.Add (Instantiate (Resources.Load ("gridRequestReceived")) as GameObject);

			requestReceivedFriendGridPrefab [count].transform.parent = friendContent.transform;
			requestReceivedFriendGridPrefab [count].transform.localPosition = gridFriendNewPos;
			requestReceivedFriendGridPrefab [count].transform.localScale = new Vector3 (1.78F, 1, 1);

			Transform[] childRequestReceived = requestReceivedFriendGridPrefab [count].GetComponentsInChildren<Transform> ();
			foreach (Transform child in childRequestReceived) {
				if (child.CompareTag ("friendTextPrefab")) {
					GameObject gridTextObj = child.gameObject;
					Text gridText = gridTextObj.GetComponent<Text> ();
					gridText.text = entry + " sent you friend request \n";
				}
				if (child.CompareTag ("friendAcceptButton")) {
					GameObject acceptButtonObj = child.gameObject;
					Button acceptButtonTemp = acceptButtonObj.GetComponent<Button> ();

					string tempId = requestReceivedFriendId[count];

					acceptButtonTemp.onClick.AddListener(() => { OnAcceptButtonClicked(tempId); });
					//OnAcceptButtonClicked(requestReceivedFriendId[count]);
					Debug.Log ("The Id accept : "+requestReceivedFriendId[count]+"  the count : "+count);
				}
				if (child.CompareTag ("friendDeclineButton")) {
					GameObject declineButtonObj = child.gameObject;
					Button acceptButtonTemp = declineButtonObj.GetComponent<Button> ();

					string tempId = requestReceivedFriendId[count];

					acceptButtonTemp.onClick.AddListener(() => { OnAcceptButtonClicked(tempId); });

					Debug.Log ("The Id decline : "+requestReceivedFriendId[count]+"  the count : "+count);
				}
			}

			logText.text += entry + " sent you friend request \n"; 	
			++count;
		}
		count = 0;

	}

	public void OnAcceptButtonClicked(string playerId)
	{
	
		Debug.Log("The player button pressed Id : "+playerId);

		new LogEventRequest ()
			.SetEventKey ("acceptFriendRequest")
			.SetEventAttribute("friendId",playerId)
			.Send ((response) => {

				if (!response.HasErrors) {
					Debug.Log ("success accepting friend");
					//logText.text = "success getting player offline friends";

					GSData friendAddedData = response.ScriptData.GetGSData("friendAdded");

					string friendIdTemp = friendAddedData.GetString("friendId");
					string friendNameTemp = friendAddedData.GetString("friendName");

					int tempIndex = requestReceivedFriendId.IndexOf(friendIdTemp);

					Debug.Log("The friend Id accepted by me is : "+friendIdTemp);
					Debug.Log("The friend Name accepted by me is : "+friendNameTemp);



					requestReceivedFriendId.RemoveAt(tempIndex);
					requestReceivedFriendName.RemoveAt(tempIndex);

					onlineFriendId.Add(friendIdTemp);
					onlineFriendName.Add(friendNameTemp);

					showFriendData();

				} else {
					Debug.Log ("error accepting friend request" + response.Errors.JSON);
					logText.text = "error accepting friend request" + response.Errors.JSON;
				}
			});
	}

	public void OnDeclineButtonClicked(string playerId)
	{
		Debug.Log("The player button pressed Id : "+playerId);

		new LogEventRequest ()
			.SetEventKey ("declineFriendRequest")
			.SetEventAttribute("friendId",playerId)
			.Send ((response) => {

				if (!response.HasErrors) {
					Debug.Log ("success declining friend");
					//logText.text = "success getting player offline friends";

					GSData friendAddedData = response.ScriptData.GetGSData("friendAdded");

					string friendIdTemp = friendAddedData.GetString("friendId");
					string friendNameTemp = friendAddedData.GetString("friendName");

					int tempIndex = requestReceivedFriendId.IndexOf(friendIdTemp);

					Debug.Log("The friend Id declined by me is : "+friendIdTemp);
					Debug.Log("The friend Name declined by me is : "+friendNameTemp);



					requestReceivedFriendId.RemoveAt(tempIndex);
					requestReceivedFriendName.RemoveAt(tempIndex);

				

					showFriendData();

				} else {
					Debug.Log ("error declining friend request" + response.Errors.JSON);
					logText.text = "error declining friend request" + response.Errors.JSON;
				}
			});
	
	}



	public void ResetMethod ()
	{
		logText.text = "";
		offlineFriendScroll.gameObject.SetActive (false);
		requestSentScroll.gameObject.SetActive (false);
		requestReceivedScroll.gameObject.SetActive (false);
		onlineFriendScroll.gameObject.SetActive (false);
	}

	public void OnlineFriendMethod ()
	{
		offlineFriendScroll.gameObject.SetActive (false);
		requestSentScroll.gameObject.SetActive (false);
		requestReceivedScroll.gameObject.SetActive (false);
		onlineFriendScroll.gameObject.SetActive (true);
	}

	public void OfflineFriendMethod ()
	{
		requestSentScroll.gameObject.SetActive (false);
		requestReceivedScroll.gameObject.SetActive (false);
		onlineFriendScroll.gameObject.SetActive (false);
		offlineFriendScroll.gameObject.SetActive (true);
	}

	public void RequestSentMethod ()
	{
		offlineFriendScroll.gameObject.SetActive (false);
		requestReceivedScroll.gameObject.SetActive (false);
		onlineFriendScroll.gameObject.SetActive (false);
		requestSentScroll.gameObject.SetActive (true);
	}

	public void RequestReceivedMethod ()
	{
		offlineFriendScroll.gameObject.SetActive (false);
		requestSentScroll.gameObject.SetActive (false);
		onlineFriendScroll.gameObject.SetActive (false);
		requestReceivedScroll.gameObject.SetActive (true);
	}

	public void BackScene ()
	{
		SceneManager.LoadScene ("GamesparksScene");
	}
}
