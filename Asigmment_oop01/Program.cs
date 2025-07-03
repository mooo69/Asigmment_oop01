using System;

namespace Asigmment_oop01
{
    //q1
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    //=================================================
    //Q2
    struct Person
    {
        public string Name;
        public int Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
     //===========================================================
        class Program
        {

            static void Main(string[] args)
            {



                #region Q1
                /*
                //Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.

                Console.WriteLine("Days of the week:");
                foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
                {
                    Console.WriteLine("- " + day);
                }*/
                #endregion

                #region Q2
                Person[] people = new Person[3];

                people[0] = new Person("Ahmed", 25);
                people[1] = new Person("Sara", 30);
                people[2] = new Person("Omar", 22);

                Console.WriteLine("People Information:");
                for (int i = 0; i < people.Length; i++)
                {
                    Console.WriteLine($"Name: {people[i].Name}, Age: {people[i].Age}");
                }
                #endregion


            }
        }
    }
}
