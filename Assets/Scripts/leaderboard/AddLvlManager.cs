using System.Collections;
using System.Collections.Generic;
using System;

using UnityEngine;
using UnityEngine.UI;

using GameSparks.Api.Requests;

public class AddLvlManager : MonoBehaviour {

	public Button addLvlButton;
	public InputField addLvlInput;
	public InputField addCountry;

	private int lvl;

	void Awake()
	{
		Button btn = addLvlButton.GetComponent<Button>();
		btn.onClick.AddListener(AddLvlTeam);
	}

	public void AddLvlTeam()
	{
		lvl = Convert.ToInt32 (addLvlInput.text);

		new LogEventRequest ().SetEventKey ("EV_LVL_TEAM")
			.SetEventAttribute ("ATT_LVL_TEAM", lvl)
			.Send ((response) => {
				if (!response.HasErrors) {
					Debug.Log ("lvl added"+lvl);
				} else {
					Debug.Log ("error lvl adding");
				}
			});
	}

	public void AddLvl()
	{
		lvl = Convert.ToInt32 (addLvlInput.text);

		new LogEventRequest ().SetEventKey ("EV_XP_LB_GL")
				.SetEventAttribute ("AT_XP_LB_GL", lvl)
				.Send ((response) => {
			if (!response.HasErrors) {
				Debug.Log ("lvl added"+lvl);
			} else {
				Debug.Log ("error lvl adding");
			}
		});
	}


	public void AddLvlCountry()
	{
		lvl = Convert.ToInt32 (addLvlInput.text);

		Debug.Log ("the lvl : "+lvl);
		Debug.Log ("the country : "+addCountry.text);

		new LogEventRequest ().SetEventKey ("EV_LB_CO")
			.SetEventAttribute ("AT_LB_LVL", lvl)
			.SetEventAttribute ("AT_LB_CO", addCountry.text)
			.Send ((response) => {
				if (!response.HasErrors) {
					Debug.Log ("lvl added");
				} else {
					Debug.Log ("error lvl adding");
				}
			});
	}
}
