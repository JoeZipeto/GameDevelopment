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
