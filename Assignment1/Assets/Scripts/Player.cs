using UnityEngine;
using System.Collections;

public class Player
{
    //SingleTon Class to keep scores and health variables for the game
    private int _points = 0;
    private int _health = 100;
	private const string key = "HIGH_SCORE";
	public HUDController hud;
    private static Player _instance = null;

    private Player() { } // Private Constructor

    public static Player Instance
    {
		//if the player instance is null create a new instance!
        get
        {
            if (_instance == null) { _instance = new Player(); }
            return _instance;
        }
    }
    public int Points
    {
		//Getter and setter for points
        get { 
			return _points; 
		}

        //set points for coin collection
        set
        {
            _points = value;

            //trigger UI update
            hud.UpdatePoints();
        }
    }

    public int Health
    {
        get { return _health; }

        //Update health on tree collision
        set
        {
            _health = value;

            //trigger UI update
           hud.UpdateHealth();
			if (_health <= 0) {
			//	hud.GameOver ();
			}
        }
    }

	private int _highScore = 0;


	public int HighScore{
	// Keep Track of Highscores using PlayerPrefs
		get{ 
			return _highScore;
		}

		set{ 
			if (value > _highScore) {
				_highScore = value;
				PlayerPrefs.SetInt (key, _highScore);
			}
		}
	}


}
