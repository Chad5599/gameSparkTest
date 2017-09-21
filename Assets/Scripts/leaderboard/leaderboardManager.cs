using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

using GameSparks.Api.Requests;
using GameSparks.Api.Responses;

public class leaderboardManager : MonoBehaviour {

	public Button addLvlButton;
	public Button addLvlCountryButton;
	public InputField inputCountry;
	public Text addLvlText;
	public GameObject CanvasObj;

	private int lvl;

	void Awake()
	{
		Button btn = addLvlButton.GetComponent<Button>();
		btn.onClick.AddListener(RequestLeaderBoard);

		Button btn1 = addLvlCountryButton.GetComponent<Button>();
		btn1.onClick.AddListener(RequestLeaderBoardCountry);
	}
		
	public void RequestLeaderBoard()
	{
		new LeaderboardDataRequest().SetLeaderboardShortCode("LB_XP_GL").SetEntryCount(20)
			.Send((response) => {
			if (!response.HasErrors) {
				Debug.Log("Found Leaderboard Data...");
					int count = 0;
				foreach(LeaderboardDataResponse._LeaderboardData entry in response.Data) {
					int rank = (int) entry.Rank;
					string playerName = entry.UserName;
					string score = entry.JSONData["AT_XP_LB_GL"].ToString();

					Debug.Log("Rank:" + rank + " Name:" + playerName + " LVL:" + score);
					
						GameObject tempObj = new GameObject("textObj");
						tempObj.transform.SetParent(CanvasObj.transform);

						Text newText = tempObj.AddComponent<Text>();
						newText.rectTransform.sizeDelta = new Vector2(1000,100);
						newText.fontSize = 80;
						newText.color = Color.white;
						newText.font = Resources.Load<Font>("font/arial");
						++count;
						newText.rectTransform.position = new Vector2(addLvlText.rectTransform.position.x,addLvlText.rectTransform.position.y - (120*count));
						newText.text = "Rank:" + rank + " Name:" + playerName + " LVL:" + score;
				}
			} else {
				Debug.Log("Error Retrieving Leaderboard Data...");
			}
		});

	}

	public void RequestLeaderBoardCountry()
	{
		foreach (Transform child in CanvasObj.transform)
		{
			if (child.name == "textObj") 
			{
				Destroy (child.gameObject);
			}
		}

		new LeaderboardDataRequest().SetLeaderboardShortCode("LB_CO.AT_LB_CO."+inputCountry.text).SetEntryCount(20)
			.Send((response) => {
				if (!response.HasErrors) {
					Debug.Log("Found Leaderboard Data...");
					int count = 0;
					foreach(LeaderboardDataResponse._LeaderboardData entry in response.Data) {
						int rank = (int) entry.Rank;
						string playerName = entry.UserName;
						string score = entry.JSONData["AT_LB_LVL"].ToString();

						Debug.Log("Rank:" + rank + " Name:" + playerName + " LVL:" + score);

						GameObject tempObj = new GameObject("textObj");
						tempObj.transform.SetParent(CanvasObj.transform);

						Text newText = tempObj.AddComponent<Text>();
						newText.rectTransform.sizeDelta = new Vector2(1000,100);
						newText.fontSize = 80;
						newText.color = Color.white;
						newText.font = Resources.Load<Font>("font/arial");
						++count;
						newText.rectTransform.position = new Vector2(addLvlText.rectTransform.position.x,addLvlText.rectTransform.position.y - (120*count));
						newText.text = "Rank:" + rank + " Name:" + playerName + " LVL:" + score;
					}
				} else {
					Debug.Log("Error Retrieving Leaderboard Data...");
				}
			});

	}


}
