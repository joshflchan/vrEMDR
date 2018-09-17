﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractiveButton : MonoBehaviour
{
    private bool isLooking = false;
    private float timeLeft = 3.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isLooking)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft <= 0)
            {
                SceneManager.LoadScene("BLS", LoadSceneMode.Single);
            }
        }
        else
        {
            timeLeft = 3.0f;
        }
    }

    public void OnGazeEnter()
    {
        isLooking = true;
    }

    public void OnGazeExit()
    {
        isLooking = false;
    }
}