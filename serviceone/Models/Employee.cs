using System;
using System.Collections.Generic;

namespace serviceone.Models
{
    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
    }



    public class EmployeeDb : List<Employee>
    {
        public EmployeeDb()
        {
            Add(new Employee() { EmpNo=101,EmpName="ABC"});
            Add(new Employee() { EmpNo = 102, EmpName = "PQR" });
        }
    }
}
