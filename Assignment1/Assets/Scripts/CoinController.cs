using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour {
	//Coin Controller

	[SerializeField]
	private float speed = 0;

	private Transform _transform;
	private Vector2 _currentPosition;

	private float miny = -3f;
	private float maxy = 3f;


	// Use this for initialization
	void Start () {
		_transform = gameObject.transform;
		_currentPosition = _transform.position;
	}

	// Update is called once per frame
	void FixedUpdate () {
		_currentPosition = transform.position;
		_currentPosition -= new Vector2 (speed, 0);

		if (_currentPosition.x <= -13.0f) {
			Reset ();
		}
		_transform.position = _currentPosition;
	}

	public void  Reset(){

		float ypos = Random.Range (miny, maxy);
		_currentPosition = new Vector2 (20.0f, ypos);
		_transform.position = _currentPosition;

	}
}