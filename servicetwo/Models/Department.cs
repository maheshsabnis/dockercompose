using System;
using System.Collections.Generic;

namespace servicetwo.Models
{
    public class Department
    {
        public int DempNo { get; set; }
        public string DeptName { get; set; }
    }


    public class DepartmentsDb : List<Department>
    {
        public DepartmentsDb()
        {
            Add(new Department() {DempNo=10, DeptName="D1" });
            Add(new Department() { DempNo = 20, DeptName = "D2" });
        }
    }
}
