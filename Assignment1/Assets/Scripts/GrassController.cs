using UnityEngine;
using System.Collections;

public class GrassController : MonoBehaviour {

	[SerializeField]
	private float speed = 0;

	private Transform _transform;
	private Vector2 _currentPosition;


	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform>();
		_currentPosition = _transform.position;
	}

	// Update is called once per frame
	void Update () {
		_currentPosition = transform.position;

		_currentPosition -= new Vector2 (speed,0);
		_transform.position = _currentPosition;

		if (_currentPosition.x < -10.0f) {
			Debug.Log (_currentPosition.x);
			Reset ();
		}
	}

	private void Reset(){
		
		_currentPosition = new Vector2 (10.0f, 0);
		_transform.position = _currentPosition;
	}
}

