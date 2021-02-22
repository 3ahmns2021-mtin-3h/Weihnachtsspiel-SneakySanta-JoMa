using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    public float startTime = 60f;
    public Text timer;

    void Update()
    {
        startTime -= Time.deltaTime;

        float minutes = Mathf.FloorToInt(startTime / 60);
        float seconds = Mathf.FloorToInt(startTime % 60);

        if (startTime > 0)
        {
            timer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }

    }
}
