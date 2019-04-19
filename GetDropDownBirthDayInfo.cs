using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Written By Thermalnuke (https://github.com/Thermalnuke)
/// Helper class to Return List of Month Days, List of Months, List of Years (Past 100 Years)
/// Useful with Web Form requesting Birthday info from user
/// </summary>
public class GetDropDownBirthDayInfo
{

    public List<BirthYears> GetBirthYearList()
    {
        List<BirthYears> YearList = new List<BirthYears>();
        //Need to loop to get 100 years in to a selectable list, Just do a 100 to be safe
        DateTime CurrentDate = DateTime.Now;
        YearList.Add(new BirthYears() { Value = 00, Name = "Select a Birth Year" });
        for (int i = CurrentDate.Year ; i > CurrentDate.AddYears(-100).Year; i--)
        {
            YearList.Add(new BirthYears() { Value = i, Name = i.ToString() });
        }
        return YearList;
    }

    public List<BirthMonths> GetBirthMonthList()
    {
        List<BirthMonths> MonthsList = new List<BirthMonths>();
        MonthsList.Add(new BirthMonths() { Value = 00, Name = "Select a Birth Month" });
        MonthsList.Add(new BirthMonths() { Value = 01, Name = "January" });
        MonthsList.Add(new BirthMonths() { Value = 02, Name = "February" });
        MonthsList.Add(new BirthMonths() { Value = 03, Name = "March" });
        MonthsList.Add(new BirthMonths() { Value = 04, Name = "April" });
        MonthsList.Add(new BirthMonths() { Value = 05, Name = "May" });
        MonthsList.Add(new BirthMonths() { Value = 06, Name = "June" });
        MonthsList.Add(new BirthMonths() { Value = 07, Name = "July" });
        MonthsList.Add(new BirthMonths() { Value = 08, Name = "August" });
        MonthsList.Add(new BirthMonths() { Value = 09, Name = "September" });
        MonthsList.Add(new BirthMonths() { Value = 10, Name = "October" });
        MonthsList.Add(new BirthMonths() { Value = 11, Name = "November" });
        MonthsList.Add(new BirthMonths() { Value = 12, Name = "December" });
        return MonthsList;
    }

    public List<BirthDays> GetBirthDayList()
    {
        List<BirthDays> DayList = new List<BirthDays>();
        DayList.Add(new BirthDays() { Value = 00, Name = "Select a Birth Day" });
        DayList.Add(new BirthDays() { Value = 01, Name = "01" });
        DayList.Add(new BirthDays() { Value = 02, Name = "02" });
        DayList.Add(new BirthDays() { Value = 03, Name = "03" });
        DayList.Add(new BirthDays() { Value = 04, Name = "04" });
        DayList.Add(new BirthDays() { Value = 05, Name = "05" });
        DayList.Add(new BirthDays() { Value = 06, Name = "06" });
        DayList.Add(new BirthDays() { Value = 07, Name = "07" });
        DayList.Add(new BirthDays() { Value = 08, Name = "08" });
        DayList.Add(new BirthDays() { Value = 09, Name = "09" });
        DayList.Add(new BirthDays() { Value = 10, Name = "10" });
        DayList.Add(new BirthDays() { Value = 11, Name = "11" });
        DayList.Add(new BirthDays() { Value = 12, Name = "12" });
        DayList.Add(new BirthDays() { Value = 13, Name = "13" });
        DayList.Add(new BirthDays() { Value = 14, Name = "14" });
        DayList.Add(new BirthDays() { Value = 15, Name = "15" });
        DayList.Add(new BirthDays() { Value = 16, Name = "16" });
        DayList.Add(new BirthDays() { Value = 17, Name = "17" });
        DayList.Add(new BirthDays() { Value = 18, Name = "18" });
        DayList.Add(new BirthDays() { Value = 19, Name = "19" });
        DayList.Add(new BirthDays() { Value = 20, Name = "20" });
        DayList.Add(new BirthDays() { Value = 21, Name = "21" });
        DayList.Add(new BirthDays() { Value = 22, Name = "22" });
        DayList.Add(new BirthDays() { Value = 23, Name = "23" });
        DayList.Add(new BirthDays() { Value = 24, Name = "24" });
        DayList.Add(new BirthDays() { Value = 25, Name = "25" });
        DayList.Add(new BirthDays() { Value = 26, Name = "26" });
        DayList.Add(new BirthDays() { Value = 27, Name = "27" });
        DayList.Add(new BirthDays() { Value = 28, Name = "28" });
        DayList.Add(new BirthDays() { Value = 29, Name = "29" });
        DayList.Add(new BirthDays() { Value = 30, Name = "30" });
        DayList.Add(new BirthDays() { Value = 31, Name = "31" });
        return DayList;
    }

    public class BirthYears
    {
        public int Value { get; set; }
        public string Name { get; set; }
    }

    public class BirthMonths
    {
        public int Value { get; set; }
        public string Name { get; set; }
    }

    public class BirthDays
    {
        public int Value { get; set; }
        public string Name { get; set; }
    }

}
