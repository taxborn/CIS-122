// Created by: Braxton Fair
// Created on: 02/11/2021

using System;
using System.Collections.Generic;

namespace Breakout
{
    public class FileGateway
    {
        public List<Employee> GetEmployees(string path)
        {
            List<Employee> aListOfEmployees = new List<Employee>();
            int index = 1;

            string[] allRows;
            string[] allColumns;

            Employee aEmployee;

            allRows = File.Read
        }
    }
}
