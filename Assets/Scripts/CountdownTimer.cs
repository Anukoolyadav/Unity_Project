using UnityEngine;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    public float startTime = 10f;   // seconds
    private float timeRemaining;
    private bool timerRunning = true;

    TMP_Text timerText;

    void Awake()
    {
        timerText = GetComponent<TMP_Text>();
        timeRemaining = startTime;
    }

    void Update()
    {
        if (!timerRunning) return;

        timeRemaining -= Time.deltaTime;

        if (timeRemaining > 0)
        {
            timerText.text = Mathf.Ceil(timeRemaining).ToString();
        }
        else
        {
            timeRemaining = 0;
            timerRunning = false;
            timerText.text = "Thank You!";
        }
    }
}
