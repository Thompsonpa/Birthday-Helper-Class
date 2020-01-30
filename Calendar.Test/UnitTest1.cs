using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calendar_Helper;
using System.Collections.Generic;
using System.Linq;

namespace Calendar.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCreatingLists()
        {
            //Create custom manually list or add value to generated list
            List<CreateList.Years> years = new List<CreateList.Years>();
            List<CreateList.Months> months = new List<CreateList.Months>();
            List<CreateList.Days> days = new List<CreateList.Days>();
            days.Add(new CreateList.Days() { Name = "Test", Value = 0 });
            months.Add(new CreateList.Months() { Name="Test", Value = 0});
            years.Add(new CreateList.Years() { Name = "Test", Value = 0 });
        }

        [TestMethod]
        public void TestGetListofMonths()
        {
            var test = PMTCalendar.GetMonthList();
            foreach (var t in test)
            {
                Console.WriteLine(t.Name + " : " + t.Value);
            }
        }

        [TestMethod]
        public void TestGetMonthDayList()
        {
            var January = PMTCalendar.GetMonthDayList(1,2020);
            var Febuary = PMTCalendar.GetMonthDayList(2, 2020);
            var March = PMTCalendar.GetMonthDayList(3, 2020);
            var April = PMTCalendar.GetMonthDayList(4, 2020);
            var May = PMTCalendar.GetMonthDayList(5, 2020);
            var June = PMTCalendar.GetMonthDayList(6, 2020);
            var July = PMTCalendar.GetMonthDayList(7, 2020);
            var August = PMTCalendar.GetMonthDayList(8, 2020);
            var September = PMTCalendar.GetMonthDayList(9, 2020);
            var October = PMTCalendar.GetMonthDayList(10, 2020);
            var November = PMTCalendar.GetMonthDayList(11, 2020);
            var December = PMTCalendar.GetMonthDayList(12, 2020);

            Console.WriteLine(January.Count(x => x.Value != 0));
            Console.WriteLine(Febuary.Count(x => x.Value != 0));
            Console.WriteLine(March.Count(x => x.Value != 0));
            Console.WriteLine(April.Count(x => x.Value != 0));
            Console.WriteLine(May.Count(x => x.Value != 0));
            Console.WriteLine(June.Count(x => x.Value != 0));
            Console.WriteLine(July.Count(x => x.Value != 0));
            Console.WriteLine(August.Count(x => x.Value != 0));
            Console.WriteLine(September.Count(x => x.Value != 0));
            Console.WriteLine(October.Count(x => x.Value != 0));
            Console.WriteLine(November.Count(x => x.Value != 0));
            Console.WriteLine(December.Count(x => x.Value != 0));

        }

    }
}
