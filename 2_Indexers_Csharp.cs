using System;
using System.Collections.Generic;
using System.Reflection;

namespace ConsoleApp3
{

    class Person
    {
        public int EmpId { get; set; }

        public string EmpName { get; set; }
    }

    class Company
    {
        private List<Person> listPersons;
        public Company()
        {
            listPersons = new List<Person>();

            listPersons.Add(new Person { EmpId = 1, EmpName = "Awias" }) ;

            listPersons.Add(new Person { EmpId = 2, EmpName = "Ali" });

            listPersons.Add(new Person { EmpId = 3, EmpName = "Ahmad" });
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

    }

    class Program
    {


       static  void Main()
        {
            Company ob = new Company();

            //ob[3];

            Console.WriteLine(ob[1]);

            ob[1] = "Talha";

            Console.WriteLine(ob[1]);

        }


    }



}
