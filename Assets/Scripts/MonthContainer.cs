using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MonthContainer 
{
    private static List<Month> months;

    public static List<Month> GetMonths()
    {
        if (months == null)
        {
            InitMonths();
        }
        return months;
    }

    private static void InitMonths()
    {
        months = new List<Month>();
        months.Add(new Month(Day.Friday, Day.Sunday, 31, "December", "2023"));
        months.Add(new Month(Day.Monday, Day.Wednesday, 31, "January", "2024"));
        months.Add(new Month(Day.Thursday, Day.Thursday, 29, "February", "2024"));
        months.Add(new Month(Day.Friday, Day.Sunday, 31, "March", "2024"));
    }
}
