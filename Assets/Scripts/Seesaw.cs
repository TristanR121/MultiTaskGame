using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seesaw : MonoBehaviour
{
    public Vector3 point; //position of the point you want to rotate around

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftShift)) 
        {
            transform.RotateAround(point, Vector3.forward, 20 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightShift))
        {
            transform.RotateAround(point, -Vector3.forward, 20 * Time.deltaTime);
        }

    }
}
