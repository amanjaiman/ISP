using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_of_CSharp
{
    class Guy
    {
        private string thisName = "";
        private string status = "";
        private int age = 0;

        public string Name
        {
            get
            {
                return thisName;
            }
            set
            {
                thisName = value;
            }
        }

        public string turdOrNot
        {
            get
            {
                return status;
            }
            set
            {
                if(value == "good") {
                    status = "NOT A TURD!";
                }
                else {
                    status = "TURDY FOOL!";
                }
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string[] testArray = { "Hello there", "people looking at this", "!"};
            foreach (string s in testArray)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            Console.WriteLine();
            Guy jagan = new Guy();
            jagan.Name = "Jagan";
            jagan.Age = 13;
            jagan.turdOrNot = "lolz";
            Console.WriteLine("Details of Jagan: {0}", jagan.Name, jagan.Age, jagan.turdOrNot);
            Console.ReadLine();
        }
    }
}
