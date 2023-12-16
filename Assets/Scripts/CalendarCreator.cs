using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalendarCreator : MonoBehaviour
{

    private List<Month> allMonths;
    private int thisDayOfMonth;

    [SerializeField] GameObject CalendarDayPrefab;
    [SerializeField] Transform positionParent;
    [SerializeField] GameObject positionPrefab;

    // Start is called before the first frame update
    void Start()
    {
        allMonths = MonthContainer.GetMonths();
        CreateThisMonthCalendar(allMonths[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CreateThisMonthCalendar(Month monthToCreate)
    {
        //GameObject obj = Instantiate(CalendarDayPrefab, this.transform);
        //obj.transform.position = startPosition.transform.position;
        //RectTransform rect = obj.GetComponent<RectTransform>();
        //rect.anchoredPosition = startPosition.anchoredPosition;

        List<GameObject> positions = CreatePositions();
        CreateCalendarDays(positions);
    }

    private List<GameObject> CreatePositions()
    {
        List<GameObject> positions = new List<GameObject>();

        float startX = -350f;
        float startY = 750f;

        int counter = 0;
        for (int y = 0; y < 5; y++)
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

    private void CreateCalendarDays(List<GameObject> positions)
    {

        foreach (GameObject obj in positions)
        {
            GameObject day = Instantiate(CalendarDayPrefab,transform);
            day.GetComponent<RectTransform>().anchoredPosition = obj.GetComponent<RectTransform>().anchoredPosition;
        }
    }
}
