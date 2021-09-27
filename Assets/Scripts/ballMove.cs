using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMove : MonoBehaviour
{
    private Rigidbody2D rbBall;

    // Start is called before the first frame update
    void Start()
    {
        rbBall = GetComponent<Rigidbody2D>();
        moveBall();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void moveBall()
    {
        float random = Random.Range(0, 2);
        if(random < 1)
        {
            rbBall.AddForce(new Vector2(15, -10));
        }
        else
        {
            rbBall.AddForce(new Vector2(-15, 10));
        }
    }

    
}
