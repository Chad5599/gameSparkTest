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
using UnityEngine.SceneManagement;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using GameSparks.Api.Requests;
using GameSparks.Core;
using GameSparks.Api.Messages;

public class Multiplayer : MonoBehaviour
{
    public Text xp;
    public Text playerName;
    public Text opponentName;
    public Text score;
    public Text totalScore;
    public Text time;
    public Text turn;
    public Text log;
    public Text turnOpponentScore;
    public Text turnOpponentTimeClick;

    public Button backButton;
    public Button xpIncreaseButton;
    public Button xpDecreaseButton;
    public Button scoreIncreaseButton;
    public Button scoreDecreaseButton;
    public Button enterScoreButton;
    public Button findMatchButton;
    public Button cancelMatchButton;

    private int turnFlag = 0;
    private int timmerFlag = 0;
    private int endMatchEventCallFlag = 1;
    private int totalScoreCount = 0;
    private int scoreCount = 0;
    private int xpCount = 0;
    private int turnCount = 0;
    private float timeCount = 0f;
    private int timeIntCount = 0;
    private int currentTimeIntCount = 0;
    private int timeIntDiff = 0;

    private string challengeId;
    private string playerNameString;
    private string playerIdString;
    private string opponentNameString;
    private string opponentIdString;


    void Awake()
    {
        Button btn0 = backButton.GetComponent<Button>();
        btn0.onClick.AddListener(BackScene);
			
        Button btn1 = xpIncreaseButton.GetComponent<Button>();
        btn1.onClick.AddListener(IncreaseXP);
        Button btn2 = xpDecreaseButton.GetComponent<Button>();
        btn2.onClick.AddListener(DecreaseXP);

        Button btn3 = scoreIncreaseButton.GetComponent<Button>();
        btn3.onClick.AddListener(IncreaseScore);
        Button btn4 = scoreDecreaseButton.GetComponent<Button>();
        btn4.onClick.AddListener(DecreaseScore);

        Button btn5 = enterScoreButton.GetComponent<Button>();
        btn5.onClick.AddListener(EnterScore);
        Button btn6 = findMatchButton.GetComponent<Button>();
        btn6.onClick.AddListener(FindMatch);
        Button btn7 = cancelMatchButton.GetComponent<Button>();
        btn7.onClick.AddListener(CancelMatch);



        new AccountDetailsRequest().Send((response) => {
            if (!response.HasErrors)
            {
                Debug.Log("Account Details Found...");
                playerNameString = response.DisplayName; 
                playerIdString = response.UserId;

                Debug.Log("playerName : " + playerNameString);
                Debug.Log("playerId : " + playerIdString);

                playerName.text = playerNameString;
            }
            else
            {
                Debug.Log("Error Retrieving Account Details...");
            }
        });
    }

    void Start()
    {
        ScriptMessage.Listener += GetScriptMessages;
        MatchFoundMessage.Listener += GetMatchFoundMessage;
        ChallengeIssuedMessage.Listener += GetChallengeIssued;
        ChallengeStartedMessage.Listener += GetMessagesChallengeStarted;
        ChallengeTurnTakenMessage.Listener += GetMessageChallengeTurnTaken;
        ChallengeWonMessage.Listener += GetMessageChallengeWon;
        ChallengeLostMessage.Listener += GetMessageChallengeLost;
    }

    void FixedUpdate()
    {
        if (timmerFlag == 1)
        {	
            timeCount = timeCount + 0.02f;
            timeIntCount = Convert.ToInt32(timeCount);
            time.text = timeIntCount.ToString();
        }

        if (timeIntCount >= 20 || totalScoreCount >= 10)
        {
            if (endMatchEventCallFlag == 1)
            {
                EndChalEvent();	
                endMatchEventCallFlag = 0;
            }
        }
    }

	

    public void GetMessageChallengeWon(ChallengeWonMessage message)
    {
        Debug.Log("Challenge Won message");
        Debug.Log("The Challenge Won message :" + message.JSONString);
        log.text = "Congrats Boy : You won the Match with " + opponentNameString;
        turn.text = "WON";

        timeIntDiff = 0;
        scoreCount = 0;
        timeIntCount = 0;
        timeCount = 0;
        totalScoreCount = 0;

    }

    public void GetMessageChallengeLost(ChallengeLostMessage message)
    {
        Debug.Log("Challenge Lost message");
        Debug.Log("The Challenge Lost message :" + message.JSONString);

        log.text = "Get a life Boy : You Lost the Match with " + opponentNameString;
        turn.text = "LOST";

        timeIntDiff = 0;
        scoreCount = 0;
        timeIntCount = 0;
        timeCount = 0;
        totalScoreCount = 0;
    }

    public void GetMessageChallengeTurnTaken(ChallengeTurnTakenMessage message)
    {
        Debug.Log("Turn Taken message");
        Debug.Log("The challenge turn taken message :" + message.JSONString);

    }

    public void GetScriptMessages(ScriptMessage message)
    {
        Debug.Log("Script messages");

	

        Debug.Log("All messages : " + message.Data.JSON);

        if (message.ExtCode == "playerTurnMessage")
        {
            turn.text = "My Turn";
            turnFlag = 1;
            timmerFlag = 1;

            string localOpponentId = message.Data.GetString("opponentPlayerId");
            int? localOpponentScore = message.Data.GetInt("score");
            int? localOpponentTimeClick = message.Data.GetInt("timeClick");

            turnOpponentScore.text = localOpponentScore.ToString();
            turnOpponentTimeClick.text = localOpponentTimeClick.ToString();

            Debug.Log("The opponent player Id who take turn is : " + localOpponentId);
            Debug.Log("The opponent player score who take turn is : " + localOpponentScore);
            Debug.Log("The opponent player time who take turn is : " + localOpponentTimeClick);

            log.text = localOpponentId + " opponent ";

        }

        if (message.ExtCode == "EndChalMessage")
        {
            turn.text = "End Match";
            turnFlag = 0;
            timmerFlag = 0;

            string localOpponentId = message.Data.GetString("opponentPlayerId");
            int? localOpponentScore = message.Data.GetInt("score");
            int? localOpponentTimeClick = message.Data.GetInt("timeClick");

            turnOpponentScore.text = localOpponentScore.ToString();
            turnOpponentTimeClick.text = localOpponentTimeClick.ToString();

            Debug.Log("The opponent player Id who take turn is : " + localOpponentId);
            Debug.Log("The opponent player score who take turn is : " + localOpponentScore);
            Debug.Log("The opponent player time who take turn is : " + localOpponentTimeClick);

            log.text = localOpponentId + " opponent ";

        }
    }

    public void GetMatchFoundMessage(MatchFoundMessage message)
    {
        Debug.Log("got match found message");

        Debug.Log("The challenge Match found message :" + message.JSONString);

        log.text = "Match found";
        //Debug.Log("1- The match found message is :"+message.Participants.ToString());
        //Debug.Log("3- The match found message is :"+message.JSONData);
        //Debug.Log("4- The match found message is :"+message.JSONData.ToString());
        //Debug.Log("5- The match found message is :"+message.ScriptData);


        //Debug.Log("The match found message is :"+message.ScriptData.GetString("matchShortCode"));


    }

    public void GetChallengeIssued(ChallengeIssuedMessage message)
    {

        Debug.Log("challenge issued message");

        Debug.Log("The challenge Issued message :" + message.JSONString);

        log.text = "Challenge Issued";

        string challengeInstanceId = message.Challenge.ChallengeId.ToString();

        Debug.Log("The challenge Id :" + challengeInstanceId);

        new AcceptChallengeRequest()
			.SetChallengeInstanceId(challengeInstanceId)
			.Send((response) => {
            if (!response.HasErrors)
            {
                Debug.Log("challenge accepted success");
            }
            else
            {
                Debug.Log("Error challange accepted");
            }
        });


    }

    public void GetMessagesChallengeStarted(ChallengeStartedMessage message)
    {
        Debug.Log("challenge started message");


        log.text = "Challenge started";
        turn.text = "Opponent Turn";

        //Debug.Log("The challenge Started :"+message.JSONString);
	
        GSData challengeData = message.BaseData.GetGSData("challenge");

        List<GSData> acceptedPlayerList = challengeData.GetGSDataList("accepted");

        challengeId = challengeData.GetString("challengeId");
        Debug.Log("challenge Id is : " + challengeId);
        Debug.Log("lalalalalalalal : " + challengeId);
        foreach (GSData entry in acceptedPlayerList)
        {
            string localPlayerName = entry.GetString("name").ToString();
            string localPlayerId = entry.GetString("id").ToString();

            if (localPlayerId != playerIdString)
            {
                opponentName.text = localPlayerName;
                opponentIdString = localPlayerId;
                opponentNameString = localPlayerName;

                Debug.Log("OpponentName : " + opponentNameString);
                Debug.Log("OpponentId : " + opponentIdString);
            }
        }
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
        log.text = "finding Match";
		
        new MatchmakingRequest()
			.SetMatchShortCode("multiMatchClick")
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

    public void CancelMatch()
    {
        new MatchmakingRequest()
			.SetAction("cancel")
			.SetMatchShortCode("multiMatchClick")
			.Send((response) => {
            if (!response.HasErrors)
            {
                Debug.Log("Match has been Cancelled");
            }
            else
            {
                Debug.Log("Error cancelling match");
            }
        });
		
    }

    public void EnterScore()
    {	
        if (turnFlag == 1)
        {
			
            totalScoreCount += scoreCount;
            totalScore.text = totalScoreCount.ToString();    
            currentTimeIntCount = timeIntCount - timeIntDiff;


            timmerFlag = 0;
            turnFlag = 0;

            Debug.Log("current time int : " + currentTimeIntCount + " and currnet score : " + scoreCount);

            new LogChallengeEventRequest()
			.SetChallengeInstanceId(challengeId)
			.SetEventKey("multiEventClick")
			.SetEventAttribute("score", scoreCount)
			.SetEventAttribute("timeClick", currentTimeIntCount)
			.Send((response) => {

                if (!response.HasErrors)
                {

                    Debug.Log("success multi event chall");
                    log.text = "success multi event chall";
                    turn.text = "Opponent turn";

                    timeIntDiff += currentTimeIntCount;//the time which is submitted will be added to subtraction
                }
                else
                {
                    Debug.Log("error multi event chall" + response.Errors.JSON);
                    log.text = "error multi event chall" + response.Errors.JSON;
                }
            });
        }
        else
        {
            Debug.Log("Not your turn player");
            log.text = "Not your turn";
        }
    }

    public void EndChalEvent()
    {

        totalScoreCount += scoreCount;
        totalScore.text = totalScoreCount.ToString();  
        currentTimeIntCount = timeIntCount - timeIntDiff;

        timmerFlag = 0;
        turnFlag = 0;

        new LogEventRequest()
			.SetEventKey("endChalEvent")
			.SetEventAttribute("chalId", challengeId)
			.SetEventAttribute("score", scoreCount)
			.SetEventAttribute("timeClick", currentTimeIntCount)
			.SetEventAttribute("opponentId", opponentIdString)
			.Send((response) => {

            if (!response.HasErrors)
            {

                Debug.Log("success end chal event");
                //log.text = "success end chal event :::::  Match End";
                //turn.text = "Opponent turn";

			
            }
            else
            {
                Debug.Log("error end chal event" + response.Errors.JSON);
                log.text = "error end chal event" + response.Errors.JSON;
            }
        });
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

    public void BackScene()
    {
        SceneManager.LoadScene("GamesparksScene");
    }
}
