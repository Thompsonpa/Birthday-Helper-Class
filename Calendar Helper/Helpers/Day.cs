using System;
using System.Collections.Generic;
using static Calendar_Helper.CreateList;

namespace Calendar_Helper
{
    internal static class Day
    {
        internal static List<Days> GetDayList()
        {
            List<Days> DayList = new List<Days>();

            for (int i = 1; i <= 31; i++)
            {
                    DayList.Add(new Days() { Value = i, Name = i.ToString() });
            }
            return DayList;
        }

        internal static List<Days> GetMonthDayList(int month, int year)
        {
            List<Days> DayList = new List<Days>();

            int Days = DateTime.DaysInMonth(year, month);

            for (int i = 1; i <= Days; i++)
            {
                DayList.Add(new Days() { Value = i, Name = i.ToString() });
            }
            return DayList;
        }

    }
}
