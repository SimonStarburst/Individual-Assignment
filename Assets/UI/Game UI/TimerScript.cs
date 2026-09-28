using UnityEngine;
using TMPro;
using System;

public class TimerScript : MonoBehaviour
{

    private float timerTime;
    [SerializeField] private TextMeshProUGUI timerText;

    private void Start()
    {
        timerTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        timerTime += Time.deltaTime;
        TimeSpan time = TimeSpan.FromSeconds(timerTime);

        // If the timer is less than 1 minute, it shows no minute count. As it reaches 60, it adds he minute counter 
        if (timerTime < 60f)
        {
            timerText.text = time.Seconds.ToString();
        }
        else if (timerTime > 60f)
        {
            timerText.text = time.Minutes.ToString() + " : " + time.Seconds.ToString();
        }
    }
}
