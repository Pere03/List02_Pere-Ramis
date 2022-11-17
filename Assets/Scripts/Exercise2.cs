using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Exercise2 : MonoBehaviour
{
    public Image bar;
    public TextMeshProUGUI timer;
    public float timeValue;
    public float maxTime;
    private bool startCount;

    void Start()
    {
        maxTime = timeValue;
        startCount = false;
    }

    void Update()
    {
        //With this we do that if the boolean that we have done is activated and the time is not 0, it subtracts the time to the value we have set, until it reaches 0
        if (startCount == true & timeValue > 0)
        {
            if (timeValue > 0)
            {
                timeValue -= Time.deltaTime;
                bar.fillAmount = timeValue / maxTime;
            }
            else
            {
                timeValue = 0;
            }
        }
        DisplayTime(timeValue);

        //This causes the bar to change color as it decreases
        if (bar.fillAmount <= 1 & bar.fillAmount >= 0.5)
        {
            bar.color = new Color32(14,255,0,255);
        } 
            else if (bar.fillAmount <= 0.5 & bar.fillAmount >= 0.2)
            {
              bar.color = new Color32(249, 255, 0, 255);
            }
                else if (bar.fillAmount <= 0.2 & bar.fillAmount >= 0)
                {
                   bar.color = new Color32(255,0,0,255);
                }
    }

    //This causes the boolean to become active, and the timer function starts
    public void Start_Timer()
    {
        startCount = true;
        timeValue = maxTime;
    }

    //With this we make the value of the time be displayed in Hours, Minutes and Seconds, through a text
    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        float milliseconds = timeToDisplay % 1 * 1000;

        timer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
