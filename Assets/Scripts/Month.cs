using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Month
{

    public DayEnum startDay;
    public DayEnum endDay;
    public int numDays;
    public string monthName;
    public string year;

    public Month(DayEnum startDay,DayEnum endDay, int numDays, string monthName, string year)
    {
        this.startDay = startDay;
        this.endDay = endDay;
        this.numDays = numDays;
        this.monthName = monthName;
        this.year = year;
    }

    public static readonly Dictionary<DayEnum, int> dayStartOffset
    = new Dictionary<DayEnum, int>
    {
        { DayEnum.Sunday, 0 },
        { DayEnum.Monday, 1},
        { DayEnum.Tuesday, 2},
        { DayEnum.Wednesday, 3},
        { DayEnum.Thursday, 4},
        { DayEnum.Friday, 5},
        { DayEnum.Saturday, 6},
    };
}

public enum DayEnum
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

