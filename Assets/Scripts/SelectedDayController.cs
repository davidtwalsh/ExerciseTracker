using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedDayController : MonoBehaviour
{
    public static SelectedDayController instance;

    [SerializeField] TMPro.TextMeshProUGUI dateText;
    [SerializeField] TMPro.TextMeshProUGUI timeText;

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

    public void UpdateDisplay(CalendarDay newSelectedDay)
    {
        dateText.text = $"{newSelectedDay.month} {newSelectedDay.day}, {newSelectedDay.year}";
        UpdateDisplay(newSelectedDay.GetHours());
    }

    public void UpdateDisplay(float f)
    {
        timeText.text = $"Time spent: {f} hours";
    }
}
