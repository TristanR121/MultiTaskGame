using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject ballpref;
    public float spawnRate = 3;
    float spawnTime;

    // Start is called before the first frame update
    void Start()
    {
        spawnTime = spawnRate;

    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTime < 0)
        {
            GameObject newBall = Instantiate(ballpref);
            newBall.transform.position = transform.position;
            spawnTime = spawnRate;
        }

        spawnTime -= Time.deltaTime;
    }
}
