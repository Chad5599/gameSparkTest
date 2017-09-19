using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

using GameSparks.Api;
using GameSparks.Api.Requests;
using GameSparks.Api.Responses;
using GameSparks.Api.Messages;
using System.Text;
using System.Linq;
using GameSparks.Core;

public class Multiplayer : MonoBehaviour
{
    public Text xp; 
    public Text playerIdText;
    public Text playerPos; 
    public Text score;
    public Text status;
    public Text turn;

    private int scoreCount = 0; 
    private int xpCount = 0;

    private string userIDGloabl;
    private string matchId;
    private string challengeId;
    private string playerId;

    void Awake()
    {
			

    }

    void Start()
    {
        MatchFoundMessage.Listener += GetMessages;
        ChallengeIssuedMessage.Listener += GetMessages1;
       // ScriptMessage.Listener += GetMessages;
    }

    public void GetMessages(MatchFoundMessage message)
    {
        Debug.Log("The message is :"+message);
    }

    public void GetMessages1(ChallengeIssuedMessage message)
    {
        Debug.Log("The message is :"+message);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("gold"))
        {
            Destroy(other.gameObject);

        }
    }

    public void FindMatch()
    {
        new MatchmakingRequest()
			.SetMatchShortCode("multi_match_click")
			.SetSkill(xpCount)
			.Send((response) => {
            if (!response.HasErrors)
            {

                Debug.Log("Match has been made...");


            }
            else
            {
                Debug.Log("Error making MatchMakingRequest...");
            }
        });
    }

    public void EnterScore()
    {
		
    }

    public void IncreaseScore()
    {
        ++scoreCount;
        score.text = scoreCount.ToString();
    }

    public void DecreaseScore()
    {
        if (scoreCount > 0)
        {
            --scoreCount;
            score.text = scoreCount.ToString();
        }
    }

    public void IncreaseXP()
    {
        ++xpCount;
        xp.text = xpCount.ToString();
    }

    public void DecreaseXP()
    {
        if (xpCount > 0)
        {
            --xpCount;
            xp.text = xpCount.ToString();
        }
    }
}
