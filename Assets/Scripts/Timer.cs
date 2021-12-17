using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 60f;
    private string timerPrefix = "Timer: ";

    [SerializeField] TMP_Text countdownText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = secondsToClockDisplay(currentTime);
        //print(currentTime); // Testing

        if (currentTime <= 0)
        {
            countdownText.color = Color.red;
            currentTime = 0;
        }
    }

    private string secondsToClockDisplay(float time) {
        float minutes = Mathf.Floor(time / 60);
        float seconds = Mathf.RoundToInt(time % 60);
        return timerPrefix + minutes + ":" + seconds;
    }
}