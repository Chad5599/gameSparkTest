using System.Collections;
using System.Collections.Generic;


using System;
using UnityEngine;
using UnityEngine.UI;

using GameSparks.Api.Requests;
using GameSparks.Api.Responses;
using UnityEngine.SceneManagement;
using GameSparks.Api.Messages;

public class LeagueLeaderboard : MonoBehaviour {


	public Button backButton;
	public Button globalLbButton;
	public Button leagueLbButton;
	public InputField leagueInput;
	public Button addScoreButton;
	public Button subScoreButton;
	public Button endGameButton;
	public Button assignLeague;

	public int scoreCount = 0;
	public Text scoreValueText;
	public Text playerText;

	public GameObject CanvasObj;

	void Awake()
	{

		

		Button btn = globalLbButton.GetComponent<Button>();
		btn.onClick.AddListener(GlobalLeaderboard);

		Button btn1 = leagueLbButton.GetComponent<Button>();
		btn1.onClick.AddListener(LeagueLeaderboardMethod);

		Button btn2 = addScoreButton.GetComponent<Button>();
		btn2.onClick.AddListener(AddScore);

		Button btn3 = subScoreButton.GetComponent<Button>();
		btn3.onClick.AddListener(SubScore);

		Button btn4 = endGameButton.GetComponent<Button>();
		btn4.onClick.AddListener(EndGame);

		Button btn5 = assignLeague.GetComponent<Button>();
		btn5.onClick.AddListener(AssignLeague);

		Button btn6 = backButton.GetComponent<Button>();
		btn6.onClick.AddListener(BackScene);

	}







	public void BackScene()
	{
		SceneManager.LoadScene ("GamesparksScene");
	}

	public void AddScore()
	{
		++scoreCount;
		scoreValueText.text = scoreCount.ToString ();
	}

	public void SubScore()
	{
		if (scoreCount > 0) {
			--scoreCount;
			scoreValueText.text = scoreCount.ToString ();
		}
	}

	public void EndGame()
	{
		string score = scoreValueText.text;
		int scoreInt =    Convert.ToInt32(score);
		new LogEventRequest().SetEventKey("event_EndGame")
			.SetEventAttribute("score",scoreInt)
			.Send((response) => {
				if (!response.HasErrors) {
						Debug.Log("Success End Game event...");
				}  else {
						Debug.Log("Fail End Game event...");
				}
			} );
	}

	public void AssignLeague()
	{

//		new LogEventRequest().SetEventKey("event_Placement")
//			.SetEventAttribute("score",scoreValueText.text)
//			.Send((response) => {
//				if (!response.HasErrors) {
//					Debug.Log("Success Assign league Game event...");
//				}  else {
//					Debug.Log("Fail Assign league Game event...");
//				}
//			} );
	}


	public void LeagueLeaderboardMethod()
	{

		ResetScreen ();

		new LeaderboardDataRequest().SetLeaderboardShortCode("divisionSpecificLeaderboard.division.league."+leagueInput.text).SetEntryCount(20)
			.Send((response) => {
				if (!response.HasErrors) {
					Debug.Log("Found Leaderboard Data...");
					int count = 0;
					foreach(LeaderboardDataResponse._LeaderboardData entry in response.Data) {
						int rank = (int) entry.Rank; 
						string playerName = entry.UserName;
						string score = entry.JSONData["score"].ToString();
						string league = entry.JSONData["league"].ToString();
						string division = entry.JSONData["division"].ToString();

						++count;
						TextOnScreen(("R:" + rank + "N:" + playerName + "S:"+ score+ "L:"+ league+ "D:"+ division),count);
					}
				} else {
					Debug.Log("Error Retrieving Leaderboard Data...");
				}
			});
	}

	public void GlobalLeaderboard()
	{
		ResetScreen ();

		new LeaderboardDataRequest().SetLeaderboardShortCode("GlobalLeagueLeaderboard").SetEntryCount(20)
			.Send((response) => {
				if (!response.HasErrors) {
					Debug.Log("Found Leaderboard Data...");
					int count = 0;
					foreach(LeaderboardDataResponse._LeaderboardData entry in response.Data) {
						int rank = (int) entry.Rank; 
						string playerName = entry.UserName;
						string score = entry.JSONData["score"].ToString();
						Debug.Log("Rank:" + rank + " Name:" + playerName + " LVL:"+ score);
						++count;
						TextOnScreen(("Rank:" + rank + " Name:" + playerName + " LVL:"+ score),count);
					}
				} else {
					Debug.Log("Error Retrieving Leaderboard Data...");
				}
			});

	}

	public void ResetScreen()
	{

		foreach (Transform child in CanvasObj.transform)
		{
			if (child.name == "textObj") 
			{
				Destroy (child.gameObject);
			}
		}
	}

	public void TextOnScreen(string textValue,int count)
	{

		GameObject tempObj = new GameObject("textObj");
		tempObj.transform.SetParent(CanvasObj.transform);

		Text newText = tempObj.AddComponent<Text>();
		newText.rectTransform.sizeDelta = new Vector2(1000,100);
		newText.fontSize = 50;
		newText.color = Color.white;
		newText.font = Resources.Load<Font>("font/arial");
		newText.rectTransform.position = new Vector2(playerText.rectTransform.position.x,playerText.rectTransform.position.y - (120*count));
		newText.text = textValue;
	}
}
