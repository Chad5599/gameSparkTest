using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class SavePlayer : MonoBehaviour {

	public Text gold, xp,playerID,playerPos;
	private int goldCount = 0;
	private int xpCount = 0;


	void Start()
	{
		new GameSparks.Api.Requests.LogEventRequest().SetEventKey("LOAD_PLAYER").Send((response) => {
			if (!response.HasErrors) {
				Debug.Log("Received Player Data From GameSparks...");
				var data = response.ScriptData.GetGSData("player_Data");
				print("Player ID: " + data.GetString("playerID"));
				print("Player XP: " + data.GetString("playerXP"));
				print("Player Gold: " + data.GetString("playerGold"));
				print("Player Pos: " + data.GetString("playerPos"));

				playerID.text = data.GetString("playerID");
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
	}

	void OnTriggerEnter(Collider other) 
	{
		if(other.CompareTag("gold"))
		{
			Destroy (other.gameObject);

			++goldCount;
			gold.text = goldCount.ToString ();

			if (goldCount % 5 == 0) 
			{
				++xpCount;
				xp.text = xpCount.ToString ();
			}
		}
	}


}
