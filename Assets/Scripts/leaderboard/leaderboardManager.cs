using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

using GameSparks.Api.Requests;
using GameSparks.Api.Responses;
using GameSparks.Core;
using UnityEngine.SceneManagement;

public class leaderboardManager : MonoBehaviour {

	public Button backButton;
	public Button addLvlButton;
	public Button addLvlCountryButton;
	public InputField inputCountry;
	public Text playerText;
	public GameObject CanvasObj;

	public Button listTeamButton;
	public Button creatTeamButton;
	public InputField creatTeamIdInput;
	public InputField creatTeamNameInput;
	public Button joinTeamButton;
	public InputField joinTeamInput;
	public Button leaveTeamButton;
	public InputField leaveTeamInput;
	public Button GetTeamButton;

	public string teamTypeString = "Clan1";
	public int entryCountTeamList = 10;

	private int lvl;

	void Awake()
	{
		Button btnn = backButton.GetComponent<Button>();
		btnn.onClick.AddListener(BackScene);
		
		Button btn = addLvlButton.GetComponent<Button>();
		btn.onClick.AddListener(RequestLeaderBoard);

		Button btn1 = addLvlCountryButton.GetComponent<Button>();
		btn1.onClick.AddListener(RequestLeaderBoardCountry);

		Button btn2 = listTeamButton.GetComponent<Button>();
		btn2.onClick.AddListener(ListTeamRequestMethod);

		Button btn3 = creatTeamButton.GetComponent<Button>();
		btn3.onClick.AddListener(CreateTeamRequestMethod);

		Button btn4 = joinTeamButton.GetComponent<Button>();
		btn4.onClick.AddListener(JoinTeamRequestMethod);

		Button btn5 = leaveTeamButton.GetComponent<Button>();
		btn5.onClick.AddListener(LeaveTeamRequestMethod);

		Button btn6 = GetTeamButton.GetComponent<Button>();
		btn6.onClick.AddListener(GetTeamLBRequestMethod);
	}

	public void BackScene()
	{
		SceneManager.LoadScene ("GamesparksScene");
	}

	public void ListTeamRequestMethod()
	{
		ResetScreen ();

		new ListTeamsRequest()
			.SetEntryCount(entryCountTeamList)
			.SetTeamTypeFilter(teamTypeString)
			.Send((response) => {
				GSData scriptData = response.ScriptData; 
				var teams = response.Teams; 

				int count = 0;

				foreach(var teamInfo in teams)
				{
					++count;
					TextOnScreen(("Team: "+teamInfo.TeamName+" Owner: "+teamInfo.Owner.DisplayName),count);
				}
			});
	}

	public void CreateTeamRequestMethod()
	{
		ResetScreen ();

		new CreateTeamRequest()
			.SetTeamId(creatTeamIdInput.text)
			.SetTeamName(creatTeamNameInput.text)
			.SetTeamType(teamTypeString)
			.Send((response) => {
				if (!response.HasErrors) {
				var owner = response.Owner; 
				string teamId = response.TeamId; 
				string teamName = response.TeamName; 

					int count = 0;
					++count;
					TextOnScreen(("Success Create Team Id: "+teamId+" team name: "+teamName),count);
				}
				else 
				{
				Debug.Log("Fail team creation");
				}
			});
	}

	public void JoinTeamRequestMethod()
	{
		ResetScreen ();

		new JoinTeamRequest()
			.SetTeamId(joinTeamInput.text)
			.Send((response) => {
				if (!response.HasErrors) {
					var owner = response.Owner; 
					string teamId = response.TeamId; 
					string teamName = response.TeamName; 

					int count = 0;
					++count;
					TextOnScreen(("Success Join Team Id: "+teamId+" team name: "+teamName),count);
				}
				else 
				{
					Debug.Log("Fail team joining");
				}
			});
	}

	public void LeaveTeamRequestMethod()
	{
		ResetScreen ();

		new LeaveTeamRequest()
			.SetTeamId(leaveTeamInput.text)
			.Send((response) => {
				if (!response.HasErrors) {
					var owner = response.Owner; 
					string teamId = response.TeamId; 
					string teamName = response.TeamName; 

					int count = 0;
					++count;
					TextOnScreen(("Success Leave Team Id: "+teamId+" team name: "+teamName),count);
				}
				else 
				{
					Debug.Log("Fail team leaving");
				}
			});
		
	}

	public void GetTeamLBRequestMethod()
	{

		ResetScreen ();

		new LeaderboardDataRequest().SetLeaderboardShortCode("LB_TEAM").SetEntryCount(20)
			.Send((response) => {
				if (!response.HasErrors) {
					Debug.Log("Found Leaderboard Data...");
					int count = 0;
					foreach(LeaderboardDataResponse._LeaderboardData entry in response.Data) {
						int rank = (int) entry.Rank;
						string sumLvl = entry.JSONData["SUM-ATT_LVL_TEAM"].ToString();
						string teamName = entry.JSONData["teamName"].ToString();
						++count;
						TextOnScreen(("Rank: " + rank + " Team: " + teamName + " SUM LVL: "+sumLvl),count);
					}
				} else {
					Debug.Log("Error Retrieving Leaderboard Data...");
				}
			});
	}




	public void RequestLeaderBoard()
	{
		ResetScreen ();

		new LeaderboardDataRequest().SetLeaderboardShortCode("LB_XP_GL").SetEntryCount(20)
			.Send((response) => {
			if (!response.HasErrors) {
				Debug.Log("Found Leaderboard Data...");
					int count = 0;
				foreach(LeaderboardDataResponse._LeaderboardData entry in response.Data) {
						int rank = (int) entry.Rank; 
					string playerName = entry.UserName;
					string score = entry.JSONData["AT_XP_LB_GL"].ToString();

						++count;
						TextOnScreen(("Rank:" + rank + " Name:" + playerName + " LVL:"+ score),count);
					}
			} else {
				Debug.Log("Error Retrieving Leaderboard Data...");
			}
		});

	}

	public void RequestLeaderBoardCountry()
	{
		ResetScreen ();

		new LeaderboardDataRequest().SetLeaderboardShortCode("LB_CO.AT_LB_CO."+inputCountry.text).SetEntryCount(20)
			.Send((response) => {
				if (!response.HasErrors) {
					Debug.Log("Found Leaderboard Data...");
					int count = 0;
					foreach(LeaderboardDataResponse._LeaderboardData entry in response.Data) {
						int rank = (int) entry.Rank;
						string playerName = entry.UserName;
						string score = entry.JSONData["AT_LB_LVL"].ToString();

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
