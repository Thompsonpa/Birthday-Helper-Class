using System;
using System.Collections.Generic;
using static Calendar_Helper.CreateList;

namespace Calendar_Helper
{
    
    public static class PMTCalendar
    {
 
        public static List<Months> GetMonthList()
        {
            return Month.GetMonthList();
        }

        public static List<Years> GetYearsList(int yearsback = 100)
        {
            return Year.GetYearList(yearsback);
        }

        public static List<Years> GetYearsList(string yearsback = "100")
        {
            int iYearsBack = Convert.ToInt32(yearsback);

            return Year.GetYearList(iYearsBack);
        }

        public static List<Days> GetMonthDayList(int month, int year = 0)
        {
            if (year == 0){year = DateTime.Now.Year;}

            int iMonth = month;
            int iYear = year;

            return Day.GetMonthDayList(iMonth, iYear);
        }

        public static List<Days> GetMonthDayList(string month, string year = null)
        {
            if (year == null){year = DateTime.Now.Year.ToString();}

            int iMonth = Convert.ToInt32(month);
            int iYear = Convert.ToInt32(year);

            return Day.GetMonthDayList(iMonth, iYear);
        }
  
    }
}
