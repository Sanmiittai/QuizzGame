using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToComplete = 30f;
    [SerializeField] float timeToShow = 10f;
    public bool isAnsweringQuestion;
    public bool loadNextQuestion;
    public float fillFraction;
    float timerValue;

    void Update()
    {
        UpdateTimer();
    }

    public void CancelTimer()
    {
        timerValue = 0;
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;

        if(isAnsweringQuestion)
        {
            if(timerValue > 0)
            {
                fillFraction = timerValue / timeToComplete;
            }
            else
            {
               isAnsweringQuestion = false;
               timerValue = timeToShow;
            }
        }
        else
        {
            if(timerValue > 0)
            {
                fillFraction = timerValue / timeToShow;
            }
            else
            {
                isAnsweringQuestion = true;
                timerValue = timeToComplete;
                loadNextQuestion = true;
            }
        }
    }
}
