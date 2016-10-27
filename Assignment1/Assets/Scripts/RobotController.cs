/*******************************************************************************************
*Source file name: RobotController
*Author’s name: Joe ZIpeto
*Last Modified by: Joe Zipeto
*Date last Modified: October 21, 2016
*Program description: This is the Controller for the robot
*Revision History: 1.3 
**********************************************************************************************/


using UnityEngine;
using System.Collections;

public class RobotController : MonoBehaviour
{
    [SerializeField]
    private float speed = 0;

    private Transform _transform;
    private Vector2 _currentPosition;



    // Use this for initialization
    void Start()
    {
        _transform = gameObject.transform;
        _currentPosition = _transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		//Controls the movement of the robot based on what keys the users presses
        float input = Input.GetAxis("Vertical");

        if (input > 0)
            _currentPosition += new Vector2(0, speed);

        if (input < 0)
            _currentPosition -= new Vector2(0, speed);

        checkBounds();
        _transform.position = _currentPosition;

    }

    private void checkBounds()
    {
		//Does not let the robot go out of bounds of the screen
        if (_currentPosition.y < -3.5f)
        {
            _currentPosition.y = -3.5f;
        }
        if (_currentPosition.y > 3.5f)
        {
            _currentPosition.y = 3.5f;
        }
    }

}
