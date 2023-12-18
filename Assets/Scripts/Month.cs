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

public class Date
{
    public string month;
    public string day;
    public string year;

    public Date(string month, string day, string year)
    {
        this.month = month;
        this.day = day;
        this.year = year;
    }

    public static readonly Dictionary<string, string> monthNumberToName
= new Dictionary<string, string>
{
        { "1", MonthNames.january },
        { "2", MonthNames.february },
        { "3", MonthNames.march },
        { "4", MonthNames.april },
        { "5", MonthNames.may },
        { "6", MonthNames.june },
        { "7", MonthNames.july },
        { "8", MonthNames.august },
        { "9", MonthNames.september },
        { "10", MonthNames.october },
        { "11", MonthNames.november },
        { "12", MonthNames.december }
};
}

public class MonthNames
{
    public static string january = "January";
    public static string february = "February";
    public static string march = "March";
    public static string april = "April";
    public static string may = "May";
    public static string june = "June";
    public static string july = "July";
    public static string august = "August";
    public static string september = "September";
    public static string october = "October";
    public static string november = "November";
    public static string december = "December";
}

