using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxMove : MonoBehaviour
{

    private Rigidbody2D rbPattle;
    public float speed = 8.0f;

    // Start is called before the first frame update
    void Start()
    {
        rbPattle = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rbPattle.velocity = new Vector2(0, speed);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rbPattle.velocity = new Vector2(0, -speed);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rbPattle.velocity = new Vector2(-speed, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rbPattle.velocity = new Vector2(speed, 0);
        }
        else
        {
            rbPattle.velocity = new Vector2(0, 0);
        }
    }
}
