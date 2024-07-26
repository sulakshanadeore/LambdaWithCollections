using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryForGenerics;

namespace MoreOnDelegatesApp
{
    internal class WorkingWithObjects
    {
      static  List<Employee> empList = new List<Employee>();

        public static void InitialiseData()
        {
            empList.Add(new Employee() { Empid = 1, EmpName = "Akash", BasicSal = 10000 });
            empList.Add(new Employee() { Empid = 2, EmpName = "Jack", BasicSal = 12000 });
            empList.Add(new Employee() { Empid = 3, EmpName = "Tina", BasicSal = 50000 });
            empList.Add(new Employee() { Empid = 4, EmpName = "Hari", BasicSal = 40000 });
            empList.Add(new Employee() { Empid = 5, EmpName = "Paresh", BasicSal = 10000 });

        }

        static Employee FindEmployee(int p_empid)
        {
            Employee foundEmployee=empList.Find(e => e.Empid == p_empid);
            return foundEmployee;

        }

       static void NewEmployee(Employee emp)
       //static void NewEmployee(int empid,string ename,int basicSal)
        {

            empList.Add(emp);
         //   empList.Add(new Employee() {Empid=empid,EmpName=ename,BasicSal=basicSal });
        
        }

        static List<Employee> ShowList()
        { 
        return empList;


        }

        static List<Employee> FindAllEmployeesBySal(int bs)
        { 
        return empList.FindAll(e=>e.BasicSal == bs);    
        }

        static Employee FindEmployeeSal(int bs)
        { 
        Employee emp=empList.Find(e=>e.BasicSal == bs);
            return emp;
        }

        static void RemoveEmployee(int empid)
        {
            Employee empdata=FindEmployee(empid);
            empList.Remove(empdata);
       }
      static void Main(string[] args)
        {
            InitialiseData();

           Console.WriteLine("1. Find 2.Add 3.Delete 4.ShowList 5.FindAll Having Same Basic Sal");
            int c=Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case 1:
                    Console.WriteLine("Enter the employee id to find the employee");
                    int empid=Convert.ToInt32(Console.ReadLine());
                    Employee emp1=FindEmployee(empid);
                    Console.WriteLine(emp1.Empid);
                    Console.WriteLine(emp1.EmpName);
                    Console.WriteLine(emp1.BasicSal);
                    break;
                case 2:
                    Console.WriteLine("Enter emp id");
                    empid=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter empname");
                    string empname=Console.ReadLine();
                    Console.WriteLine("Enter basic salary");
                    int basic=Convert.ToInt32(Console.ReadLine());
                    Employee emp = new Employee();
                    emp.Empid = empid;
                    emp.EmpName = empname;
                    emp.BasicSal = basic;
                    NewEmployee(emp); break;
                case 3:
                    Console.WriteLine("Enter employee id to delete");
                    empid= Convert.ToInt32(Console.ReadLine());
                    RemoveEmployee(empid);
                    break;
                case 4:
                    List<Employee> elist=ShowList();
                    elist.ForEach(e =>
                    {
                        Console.WriteLine(e.Empid);
                        Console.WriteLine(e.EmpName);
                        Console.WriteLine(e.BasicSal);
                    });
                    break;

                case 5:
                    Console.WriteLine("Enter the salary to find employees for");
                    int sal=Convert.ToInt32(Console.ReadLine());

                    int cnt = empList.FindAll(e => e.BasicSal == sal).Count();

                    if (cnt == 1)
                    {
                        FindEmployeeSal(sal);
                        
                    }
                    else if (cnt > 1)
                    {
                        FindAllEmployeesBySal(sal);
                    }
                    else 
                    {
                        Console.WriteLine("Not in range");
                    }
                    break;
                                
            }


            Console.ReadLine();
        }
    }
}
