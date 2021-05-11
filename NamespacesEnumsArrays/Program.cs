using System;
using static System.Console;


namespace NamespacesEnumsArrays
{
    [Flags]
    public enum DayOfWeek
    {
        None=0,
        Monday= 1 << 0,
        Tuesday=1<<1,
        Wednesday=1<<2,
        Thursday=1<<3,
        Friday=1<<4,
        Saturday=1<<5,
        Sunday=1<<6
    }
    class Program
    {
        static void Main(string[] args)
        {
            Iterate();


            //string[] formats = { "G", "g", "F", "f", "D", "d", "X", "x" };

            //foreach(string format in formats)
            //{
            //    WriteLine(FormatDayOfWeek(DayOfWeek.Friday, format));
            //}

            //WriteLine(ConvertToDayOfWeek("bla bla"));
            //WriteLine(ConvertToDayOfWeek("Monday"));
            //WriteLine(ConvertToDayOfWeek("Saturday, Sunday"));
        }
        public static void ValueNotIncludedAmongEnums()
        {
            int someValue = 145;
            DayOfWeek whatDayIsThis = (DayOfWeek)someValue;
            Console.WriteLine(whatDayIsThis);
            //outcome:145
        }
        public static void DayOfWeekExample()
        {
            DayOfWeek monday = DayOfWeek.Monday;
            Console.WriteLine(monday);

            DayOfWeek workingDays = DayOfWeek.Monday | DayOfWeek.Tuesday | DayOfWeek.Wednesday | DayOfWeek.Thursday | DayOfWeek.Friday;
            Console.WriteLine(workingDays);

            DayOfWeek weekend = DayOfWeek.Saturday | DayOfWeek.Sunday;
            Console.WriteLine(weekend);

            bool doesContainWednesday1 = (workingDays & DayOfWeek.Wednesday) == DayOfWeek.Wednesday;
            Console.WriteLine(doesContainWednesday1);

            bool doesContainWednesday2 = (weekend & DayOfWeek.Wednesday) == DayOfWeek.Wednesday;
            Console.WriteLine(doesContainWednesday2);
        }

        public static DayOfWeek ConvertToDayOfWeek(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return DayOfWeek.None;
            }

            if(Enum.TryParse(typeof(DayOfWeek), value, true,out object result))
            {
                return (DayOfWeek)result;
            }

            return DayOfWeek.None;
        }

        public static string FormatDayOfWeek(DayOfWeek value, string format)
        {
            if (string.IsNullOrWhiteSpace(format))
            {
                format = "G";
            }

            return Enum.Format(typeof(DayOfWeek), value, format);
        }

        public static void Iterate()
        {
            WriteLine("Members of DayOfWeek enum:");
            foreach(string memberName in Enum.GetNames(typeof(DayOfWeek)))
            {
                WriteLine(memberName);
            }

            WriteLine();

            WriteLine("Values of DayOfWeek enum:");
            foreach (int value in Enum.GetValues(typeof(DayOfWeek)))
            {
                WriteLine(value);
            }
        }

        public static void MatrixInstantiation()
        {
            int[,] matrix1 = new int[2, 3];
            //first row
            matrix1[0, 0] = 10;
            matrix1[0, 1] = 4;
            matrix1[0, 2] = 2;
            //second row
            matrix1[1, 0] = 12;
            matrix1[1, 1] = 6;
            matrix1[1, 2] = 9;

            //alternatively

            int[,] matrix2 = new int[2, 3]
            {
                {10, 4, 2 },
                {12, 6, 9 }
            };

            //or even
            int[,] matrix3 =
            {
                {10, 4, 2 },
                {12, 6, 9 }
            };
        }
    }

   
}
