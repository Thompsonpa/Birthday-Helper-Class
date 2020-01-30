using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using static Calendar_Helper.CreateList;

namespace Calendar_Helper
{
    internal static class Month
    {
        internal static List<Months> GetMonthList()
        {
            // Create a new Month list
            List<Months> MonthsList = new List<Months>();
            // Add Default Value for list
            MonthsList.Add(new Months() { Value = 00, Name = "Select a Month" });
            //Loop through months and create list
            for (int i = 1; i <= 12; i++)
            {
                // Get month name by the loop value passed in as the month. year or day does not matter..
                string monthname = new DateTime(DateTime.Now.Year, i, 1).ToString("MMMM", CultureInfo.InvariantCulture);
                // Add monthname and month value to list
                MonthsList.Add(new Months() { Value = 0 + i, Name = char.ToUpper(monthname[0]).ToString() + monthname.Substring(1) });
            }
            // Return Month List
            return MonthsList;
        }
    }
}
