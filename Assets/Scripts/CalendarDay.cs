using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CalendarDay : MonoBehaviour
{
    [SerializeField] TMPro.TextMeshProUGUI dayNumberText;
    [SerializeField] Color normalColor;
    [SerializeField] Color selectedColor;
    [SerializeField] Image buttonImage;
    [SerializeField] TMPro.TextMeshProUGUI hoursText;
    [SerializeField] Gradient gradient;

    public int day;
    public string month;
    public string year;

    private float hours = 0f;
    private readonly float maxHours = 4f;

    void Start()
    {
        //hours = GetRandomHours();
        UpdateHoursText();
    }

    public void UpdateHoursText()
    {
        hoursText.text = hours.ToString();

        Color c = gradient.Evaluate(hours / maxHours);
        hoursText.color = c;
        //SetSelected();
    }

    public void SetHours(float f)
    {
        hours = f;
        UpdateHoursText();
    }

    public float GetHours()
    {
        return hours;
    }

    public void AddHours(float f)
    {
        hours = Mathf.Max(0, hours + f);
        UpdateHoursText();
    }

    public void SetYear(string year)
    {
        this.year = year;
    }

    public void SetMonth(string month)
    {
        this.month = month;
    }

    public void SetDay(int dayNumber)
    {
        day = dayNumber;
        dayNumberText.text = dayNumber.ToString();
    }

    public void SetSelected()
    {
        buttonImage.color = selectedColor;
        CalendarCreator.instance.SetSelectedCalendarDay(this);
    }

    public void RemoveSelected()
    {
        buttonImage.color = normalColor;
    }

    private float GetRandomHours()
    {
        float[] myNum = { 0f, .25f, .5f, 1f, 1.75f, 2.5f, 3f, 3.25f, 3.5f, 4f };

        int randomIndex = UnityEngine.Random.Range(0, myNum.Length-1);
        return myNum[randomIndex];
    }
}
