using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseIt
{
    class Person
    {
        public string Name { get; set; }
        public string Department;
        public List<Expense> Expenses;

        /*public Person(String name, String department, List<Expense> expenses)
        {
            this.Name = name;
            this.Department = department;
            this.Expenses = expenses;
        }*/
    }
}
