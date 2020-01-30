using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calendar_Helper;
using System.Collections.Generic;

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
    }
}
