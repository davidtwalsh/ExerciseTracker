using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Month
{

    private Day startDay;
    private Day endDay;
    private int numDays;
    private string monthName;
    private string year;

    public Month(Day startDay,Day endDay, int numDays, string monthName, string year)
    {
        this.startDay = startDay;
        this.endDay = endDay;
        this.numDays = numDays;
        this.monthName = monthName;
        this.year = year;
    }
}

public enum Day
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}