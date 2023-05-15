using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchToLose : MonoBehaviour
{
    private float timeLeft = 180.0f; // set ur desired game time

    private void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
            GameOver();
    }

    private void GameOver()
    {
        SceneManager.LoadScene(2); // it will reload ur scene, probably this will work as a game restart for your project, you should do some better "game ending thingy" tho
    }
}
