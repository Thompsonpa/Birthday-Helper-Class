using System;
using System.Collections.Generic;
using System.Text;
using static Calendar_Helper.ListObjects;

namespace Calendar_Helper
{
    public static class Month
    {
        public static List<Months> GetMonthList()
        {
            List<Months> MonthsList = new List<Months>();
            //Loop through months and create list
            MonthsList.Add(new Months() { Value = 00, Name = "Select a Month" });
            MonthsList.Add(new Months() { Value = 01, Name = "January" });
            MonthsList.Add(new Months() { Value = 02, Name = "February" });
            MonthsList.Add(new Months() { Value = 03, Name = "March" });
            MonthsList.Add(new Months() { Value = 04, Name = "April" });
            MonthsList.Add(new Months() { Value = 05, Name = "May" });
            MonthsList.Add(new Months() { Value = 06, Name = "June" });
            MonthsList.Add(new Months() { Value = 07, Name = "July" });
            MonthsList.Add(new Months() { Value = 08, Name = "August" });
            MonthsList.Add(new Months() { Value = 09, Name = "September" });
            MonthsList.Add(new Months() { Value = 10, Name = "October" });
            MonthsList.Add(new Months() { Value = 11, Name = "November" });
            MonthsList.Add(new Months() { Value = 12, Name = "December" });
            return MonthsList;
        }

        public static List<Days> GetMonthDayList(int month, int year)
        {
            List<Days> DayList = new List<Days>();
            DayList.Add(new Days() { Value = 00, Name = "Select a Day" });

            int Days = DateTime.DaysInMonth(year, month);
            
            for (int i = 1; i <= Days; i++)
            {
                if (i.ToString().Length <= 1)
                {
                    DayList.Add(new Days() { Value = i, Name = "0" + i.ToString() });
                }
                else
                {
                    DayList.Add(new Days() { Value = i, Name = i.ToString() });
                }
            }
            return DayList;
        }
    }
}
