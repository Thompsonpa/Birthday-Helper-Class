using System;
using System.Collections.Generic;
using static Calendar_Helper.CreateList;

namespace Calendar_Helper
{
    
    public static class PMTCalendar
    {
 
        public static List<Years> GetYearsList(int yearsback = 100)
        {
            return Year.GetYearList(yearsback);
        }

        public static List<Months> GetMonthList()
        {
            return Month.GetMonthList();
        }

        public static List<Days> GetMonthDayList(int month, int year = 0)
        {
            return Month.GetMonthDayList(month,year);
        }

        public static List<Days> GetMonthDayList(string month, string year = null)
        {
            return Month.GetMonthDayList(Convert.ToInt32(month), Convert.ToInt32(year));
        }

        
     
    }
}
