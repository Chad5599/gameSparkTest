using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

using GameSparks.Api.Requests;
using GameSparks.Core;

public class AppPurchaser : MonoBehaviour {

    public Text gas;
    public Text playerName;

    private int gasCount = 0;
   
	// Use this for initialization
	void Start () {
        LoadCurrency();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("gold"))
        {
            AddGas();

            Destroy(other.gameObject);

        }
    }

    public void AddGas()
    {
    
        new LogEventRequest().SetEventKey("CURRENCY_ADD")
            .SetEventAttribute("ELIXIRE_CURR",0)
            .SetEventAttribute("GEM_CURR",0)
            .SetEventAttribute("GAS_CURR",1)
            .Send((response) => {
                if (!response.HasErrors) {
                      Debug.Log("currency added");
                }  else {
                      Debug.Log("Error adding gem");
                }
            } );
        
    }

    public void LoadCurrency()
    {
        new LogEventRequest().SetEventKey("LOAD_PLAYER").Send((response) => {
            if (!response.HasErrors) {
                //  Debug.Log("Received Player Data From GameSparks...");
                var data = response.ScriptData.GetGSData("player_Data");

                playerName.text = data.GetString("playerID");
            } 
            else 
            {
                //  Debug.Log("Error Loading Player Data...");
            }
        });

        new LogEventRequest().SetEventKey("Get_Named_Curr").Send((response) => 
        {
            if (!response.HasErrors) 
            {
                //  Debug.Log("Got the currency details");
                GSData balanceData = response.ScriptData.GetGSData("balance");

                int gasGetNumber = (int)balanceData.GetInt("gasQuantity");

                gasCount = gasGetNumber;
                gas.text = gasCount.ToString();

            } 
            else 
            {
                Debug.Log("Error getting named currency balance...");
            }
        });
    }
}

