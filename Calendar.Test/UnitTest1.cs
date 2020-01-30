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

            days.Add(new CreateList.Days() { Name = "Test0", Value = 0 });
            months.Add(new CreateList.Months() { Name="Test1", Value = 1});
            years.Add(new CreateList.Years() { Name = "Test2", Value = 2 });

            Console.WriteLine(days[0].Name.ToString() + " : " + days[0].Value.ToString());
            Console.WriteLine(months[0].Name.ToString() + " : " + months[0].Value.ToString());
            Console.WriteLine(years[0].Name.ToString() + " : " + years[0].Value.ToString());
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

            Console.WriteLine("January: " + January.Count());
            Console.WriteLine("Febuary: " + Febuary.Count());
            Console.WriteLine("March: " + March.Count());
            Console.WriteLine("April: " + April.Count());
            Console.WriteLine("May: " + May.Count());
            Console.WriteLine("June: " + June.Count());
            Console.WriteLine("July: " + July.Count());
            Console.WriteLine("August: " + August.Count());
            Console.WriteLine("September: " + September.Count());
            Console.WriteLine("October: " + October.Count());
            Console.WriteLine("November: " + November.Count());
            Console.WriteLine("December: " + December.Count());

        }

    }
}
