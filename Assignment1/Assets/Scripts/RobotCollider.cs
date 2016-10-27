/*******************************************************************************************
*Source file name: Robot Colider
*Author’s name: Joe Zipeto
*Last Modified by: Joe Zipeto
*Date last Modified: October 27, 2016
*Program description: This controls all the collisions for the game.
*Revision History: 1.3 
**********************************************************************************************/

using UnityEngine;
using System.Collections;

public class RobotCollider : MonoBehaviour
{

	[SerializeField]
	GameObject explosion = null;

	public AudioClip coinclip;
	public AudioClip treeclip;


	void OnStart ()
	{
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		//Handles collision based on what is detected, Also play animation for explsosion and sounds based on the collision detected
		AudioSource asrc = GetComponent<AudioSource> ();
		TreeController tree = other.gameObject.GetComponent<TreeController> ();
		if (other.gameObject.tag == "Tree") {
			Player.Instance.Health -= 20;           

			if (tree != null) {
				//Play explosion animation and reset the gameobject and play sound
				GameObject gm = Instantiate (explosion);
				gm.transform.position = tree.transform.position;
				tree.Reset ();
				PlayAudio (treeclip, asrc);
			} 
		}

        // Add points for Gold
        else if (other.gameObject.tag == "GoldCoin") {
			Player.Instance.Points += 100;

			//Collect the coin and play sound
			CoinController coin = other.gameObject.GetComponent<CoinController> ();
			coin.Reset ();
			PlayAudio (coinclip, asrc);

		}
        // Add points for silver
        else if (other.gameObject.tag == "Silver Coin") {
			Player.Instance.Points += 50;

			//Collect the coin and play sound
			CoinController coin = other.gameObject.GetComponent<CoinController> ();
			coin.Reset ();
			PlayAudio (coinclip,asrc);

		}
        // Add points for Bronze
        else if (other.gameObject.tag == "BronzeCoin") {
			Player.Instance.Points += 10;

			//Collect the coin and play sound
			CoinController coin = other.gameObject.GetComponent<CoinController> ();
			coin.Reset ();
			PlayAudio (coinclip,asrc);
					
		}
	}

	private void PlayAudio (AudioClip audio, AudioSource asrc)
	{
		//Play Audio based on parameters
		if (asrc != null) {
			asrc.clip = audio;
			asrc.Play ();
		}
	}
}
