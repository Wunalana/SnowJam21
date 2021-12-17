using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    private string timerPrefix = "Timer: ";
    public static float currentTime = 0f;
    public static float startingTime = 60f;

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
            Application.LoadLevel("Simon_EndScreen");
        }

    }

    private string secondsToClockDisplay(float time) {
        float minutes = Mathf.Floor(time / 60);
        float seconds = Mathf.RoundToInt(time % 60);
        return timerPrefix + minutes + ":" + seconds;
    }
}