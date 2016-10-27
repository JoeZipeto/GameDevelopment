/*******************************************************************************************
*Source file name: GrassController
*Author’s name: Joe Zipeto
*Last Modified by: Joe Zipeto
*Date last Modified: October 26, 2016
*Program description: This controls the movement of the grass
*Revision History: 1.3 
**********************************************************************************************/

using UnityEngine;
using System.Collections;

public class GrassController : MonoBehaviour {

	//Data Members
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
	void FixedUpdate () {
		//Move the grass  if it reaches the end of the picture reset it to the begining
		_currentPosition = transform.position;

		_currentPosition -= new Vector2 (speed,0);
		_transform.position = _currentPosition;

		if (_currentPosition.x < -10.0f) {	Reset ();}
	}

	private void Reset(){
		//For reset it to the begining of the image
		_currentPosition = new Vector2 (10.0f, 0);
		_transform.position = _currentPosition;
	}
}

