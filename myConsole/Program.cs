using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            bool exitNotConfirmed = true;
            string userInput;

            do
            {
                Console.Clear();
                showMenu();

                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "0":
                        exitNotConfirmed = false;
                        break;
                    case "1":
                        getCurrentTime();
                        Console.Write("Press any key..."); Console.ReadKey();
                        break;
                    case "2":
                        getCurrentDate();
                        Console.Write("Press any key..."); Console.ReadKey();
                        break;
                    case "3":
                        Console.Write("n = ");
                        Console.WriteLine("n! = " + myFactorial(Convert.ToInt32(Console.ReadLine())));
                        Console.Write("Press any key..."); Console.ReadKey();
                        break;
                    case "4":
                        myLoops();
                        Console.Write("Press any key..."); Console.ReadKey();
                        break;
                    case "5":
                        myErrors();
                        Console.Write("Press any key..."); Console.ReadKey();
                        break;
                    default:
                        break;
                        
                } //switch

            } while (exitNotConfirmed);

        } //Main

        static void showMenu()
        {
            Console.WriteLine("Sample application");
            Console.WriteLine("Press menu item:");
            Console.WriteLine("[1]: Current time");
            Console.WriteLine("[2]: Current date");
            Console.WriteLine("[3]: n!");
            Console.WriteLine("[4]: Loops");
            Console.WriteLine("[5]: Error catching");
            Console.WriteLine("[0]: Exit");
        } //showMenu

        static void getCurrentTime()
        {
            Console.WriteLine(DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second);
        } //getCurrentTime

        static void getCurrentDate()
        {
            Console.WriteLine(DateTime.Now.Date);
        } //getCurrentDate

        static int myFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * myFactorial(n - 1);
        } //myFactorial

        static void myLoops()
        {
            int[] myArray = new int[] { 1, 3, 5, 7, 11, 13, 17, 19 };

            //foreach
            Console.WriteLine("Example: foreach");
            foreach (int i in myArray)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("Example: for");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("Example: while");
            int j = 0;
            while (j < myArray.Length)
            {
                Console.Write(myArray[j] + ", ");
                j++;
            }

            Console.WriteLine();
            Console.WriteLine("Example: do..while");
            j = 0;
            do
            {
                Console.Write(myArray[j] + ", ");
                j++;
            } while (j < myArray.Length);

            Console.WriteLine();
        } //myLoops

        static void myErrors()
        {
            float x, y, z;

            try
            {
                Console.Write("x = ");
                x = float.Parse(Console.ReadLine());

                Console.Write("y = ");
                y = float.Parse(Console.ReadLine());

                z = x * y;
                Console.WriteLine("x * y = " + z);

                z = x / y;
                Console.WriteLine("x / y = " + z);

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Source: " + e.Source);
                Console.WriteLine("HResult: " + e.HResult);
                Console.WriteLine("Message: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Source: " + e.Source);
                Console.WriteLine("HResult: " + e.HResult);
                Console.WriteLine("Message: " + e.Message);
            }

        } //myErrors

    } //Program

} //myConsole
