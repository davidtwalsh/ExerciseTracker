using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalendarCreator : MonoBehaviour
{

    private List<Month> allMonths;

    [SerializeField] GameObject CalendarDayPrefab;
    [SerializeField] Transform positionParent;
    [SerializeField] Transform calendarDaysParent;
    [SerializeField] GameObject positionPrefab;
    [SerializeField] TMPro.TextMeshProUGUI monthNameText;

    private CalendarDay selectedCalendarDay = null;

    public static CalendarCreator instance = null;

    private int curMonthIndex = 0;

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

    // Start is called before the first frame update
    void Start()
    {
        allMonths = MonthContainer.GetMonths();
        CreateThisMonthCalendar(allMonths[curMonthIndex]);
    }

    public void SetSelectedCalendarDay(CalendarDay newSelectedDay)
    {
        if (selectedCalendarDay != null)
        {
            selectedCalendarDay.RemoveSelected();
        }
        selectedCalendarDay = newSelectedDay;
        SelectedDayController.instance.UpdateDisplay(newSelectedDay);
    }

    public void AdvanceMonth()
    {
        if (curMonthIndex < allMonths.Count-1)
        {
            curMonthIndex += 1;
            CreateThisMonthCalendar(allMonths[curMonthIndex]);
        }
    }

    public void GoBackMonth()
    {
        if (curMonthIndex > 0)
        {
            curMonthIndex -= 1;
            CreateThisMonthCalendar(allMonths[curMonthIndex]);
        }
    }

    private void ClearCalendar()
    {
        foreach (Transform child in positionParent)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in calendarDaysParent)
        {
            Destroy(child.gameObject);
        }
    }

    private void CreateThisMonthCalendar(Month monthToCreate)
    {
        ClearCalendar();
        monthNameText.text = monthToCreate.monthName;
        List<GameObject> positions = CreatePositions();
        CreateCalendarDays(positions,monthToCreate);
    }

    private List<GameObject> CreatePositions()
    {
        List<GameObject> positions = new List<GameObject>();

        float startX = -360f;
        float startY = 600f;

        int counter = 0;
        for (int y = 0; y < 6; y++)
        {
            for (int x = 0; x < 7; x++)
            {
                Vector3 pos = new Vector3(startX + x * 120f, startY + y * -120f);
                //GameObject obj = new GameObject($"Position: {x * (y + 1)}");
                GameObject obj = Instantiate(positionPrefab);
                obj.name = $"Position: {counter}";
                counter += 1;
                obj.transform.parent = positionParent;
                RectTransform rect = obj.GetComponent<RectTransform>();
                rect.anchoredPosition = pos;

                positions.Add(obj);
            }
        }
        return positions;
    }

    private void CreateCalendarDays(List<GameObject> positions,Month thisMonth)
    {
        int startIndex = Month.dayStartOffset[thisMonth.startDay];
        int curDay = 1;
        for (int i = startIndex; i < thisMonth.numDays + startIndex; i++)
        {
            GameObject day = Instantiate(CalendarDayPrefab, calendarDaysParent);
            GameObject curPosition = positions[i];
            day.GetComponent<RectTransform>().anchoredPosition = curPosition.GetComponent<RectTransform>().anchoredPosition;
            day.name = $"CalendarDay {curDay}";

            CalendarDay calDay = day.GetComponent<CalendarDay>();
            calDay.SetDay(curDay);
            calDay.SetMonth(thisMonth.monthName);
            calDay.SetYear(thisMonth.year);

            curDay += 1;
        }
    }
}
