using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

using GameSparks.Api.Requests;

public class SavePlayer : MonoBehaviour {

	public Text gold, xp,playerID,playerPos,score,elixire,gem,virtualGoods;
	public int gemAddValue = 1,elixireAddValue = 5;
	public int gemSubValue = 10,elixireSubValue = 500;

	private int goldCount = 0,scoreCount = 0,xpCount = 0,gemCurr = 0,elixireCurr = 0;
	private string userIDGloabl;



	void Awake()
	{

		GameSparks.Api.Messages.AchievementEarnedMessage.Listener += AchievementMessageHandler;
	
	
			GameSparks.Api.Messages.NewHighScoreMessage.Listener += HighScoreMessageHandler;
	}

	void AchievementMessageHandler(GameSparks.Api.Messages.AchievementEarnedMessage _message) {
		Debug.Log("AWARDED ACHIEVEMENT \n " + _message.AchievementName);
	}

		void HighScoreMessageHandler(GameSparks.Api.Messages.NewHighScoreMessage _message) 
	{
			Debug.Log("NEW HIGH SCORE \n " + _message.LeaderboardName);

	}

	void Start()
	{
		Load_Data_Currency ();//loading currency and player data

		new LeaderboardDataRequest().SetLeaderboardShortCode("SCORE_LEADERBOARD").SetEntryCount(100).Send((response) => {
			if (!response.HasErrors) {
				Debug.Log("Found Leaderboard Data...");
				foreach(GameSparks.Api.Responses.LeaderboardDataResponse._LeaderboardData entry in response.Data) {
					int rank = (int) entry.Rank;
					string userID = entry.UserId;
					string playerName = entry.UserName;
					string scoreGet = entry.JSONData["SCORE"].ToString();
					//Debug.Log("Rank:" + rank + " Name:" + playerName + " \n Score:" + score);

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
		
	public void BuyGemWithVirtualGood()
	{
		if (goldCount >= 100) {
			new LogEventRequest ().SetEventKey ("Buy_Virtual_Gem")
				.Send ((response) => {
					if (!response.HasErrors) {
						Debug.Log ("gem added");
					} else {
						Debug.Log ("Error gem added");
					}
				});

			goldCount = goldCount - 100;
			gold.text = goldCount.ToString ();

			new LogEventRequest().SetEventKey("SAVE_PLAYER")
				.SetEventAttribute("XP",xp.text)
				.SetEventAttribute("POS",this.transform.position.ToString())
				.SetEventAttribute("GOLD",gold.text)
				.Send((response) => {
					if (!response.HasErrors) {
						//	Debug.Log("Player Saved To GameSparks...");
					}  else {
						Debug.Log("Error Saving Player Data...");
					}
				} );


			Load_Data_Currency ();//load currency and player data

		}
		else 
		{
			Debug.Log("not enough gems to buy gold");
		}

	}




	public void BuyGoldWithElixire()
	{
		if (elixireCurr >= 500) {
			new LogEventRequest ().SetEventKey ("CURRENCY_SUB")
				.SetEventAttribute ("ELIXIRE_CURR", elixireSubValue)
				.SetEventAttribute ("GEM_CURR", 0)
			.Send ((response) => {
				if (!response.HasErrors) {
					Debug.Log ("elixire subtracted");
				} else {
					Debug.Log ("error elixire subtracting");
				}
			});
			
			Load_Data_Currency ();//load currency and player data

		} 
		else 
		{
			Debug.Log("not enough Elixire to buy gold");	
		}
	}

	public void BuyGoldWithGem()
	{
		if (gemCurr >= 10) {
			new LogEventRequest ().SetEventKey ("CURRENCY_SUB")
				.SetEventAttribute ("ELIXIRE_CURR", 0)
				.SetEventAttribute ("GEM_CURR", gemSubValue)
				.Send ((response) => {
				if (!response.HasErrors) {
					Debug.Log ("gem subtracted");
				} else {
					Debug.Log ("Error gem subtracted");
				}
			});

			Load_Data_Currency ();//load currency and player data

		}
		else 
		{
			Debug.Log("not enough gems to buy gold");
		}

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
			if (goldCount % 10 == 0) 
			{
				++gemCurr;
				gem.text = gemCurr.ToString ();

				new LogEventRequest().SetEventKey("CURRENCY_ADD")
					.SetEventAttribute("ELIXIRE_CURR",0)
					.SetEventAttribute("GEM_CURR",gemAddValue)
					.Send((response) => {
						if (!response.HasErrors) {
						//	Debug.Log("currency added");
						}  else {
							Debug.Log("Error adding gem");
						}
					} );

				new LogEventRequest().SetEventKey("Award_Achievement").Send((response) => {
					if (!response.HasErrors) {
						Debug.Log("Achievement done...");

					} 
					else 
					{
						Debug.Log("Error awarding achievement...");
					}
				});

				Load_Data_Currency ();//load currency and player data
				

			}
			if (goldCount % 2 == 0) 
			{
				++elixireCurr;
				elixire.text = elixireCurr.ToString ();

				new LogEventRequest().SetEventKey("CURRENCY_ADD")
					.SetEventAttribute("ELIXIRE_CURR",elixireAddValue)
					.SetEventAttribute("GEM_CURR",0)
					.Send((response) => {
						if (!response.HasErrors) {
						//	Debug.Log("currency added");
						}  else {
							Debug.Log("Error adding elixire");
						}
					} );

				Load_Data_Currency ();//load currency and player data
			}

			new LogEventRequest().SetEventKey("SAVE_PLAYER")
				.SetEventAttribute("XP",xp.text)
				.SetEventAttribute("POS",this.transform.position.ToString())
				.SetEventAttribute("GOLD",gold.text)
				.Send((response) => {
					if (!response.HasErrors) {
					//	Debug.Log("Player Saved To GameSparks...");
					}  else {
						Debug.Log("Error Saving Player Data...");
					}
				} );

			new GameSparks.Api.Requests.LogEventRequest().SetEventKey("SUBMIT_SCORE").SetEventAttribute("SCORE",score.text).Send((response) => {
				if (!response.HasErrors) {
				//	Debug.Log("Score Posted Successfully...");
				} else {
					Debug.Log("Error Posting Score...");
				}
			});
				
		}
	}


	public void Load_Data_Currency()
	{
		new LogEventRequest().SetEventKey("LOAD_PLAYER").Send((response) => {
			if (!response.HasErrors) {
				Debug.Log("Received Player Data From GameSparks...");
				var data = response.ScriptData.GetGSData("player_Data");

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

		new AccountDetailsRequest().Send((response) =>
			{
				if (!response.HasErrors) 
				{
					//Debug.Log("I have "+(response.Currency1 != null ? (int)response.Currency1 : 0) +" coins");
					//Debug.Log("I have "+(response.Currency2 != null ? (int)response.Currency2 : 0) +" coins");

					//					var ELIXIRE_CURR = response.ELIXIRE; 
					//	GSData reservedCurrency1 = response.ReservedCurrency1; 

					//					Debug.Log("The currency is :"+reservedCurrency1);
					elixireCurr = (int)response.Currency1;
					gemCurr     = (int)response.Currency2;

					elixire.text = elixireCurr.ToString();
					gem.text     = gemCurr.ToString();
				}
				else 
				{
					Debug.Log("Error Getting Currencies...");
				}
			});
	}
	      
	public void ShowVirtualGoodButton()
	{
	new GameSparks.Api.Requests.AccountDetailsRequest().Send((response) => {
		if (!response.HasErrors) {
			Debug.Log("Account Details Found...");
			string playerName = response.DisplayName; // we can get the display name
			int cashAvailable = (int) response.Currency1;
			int goldCoinsAvailable = (int) response.VirtualGoods.GetNumber("GOLD_COIN");
				virtualGoods.text = goldCoinsAvailable.ToString();
		} else {
			Debug.Log("Error Retrieving Account Details...");
		}
	});
	}

	public void BuyVirtualGoods()
	{
		new BuyVirtualGoodsRequest().SetCurrencyShortCode("GEM").SetQuantity(1).SetShortCode("GOLD_COIN").Send((response) => {
			if (!response.HasErrors) {
				Debug.Log("Virtual Goods Bought Successfully...");
			} else {
				Debug.Log("Error Buying Virtual Goods...");
			}
		});
		
		Load_Data_Currency();
	}
	public void SpendVirtualGoods()
	{
		new ConsumeVirtualGoodRequest().SetQuantity(1).SetShortCode("GOLD_COIN").Send((response) => {
			if (!response.HasErrors) {
				Debug.Log("Virtual Goods Consumed Successfully...");
			} else {
				Debug.Log("Error Consuming Virtual Goods...");
			}
		});
		
		Load_Data_Currency();

	}


}
