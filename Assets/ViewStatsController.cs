using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewStatsController : MonoBehaviour
{
    [SerializeField] TMPro.TextMeshProUGUI totalTimeButtonText;

    private float GetTotalTime()
    {
        float totalTime = 0f;
        foreach (KeyValuePair<string, float> entry in CalendarCreator.instance.dl.dateToHours)
        {
            totalTime += entry.Value;
        }
        return totalTime;
    }

    public void ShowTotalTime()
    {
        totalTimeButtonText.text = GetTotalTime() + " hours";
    }
}
