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
        //Q3
        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
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
                /*
                 * Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

                Person[] people = new Person[3];

                people[0] = new Person("Ahmed", 25);
                people[1] = new Person("Sara", 30);
                people[2] = new Person("Omar", 22);

                Console.WriteLine("People Information:");
                for (int i = 0; i < people.Length; i++)
                {
                    Console.WriteLine($"Name: {people[i].Name}, Age: {people[i].Age}");
                }*/
                #endregion

                #region Q3
                //Create an enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

                Console.WriteLine("write any season: Spring, Summer, Autumn, Winter");
                string userInput = Console.ReadLine();

                Season s;

                if (Enum.TryParse(userInput, true, out s))
                {
                    Console.WriteLine(); 
                    switch (s)
                    {
                        case Season.Spring:
                            Console.WriteLine("spring march to may");
                            break;
                        case Season.Summer:
                            Console.WriteLine("summer june to august");
                            break;
                        case Season.Autumn:
                            Console.WriteLine("autumn September to November");
                            break;
                        case Season.Winter:
                            Console.WriteLine("winter December to February ");
                            break;
                        default:
                            Console.WriteLine("Erorr");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("try again");
                }

               
            }
        }
    }
    #endregion

}
        