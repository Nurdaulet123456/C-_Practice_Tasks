using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {

            // Number 1

            // Console.WriteLine("Input a symbol: ");
            
            // char c = Convert.ToChar(Console.ReadLine());

            // if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') {
            //     Console.WriteLine("It is a lowercase vowel: ", c);
            // } 

            // else if (c >= '0' && c <= '9') {
            //     Console.WriteLine("No Symbol", c);
            // }
            
            // else {
            //     Console.WriteLine("The Entered Character doesnot contains  any vowels and digits");
            // }

            // Console.ReadKey();


            // Number 2
            // Console.WriteLine("Write First Number: ");
            // int number1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Write Second Number: ");
            // int number2 = Convert.ToInt32(Console.ReadLine());

            // if ((number1 % 2 == 0) && (number2 % 2 == 0)) {
            //     Console.WriteLine("there're numbers bothEven");
            // } else {
            //     Console.WriteLine("there're numbers odd");
            // }        

            // Console.ReadKey();       

            // Number 3

            // float meter, hour, minute, second, metrsec, timespec, kph, mph;

            // meter = Convert.ToInt32(Console.ReadLine());
            // hour = Convert.ToInt32(Console.ReadLine());
            // minute = Convert.ToInt32(Console.ReadLine());
            // second = Convert.ToInt32(Console.ReadLine());
            // timespec = (hour * 3600) + (minute * 60) + second;
            // metrsec = meter / timespec;
            // kph = (meter / 1000.0f) / (timespec / 3600.0f);
            // mph = kph / 1.63f;
            // Console.WriteLine("Your speed in meters/sec is " + metrsec);
            // Console.WriteLine("Your speed in km/h is " + kph);
            // Console.WriteLine("Your speed in miles/h is " + mph);


            // Number 4 

            // Console.WriteLine("Write coordinates X and Y: ");

            // int X = Convert.ToInt32(Console.ReadLine());
            // int Y = Convert.ToInt32(Console.ReadLine());

            // if (X > 0 && Y > 0) Console.WriteLine("The coordinate point ({0},{1}) lies in the First quadrant", X ,Y);
            // if (X > 0 && Y < 0) Console.WriteLine("The coordinate point ({0},{1}) lies in the Second quadrant", X ,Y);
            // if (X < 0 && Y < 0) Console.WriteLine("The coordinate point ({0},{1}) lies in the Third quadrant", X ,Y);
            // if (X < 0 && Y > 0) Console.WriteLine("The coordinate point ({0},{1}) lies in the Fourth quadrant", X ,Y);
            // if (X == 0 && Y == 0) Console.WriteLine("The coordinate point ({0},{1}) lies in the Origin quadrant", X ,Y);
            // Console.ReadKey();

            // Number 5

            // Console.WriteLine("Pyramid View with asterisk Symbol");
            // int i, j, k,N,space, count = 1;
            // Console.WriteLine("Enter the N Number of Rows");
            // N = Convert.ToInt32(Console.ReadLine());
            // space = N + 4 - 1;
            // for (i = 1; i <= N; i++)
            // {
            //     for (j = (N + 4 - 1); j >= 1; j--)
            //     {
            //         Console.Write(" ");
            //     }
            //     for (k = 1; k <= i; k++)
            //     {
            //         Console.Write("{0} ", count++);
                   
                   
            //     }
            //     Console.WriteLine("\n");
            //     space-=1;
            // }
            // Console.ReadLine();
        }
}

}