using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PattleMove : MonoBehaviour
{

    private Rigidbody2D rbPattle;
    public float speed = 8.0f;
    public float boundOne = -1.5f;
    public float boundTwo = -8.5f;


    // Start is called before the first frame update
    void Start()
    {
        rbPattle = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        // move left and right
        if (Input.GetKey(KeyCode.A))
        {
            rbPattle.velocity = new Vector2(-speed, 0);
        } 
        else if (Input.GetKey(KeyCode.D))
        {
            rbPattle.velocity = new Vector2(speed, 0);
        }
        else
        {
            rbPattle.velocity = new Vector2(0, 0);
        }
        // bounds
        if (transform.position.x > boundOne)
        {
            transform.position = new Vector3(boundOne, transform.position.y, 0);
        }
        else if (transform.position.x < boundTwo)
        {
            transform.position = new Vector3(boundTwo, transform.position.y, 0);
        }
        transform.position = transform.position;

    }
}
