using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class RemainingTime : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI time;
    [SerializeField] GameObject woody;
    [SerializeField] SoundManager manager;
    float startTime;
    private int isRunning = 1;

    void Start()
    {
        startTime = 60;
        time.SetText("1:00");
    }

    void Update()
    {
        if (isRunning == 1)
        {
            StartCoroutine(Timer());
        }
            
    }

    public IEnumerator Timer()
    {

        isRunning = 0;
        yield return new WaitForSeconds(1);
            if (startTime > 0)
            {
                startTime--;
                time.SetText("0: " + startTime);
                if (startTime < 10)
                {
                    time.SetText("0:0" + startTime);
                }
                if (startTime == 0)
                {
                    manager.PlayerSounds("gameOver");
                    Time.timeScale = 0;
                    woody.GetComponent<PlayerMovement>().end = true;
                }
            }
        isRunning = 1;
    }
}
