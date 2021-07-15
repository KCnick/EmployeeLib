using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeLibrary;
using System.IO;

namespace EmployeeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEmployees()
        {
            var lines = File.ReadAllLines("./test.txt");
            Employees employees = new Employees(lines);
            Assert.AreEqual(3300,employees.SalaryBudget("Employee1"));
            Assert.AreEqual(1000,employees.SalaryBudget("Employee2"));
        }

        [TestMethod]
        public void TestDoubleLink()
        {
            var lines = File.ReadAllLines("./test1.txt");
            Employees employees = new Employees(lines);
            Assert.AreEqual(3300,employees.SalaryBudget("Employee1"));
            Assert.AreEqual(1000,employees.SalaryBudget("Employee2"));
        }


        [TestMethod]
        public void TestInvalidSalaryValue()
        {
            var lines = File.ReadAllLines("./test3.txt");
            Employees employees = new Employees(lines);
            Assert.AreEqual(3300,employees.SalaryBudget("Employee1"));
            Assert.AreEqual(0,employees.SalaryBudget("Employee6"));
 
        }
    }

}