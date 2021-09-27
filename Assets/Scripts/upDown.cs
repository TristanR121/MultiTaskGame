using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upDown : MonoBehaviour
{

    private Rigidbody2D rbPattle;
    public float speed = 8.0f;
    public float boundOne = -1f;
    public float boundTwo = -3.75f;

    // Start is called before the first frame update
    void Start()
    {
        rbPattle = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // move left and right
        //if (Input.GetKey(KeyCode.W))
        //{
          //  rbPattle.velocity = new Vector2(0, speed);
        //}
        if (Input.GetKey(KeyCode.S))
        {
            rbPattle.velocity = new Vector2(0, -speed);
        }
        else
        {
            rbPattle.velocity = new Vector2(0, speed);
        }

        if (transform.position.y > boundOne)
        {
            transform.position = new Vector3(transform.position.x, boundOne, 0);
        }
        else if (transform.position.y < boundTwo)
        {
            transform.position = new Vector3(transform.position.x, boundTwo, 0);
        }
        transform.position = transform.position;
    }
}
