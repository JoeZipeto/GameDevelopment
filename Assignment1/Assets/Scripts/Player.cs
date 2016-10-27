/*******************************************************************************************
*Source file name: Player
*Author’s name: Joe Zipeto
*Last Modified by: Joe Zipeto
*Date last Modified: October 24, 2016
*Program description: Singleton class to hold all the player information
*Revision History: 1.3 
**********************************************************************************************/

using UnityEngine;
using System.Collections;

public class Player
{
    //SingleTon Class to keep scores and health variables for the game
    //DataMembers
	private int _points = 0;
    private int _health = 100;
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
        set {
			_points = value;
				//trigger UI update
				hud.UpdatePoints ();

		}
    }

    public int Health
    {
		//getter and setters for health
        get { return _health; }

        //Update health on tree collision
        set
        {
            _health = value;

            //trigger UI update
           hud.UpdateHealth();
			if (_health <= 0) {
				hud.GameOver ();
			}
        }
    }
}
