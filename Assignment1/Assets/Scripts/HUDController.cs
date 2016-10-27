/*******************************************************************************************
*Source file name: HUDController
*Author’s name: Joe ZIpeto
*Last Modified by: Joe Zipeto
*Date last Modified: October 26, 2016
*Program description: This is the Controller for the UI The labels get update based on what the player does
*Revision History: 1.3 
**********************************************************************************************/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUDController : MonoBehaviour {
	[SerializeField]
	Text points = null;
	[SerializeField]
	Text health = null;

	//new
	[SerializeField]
	Button restartBtn = null;
	[SerializeField]
	Text gameoverLabel = null;
	[SerializeField]
	GameObject player = null;


	// Use this for initialization
	void Start () {
		points.text = "Points: 0";
		health.text = "Health: 100";
		Player.Instance.hud = this;
		RestartGame ();
	}
		
	public void UpdatePoints(){
		points.text = "Points: " + Player.Instance.Points;
	}

	public void UpdateHealth(){
		health.text = "Health: " + Player.Instance.Health;
	}

	public void GameOver(){
		//hide labels with health and points
		points.gameObject.SetActive (false);
		health.gameObject.SetActive (false);

		//deavtivate player
		player.gameObject.SetActive (false);

		//Display games over label
		gameoverLabel.gameObject.SetActive (true);

		//display restart button
		restartBtn.gameObject.SetActive (true);
	}

	public void RestartGame(){
		//Debug.Log ("This works");
		//hide labels with health and points
		points.gameObject.SetActive (true);
		health.gameObject.SetActive (true);

		Player.Instance.Points = 0;
		Player.Instance.Health = 100;

		//activate player
		player.gameObject.SetActive (true);

		//hide games over label
		gameoverLabel.gameObject.SetActive (false);

		//hide restart button
		restartBtn.gameObject.SetActive(false);

	}
}

