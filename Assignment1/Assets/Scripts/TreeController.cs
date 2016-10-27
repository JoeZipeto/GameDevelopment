/*******************************************************************************************
*Source file name: TreeController
*Author’s name: Joe ZIpeto
*Last Modified by: Joe Zipeto
*Date last Modified: October 26, 2016
*Program description: This is the Controller for the UI The labels get update based on what the player does
*Revision History: 1.3 
**********************************************************************************************/

using UnityEngine;
using System.Collections;

public class TreeController : MonoBehaviour
{

    [SerializeField]
    private float speed = 0;

    private Transform _transform;
    private Vector2 _currentPosition;

    private float miny = -3.1f;
    private float maxy = 3.1f;


    // Use this for initialization
    void Start()
    {
        _transform = gameObject.transform;
        _currentPosition = _transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		//Controls the movement Of trees and resets them when they Are outside the boundaries
        _currentPosition = transform.position;
        _currentPosition -= new Vector2(speed, 0);

        if (_currentPosition.x <= -13.0f)
        {
            Reset();
        }
        _transform.position = _currentPosition;
    }

    public void Reset()
    {
		//Resets trees randomly on the y access
        float ypos = Random.Range(miny, maxy);
        _currentPosition = new Vector2(18.0f, ypos);
        _transform.position = _currentPosition;

    }
}