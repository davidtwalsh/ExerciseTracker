using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTimeController : MonoBehaviour
{
    [SerializeField] TMPro.TextMeshProUGUI timeToAddText;
    private float curTimeToAdd = 0f;
    private float newTimeToAddGoal = 0f;

    public void AddTime(float time)
    {
        newTimeToAddGoal += time;
        StopAllCoroutines();
        StartCoroutine(GetToNewTime());
    }

    IEnumerator GetToNewTime()
    {
        string formattedTime = "";
        while (Mathf.Abs(curTimeToAdd - newTimeToAddGoal) > .01f)
        {
            float difToAdd = (newTimeToAddGoal - curTimeToAdd) / 10f;
            curTimeToAdd += difToAdd;

            formattedTime = curTimeToAdd.ToString("0.00"); //2dp Number
            timeToAddText.text = "Time to add: " + formattedTime;
            yield return new WaitForSeconds(.01f);
        }
        curTimeToAdd = newTimeToAddGoal;
        formattedTime = curTimeToAdd.ToString("0.00"); //2dp Number
        timeToAddText.text = "Time to add: " + formattedTime;
    }

}
