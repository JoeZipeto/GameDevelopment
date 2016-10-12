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
		TreeController tree = other.gameObject.GetComponent<TreeController> ();
		if (other.gameObject.tag == "Tree") {
			Player.Instance.Health -= 10;           

			if (tree != null) {
				//Play explosion animation and reset the gameobject and play sound
				GameObject gm = Instantiate (explosion);
				gm.transform.position = tree.transform.position;
				tree.Reset ();
				PlayAudio (treeclip);
			} 
		}

        // Add points for Gold
        else if (other.gameObject.tag == "GoldCoin") {
			Player.Instance.Points += 100;

			//Collect the coin and play sound
			CoinController coin = other.gameObject.GetComponent<CoinController> ();
			coin.Reset ();
			PlayAudio (coinclip);

		}
        // Add points for silver
        else if (other.gameObject.tag == "Silver Coin") {
			Player.Instance.Points += 50;

			//Collect the coin and play sound
			CoinController coin = other.gameObject.GetComponent<CoinController> ();
			coin.Reset ();
			PlayAudio (coinclip);

		}
        // Add points for Bronze
        else if (other.gameObject.tag == "BronzeCoin") {
			Player.Instance.Points += 10;

			//Collect the coin and play sound
			CoinController coin = other.gameObject.GetComponent<CoinController> ();
			coin.Reset ();
			PlayAudio (coinclip);
		}
	}

	private void PlayAudio (AudioClip audio)
	{
		//Play coin Audio
		AudioSource asrc = GetComponent<AudioSource> ();
		if (asrc != null) {
			asrc.PlayOneShot (audio);
		}

	}
}
