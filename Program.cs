using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - Create console application that read string from user and print the same string


            //Console.WriteLine("enter your name");
            // string name=Console.ReadLine();
            //Console.WriteLine("welcome" + " " + name);

            //2 -	Define variables with kind of*****************************************************************************************************

            //int num = 5;
            //double number = 5.11;
            //string name = "ali";
            //char x = 'A';
            //bool a = true;
            //const int j = 10;
            //Console.WriteLine( num+" "+number+" "+name+" "+x+" "+a+" "+j);

            //3-	Define array with name car that hold more than 3 kinds on cars, then print all the cars with the array length******************************

            //string[] car = { "bmw", "kia", "mer" };
            //foreach (string s in car)
            //{
            //    Console.WriteLine(s);

            //}


            //4*******************************************************************************************************************************


            //Console.WriteLine("enter your first name");
            //string firstName = Console.ReadLine();


            //Console.WriteLine("enter your last name");
            //string lastName = Console.ReadLine();

            //Console.WriteLine("enter your age");
            //int age =Convert.ToInt32 ( Console.ReadLine());

            //Console.WriteLine(firstName + " " + lastName +" "+age);


            //5-**********************************************************************************************************************************************

            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++) {

                array[i] = int.Parse(Console.ReadLine());

}
            foreach (int i in array) { 

            Console.WriteLine(i);

            }

        }
    }
}
