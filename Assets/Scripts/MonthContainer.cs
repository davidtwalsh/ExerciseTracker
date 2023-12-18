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
        months.Add(new Month(DayEnum.Friday, DayEnum.Sunday, 31, MonthNames.december, "2023"));

        months.Add(new Month(DayEnum.Monday, DayEnum.Wednesday, 31, MonthNames.january, "2024"));
        months.Add(new Month(DayEnum.Thursday, DayEnum.Thursday, 29, MonthNames.february, "2024"));
        months.Add(new Month(DayEnum.Friday, DayEnum.Sunday, 31, MonthNames.march, "2024"));
        months.Add(new Month(DayEnum.Monday, DayEnum.Tuesday, 30, MonthNames.april, "2024"));
        months.Add(new Month(DayEnum.Wednesday, DayEnum.Friday,31 , MonthNames.may, "2024"));
        months.Add(new Month(DayEnum.Saturday, DayEnum.Sunday,30 , MonthNames.june, "2024"));
        months.Add(new Month(DayEnum.Monday, DayEnum.Wednesday, 31 , MonthNames.july, "2024"));
        months.Add(new Month(DayEnum.Thursday, DayEnum.Saturday, 31, MonthNames.august, "2024"));
        months.Add(new Month(DayEnum.Sunday, DayEnum.Monday,30 , MonthNames.september, "2024"));
        months.Add(new Month(DayEnum.Tuesday, DayEnum.Thursday, 31, MonthNames.october, "2024"));
        months.Add(new Month(DayEnum.Friday, DayEnum.Saturday,30 , MonthNames.november, "2024"));
        months.Add(new Month(DayEnum.Sunday, DayEnum.Tuesday,31 , MonthNames.december, "2024"));

        months.Add(new Month(DayEnum.Wednesday, DayEnum.Friday,31 , MonthNames.january, "2025"));
        months.Add(new Month(DayEnum.Saturday, DayEnum.Friday,28 , MonthNames.february, "2025"));
        months.Add(new Month(DayEnum.Saturday, DayEnum.Monday,31 , MonthNames.march, "2025"));
        months.Add(new Month(DayEnum.Tuesday, DayEnum.Wednesday,30 , MonthNames.april, "2025"));
        months.Add(new Month(DayEnum.Thursday, DayEnum.Saturday,31 , MonthNames.may, "2025"));
        months.Add(new Month(DayEnum.Sunday, DayEnum.Monday,30 , MonthNames.june, "2025"));
        months.Add(new Month(DayEnum.Tuesday, DayEnum.Thursday,31 , MonthNames.july, "2025"));
        months.Add(new Month(DayEnum.Friday, DayEnum.Sunday,31 , MonthNames.august, "2025"));
        months.Add(new Month(DayEnum.Monday, DayEnum.Tuesday,30 , MonthNames.september, "2025"));
        months.Add(new Month(DayEnum.Wednesday, DayEnum.Friday,31 , MonthNames.october, "2025"));
        months.Add(new Month(DayEnum.Saturday, DayEnum.Sunday,30 , MonthNames.november, "2025"));
        months.Add(new Month(DayEnum.Monday, DayEnum.Wednesday,31 , MonthNames.december, "2025"));
    }
}
