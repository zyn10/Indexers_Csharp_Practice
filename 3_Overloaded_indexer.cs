
using System;
using System.Collections.Generic;
using System.Reflection;

namespace ConsoleApp3
{

    class Person
    {
        public int EmpId { get; set; }

        public string EmpName { get; set; }

        public string EmpCity { get; set; }
    }

    class Company
    {
        private List<Person> listPersons = new List<Person>();
        public Company()
        {
            listPersons.Add(new Person { EmpId = 1, EmpName = "Awias", EmpCity = "Faisalabad" }) ;

            listPersons.Add(new Person { EmpId = 2, EmpName = "Ali", EmpCity = "Islamabad" });

            listPersons.Add(new Person { EmpId = 3, EmpName = "Ahmad", EmpCity = "Lahore" });
        }

        public string this[int empId]
        {
            get
            {
                foreach(var per in listPersons)
                {
                    if(per.EmpId == empId)
                    {
                        return per.EmpName;
                    }
                }
                return null;
            }

            set
            {
                foreach (var per in listPersons)
                {
                    if (per.EmpId == empId)
                    {
                        per.EmpName = value;
                    }
                }
            }

        }



        public String this[string empName]
        {
            get
            {
                foreach (var per in listPersons)
                {
                    if (per.EmpName == empName)
                    {
                        return per.EmpCity;
                    }
                }
                return null;


            }

        }

    }

    class Program
    {


       static  void Main()
        {
            Company ob = new Company();




            Console.WriteLine(ob[2]);

        }


    }



}
