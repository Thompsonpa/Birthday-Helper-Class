using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Calendar_Helper.ListObjects;

namespace Calendar_Helper
{
    
    public class Calendar
    {
 
        public List<Years> GetYearsList(int YearsBack)
        {
            return Year.GetYearList(YearsBack);
        }

        public List<Months> GetMonthList()
        {
            return Month.GetMonthList();
        }

        public List<Days> GetMonthDayList(int month, int year = 0)
        {
            return Month.GetMonthDayList(month,year);
        }

        public List<Days> GetMonthDayList(string month, string year = null)
        {
            return Month.GetMonthDayList(Convert.ToInt32(month), Convert.ToInt32(year));
        }

        
     
    }
}
