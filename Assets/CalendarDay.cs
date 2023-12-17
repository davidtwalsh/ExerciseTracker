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

    public void SetDay(int dayNumber)
    {
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
}
