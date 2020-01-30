using System;
using System.Collections.Generic;
using System.Text;
using static Calendar_Helper.ListObjects;

namespace Calendar_Helper
{
    public static class Day
    {

        public static List<Days> GetDayList()
        {
            List<Days> DayList = new List<Days>();
            DayList.Add(new Days() { Value = 00, Name = "Select a Day" });
            for (int i = 1; i <= 31; i++)
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
