using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class SavePlayer : MonoBehaviour {

	public Text gold, xp,playerID,playerPos,score;
	private int goldCount = 0,scoreCount = 0;
	private int xpCount = 0;
	private string userIDGloabl;

	void Awake()
	{
	
	
			GameSparks.Api.Messages.NewHighScoreMessage.Listener += HighScoreMessageHandler;
	}

		void HighScoreMessageHandler(GameSparks.Api.Messages.NewHighScoreMessage _message) 
	{
			Debug.Log("NEW HIGH SCORE \n " + _message.LeaderboardName);

	}

	void Start()
	{
		new GameSparks.Api.Requests.LogEventRequest().SetEventKey("LOAD_PLAYER").Send((response) => {
			if (!response.HasErrors) {
				Debug.Log("Received Player Data From GameSparks...");
				var data = response.ScriptData.GetGSData("player_Data");
				//print("Player ID: " + data.GetString("playerID"));
				//print("Player XP: " + data.GetString("playerXP"));
				//print("Player Gold: " + data.GetString("playerGold"));
				//print("Player Pos: " + data.GetString("playerPos"));

				userIDGloabl = data.GetString("playerID");
				playerPos.text = data.GetString("playerPos");
				xp.text = data.GetString("playerXP");
				gold.text = data.GetString("playerGold");

				xpCount = Convert.ToInt32(data.GetString("playerXP"));
				goldCount = Convert.ToInt32(data.GetString("playerGold"));

				xp.text = xpCount.ToString();
				gold.text = goldCount.ToString();
			} 
			else 
			{
				Debug.Log("Error Loading Player Data...");
			}
		});
			
		new GameSparks.Api.Requests.LeaderboardDataRequest().SetLeaderboardShortCode("SCORE_LEADERBOARD").SetEntryCount(100).Send((response) => {
			if (!response.HasErrors) {
				Debug.Log("Found Leaderboard Data...");
				foreach(GameSparks.Api.Responses.LeaderboardDataResponse._LeaderboardData entry in response.Data) {
					int rank = (int) entry.Rank;
					string userID = entry.UserId;
					string playerName = entry.UserName;
					string scoreGet = entry.JSONData["SCORE"].ToString();
					Debug.Log("Rank:" + rank + " Name:" + playerName + " \n Score:" + score);

					if(userID == userIDGloabl) 
					{
						playerID.text = playerName;
						scoreCount = Convert.ToInt32(scoreGet); 
						score.text = scoreCount.ToString();
					}
	
				}
			} else {
				Debug.Log("Error Retrieving Leaderboard Data...");
			}
		});
	}

	public void SavePlayerButton()
	{
		new GameSparks.Api.Requests.LogEventRequest().SetEventKey("SAVE_PLAYER")
			.SetEventAttribute("XP",xp.text)
			.SetEventAttribute("POS",this.transform.position.ToString())
			.SetEventAttribute("GOLD",gold.text)
			.Send((response) => {
				if (!response.HasErrors) {
					Debug.Log("Player Saved To GameSparks...");
				}  else {
					Debug.Log("Error Saving Player Data...");
				}
			} );

		new GameSparks.Api.Requests.LogEventRequest().SetEventKey("SUBMIT_SCORE").SetEventAttribute("SCORE",score.text).Send((response) => {
			if (!response.HasErrors) {
				Debug.Log("Score Posted Successfully...");
			} else {
				Debug.Log("Error Posting Score...");
			}
		});
	}

	void OnTriggerEnter(Collider other) 
	{
		if(other.CompareTag("gold"))
		{
			Destroy (other.gameObject);

			++goldCount;
			gold.text = goldCount.ToString ();

			scoreCount = (goldCount*10);
			score.text = scoreCount.ToString ();

			if (goldCount % 5 == 0) 
			{
				++xpCount;
				xp.text = xpCount.ToString ();
			}
				
		}
	}


}
