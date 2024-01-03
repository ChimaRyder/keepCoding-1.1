using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    private const float SECONDS_PER_INGAME_DAY = 60f; //modify this to depend on GameManager
    private Transform clockHourHandTransform;
    private Transform clockMinuteHandTransform;
    private float day;

    private void Start()
    {
        clockHourHandTransform = transform.Find("clockhand");
        clockMinuteHandTransform = transform.Find("minutehand");
    }

    private void Update()
    {
        day += Time.deltaTime / SECONDS_PER_INGAME_DAY;

        float dayNormalized = day % 1f;
        clockHourHandTransform.eulerAngles = new Vector3(0, 0, -dayNormalized * 360f * 2f);

        float hoursPerDay = 24f;
        clockMinuteHandTransform.eulerAngles = new Vector3(0, 0, -dayNormalized * 360f * hoursPerDay);
    }
}
