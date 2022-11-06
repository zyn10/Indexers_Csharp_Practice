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
        private List<Person> listPersons = new List<Person>();
        public Company()
        {
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


        public Person this[string empName]
        {
            get
            {
                foreach (var per in listPersons)
                {
                    if(per.EmpName == empName)
                    {
                        return per;
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

            Person ob2 = new Person();

            Console.WriteLine("Before: "+ob2.EmpId);

            ob2 = ob["Awias"];

            Console.WriteLine("After: "+ob2.EmpName);


            //ob[1] = "Talha";

            //Console.WriteLine(ob[1]);

        }


    }



}
