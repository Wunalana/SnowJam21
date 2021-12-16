using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    Vector2 _initialPos;
    Rigidbody2D _rb;

    // DEFINE VELOCITY VALUES
    Vector2 rightVelocity;
    Vector2 leftVelocity;
    Vector2 downVelocity;

    Vector2 testVelocity;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        // transform.position = _initialPos;

        // INITIALIZE VELOCITY VALUES
        rightVelocity = new Vector2(7, 0);
        leftVelocity = new Vector2(-7, 0);
        testVelocity = new Vector2(0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("D key was pressed");
            moveRight();
        }

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A key was pressed");
            moveLeft();
        }


    }

    private void moveRight()
    {
        if (_rb.velocity.x < rightVelocity.x)
        {
            _rb.AddForce(rightVelocity);
        }

    }

    private void moveLeft()
    {
        if (_rb.velocity.x > leftVelocity.x)
        {
            _rb.AddForce(leftVelocity);
        }
    }


}
