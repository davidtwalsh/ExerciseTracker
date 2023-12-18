using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTimeController : MonoBehaviour
{
    [SerializeField] TMPro.TextMeshProUGUI timeToAddText;
    private float curTimeToAdd = 0f;
    private float newTimeToAddGoal = 0f;

    public static AddTimeController instance = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddTime(float time)
    {
        newTimeToAddGoal += time;
        newTimeToAddGoal = Mathf.Max(0, newTimeToAddGoal);
        StopAllCoroutines();
        StartCoroutine(GetToNewTime());
    }

    IEnumerator GetToNewTime()
    {
        string formattedTime = "";
        while (Mathf.Abs(curTimeToAdd - newTimeToAddGoal) > .01f)
        {
            float difToAdd = (newTimeToAddGoal - curTimeToAdd) / 5f;
            curTimeToAdd += difToAdd;

            formattedTime = curTimeToAdd.ToString("0.00"); //2dp Number
            timeToAddText.text = "Time to add: " + formattedTime;
            yield return new WaitForSeconds(.001f);
        }
        curTimeToAdd = newTimeToAddGoal;
        formattedTime = curTimeToAdd.ToString("0.00"); //2dp Number
        timeToAddText.text = "Time to add: " + formattedTime;
    }


    public void AddNewTimeToDay()
    {
        CalendarCreator.instance.selectedCalendarDay.AddHours(curTimeToAdd);
        CalendarCreator.instance.UpdateCurrentCalendarDay();
        ResetTimeToAdd();
        
    }

    public void ResetTimeToAdd()
    {
        StopAllCoroutines();
        curTimeToAdd = 0;
        newTimeToAddGoal = 0;
        StartCoroutine(GetToNewTime());
    }

}
