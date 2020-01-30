using System;
using System.Collections.Generic;
using System.Text;
using static Calendar_Helper.CreateList;

namespace Calendar_Helper
{
    internal static class Year
    {
        internal static List<Years> GetYearList(int YearsBack)
        {
            List<Years> YearList = new List<Years>();
            //Need to loop to get years Passed in to this class a selectable list
            DateTime CurrentDate = DateTime.Now;
            YearList.Add(new Years() { Value = 00, Name = "Select a Year" });
            for (int i = CurrentDate.Year; i > CurrentDate.AddYears(-YearsBack).Year; i--)
            {
                YearList.Add(new Years() { Value = i, Name = i.ToString() });
            }
            return YearList;
        }
    }
}
