using Cinema.Helpers;
using System;

namespace Cinema
{
    internal class Program
    {
        private static List<Person> persons = new List<Person>();
        static void Main(string[] args)
        {
            bool displayMenu = true;
            do
            {
                displayMenu = MainMenu();

            } while (displayMenu);
        }

        public static bool MainMenu()
        {

            PrintMenu();
            String result = Console.ReadLine();

            // byt till switch case
            switch (result)
            {
                case MenuHelper.AddVisitor:
                    {
                        Person aperson = AddVisitor();
                        aperson.PrintToConsole();
                        Console.ReadLine();
                        break;
                    }
                case MenuHelper.AddGroup:
                    {
                        AddGroup();
                        PrintGroup(persons);
                        persons.Clear();
                        break;
                    }
                case MenuHelper.WordRepeater:
                    {
                        RepeatSentence();
                        break;
                    }
                case MenuHelper.ThirdWorder:
                    {
                        SentenceParser();
                        break;
                    }
                case MenuHelper.Quit:
                    Environment.Exit(0);
                    break;


                default:
                    Console.WriteLine("Unvalid choice");
                    Console.ReadLine();
                    break;

            }

            return true;


        }

        private static void PrintMenu()
        {

            Console.Clear();
            // Todo implement IEnumerable for indexcounter GetEnumerator()
            int i = 0;
            Console.Clear();
            foreach (string menuText in MenuHelper.MenuCollection2Print())
            {
                Console.WriteLine("{0}: {1}", i, menuText);
                i++;
            }

        }

        private static void SentenceParser()
        {
            string inSentence = "";
            Console.Clear();
            Console.WriteLine("Write a sentence minimum three words:");
            inSentence = Console.ReadLine();
            string[] words = inSentence.Split(' ');
            Console.WriteLine("the third word is {0}", words[2]);
            Console.ReadLine();
        }

        private static void RepeatSentence()
        {
            string inSentence = "";
            Console.Clear();
            Console.WriteLine("Write a sentence");
            inSentence = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(inSentence);
            }
            Console.ReadLine();
        }

        private static Person AddVisitor()
        {
            //string name = "";
            int age = 0;

            Console.Clear();
            Console.WriteLine("Input the visitors age");
            age = int.Parse(Console.ReadLine());

            return new Person(age);
        }


        private static List<Person> AddGroup()
        {
            int grpSize = 0;
            Console.Clear();
            Console.WriteLine("Input group size");
            grpSize = int.Parse(Console.ReadLine());
            for (int i = 0; i < grpSize; i++)
            {
                persons.Add(AddVisitor());
            }

            return persons;
        }

        private static void PrintGroup(List<Person> inPersonList)
        {
            int sum = 0;
            foreach (Person aperson in inPersonList)
            {
                sum += aperson.CalcPrice();
            }
            Console.Clear();
            Console.WriteLine("Nr People: {0}", inPersonList.Count);
            Console.WriteLine("Total cost: {0}kr", sum);
            Console.ReadLine();
        }

    }

    class Person
    {
        public int Age { get; set; }

        //public Person() { }
        public Person(int inAge)
        {
            Age = inAge;
        }

        public int CalcPrice()
        {
            int calcPrice = 120;
            switch (Age)
            {
                case < 21:
                    {
                        calcPrice = 80;
                        break;
                    }

                case > 64:
                    calcPrice = 90;
                    break;

                default:
                    break;

            }

            return calcPrice;
        }
        public void PrintToConsole()
        {
            string toPrint = "Standardpris";
            switch (Age)
            {
                case < 21:
                    {
                        toPrint = "Ungdomspris";
                        break;
                    }

                case > 64:
                    toPrint = "Pensionärspris";
                    break;

                default:
                    break;

            }
            Console.WriteLine("{0}: {1}kr", toPrint, this.CalcPrice());
            Console.WriteLine();
        }

    }
}
