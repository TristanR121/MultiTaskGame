using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;



public class startGame : MonoBehaviour
{
    public TextMeshProUGUI countDown;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            StartCoroutine(NextLevelAfterWait());
            countDown.text = "Get Ready! ";
        }
    }

    IEnumerator NextLevelAfterWait()
    {
        yield return new WaitForSeconds(3.0f);

        SceneManager.LoadScene("SampleScene");
    }

    //https://stackoverflow.com/questions/63372547/unity2d-delay-before-scenemanager-loads-the-next-scene
    //Code for Wait

}
