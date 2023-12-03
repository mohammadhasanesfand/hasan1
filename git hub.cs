using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; i <= 20; i++)
            Console.WriteLine(i);

            
            for (int i = 100; i <=999; i++)
            Console.WriteLine(i);

             Console.Write("fard :");
              for (int i = 1; i < 30; i += 2)
              {
                  Console.Write("{0,5}" ,i);
              }
              Console.WriteLine("zoj :");
              for (int a = 2; a < 30; a += 2)
              {
                  Console.Write("{0,5}" ,a);
              }

            
            for (int i = 2; i <= 30; i++)
            {
                i++;
                Console.Write("{0,5}",i);
            }

            
             for (int i = 5; i >= 1; i--)
                 Console.Write(i);
             for (int i = 0; i < 10; i += 3)
                 Console.Write(i);
             for (int i = 10; i >= 0; i-= 2)
                 Console.Write(i);

             int a = 10;
             for (int i = 1; i <= 5; i++)
             {
                 Console.WriteLine("{0} + {1}", i, a);
                 a--;
             }


            
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0)
                    Console.WriteLine("hop");
                else
                    Console.WriteLine(i);
            }

            
          int minute=0;
            int sum=0;
            int avg;
            for (int i = 1; i <= 30; i++)
            {
                Console.WriteLine("please rate the day {0} enter in minute=",i);
                minute = int.Parse(Console.ReadLine());
                sum = sum + minute;
            }
            Console.WriteLine("you studied for {0} minutes a week", sum);
            Console.WriteLine(minute = minute / 60);
            avg = minute;
            Console.WriteLine(avg = avg / 30);


            int month;
            int guess;
            int score = 5;
            Console.Write("enter number your month");
            month = int.Parse(Console.ReadLine());
            Console.Clear();
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("your guess");
                guess = int.Parse(Console.ReadLine());
                if (guess == month)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("you win");
                    Console.WriteLine("your score:{0}", score);
                    break;
                }
                else
                {
                    score -= 1;
                    Console.WriteLine("try again?");
                }
            }



            for (int k = 10; k <= 15;)
            {
                Console.WriteLine(k);
                k++;
            }

            int i = 1;
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (; i <= 10; i++)
            {
                Console.WriteLine("iran");
                i++;
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            for (;;)
            {
                Console.WriteLine("iran");
            }



            float sum = 0, avg;
            int conut = 0;
            Console.Write("enter mark{0}=", conut + 1);
            float mark = float.Parse(Console.ReadLine());
            while (mark >= 0)
            {
                sum = sum + mark;
                conut++;
                Console.Write("enter mark {0} = ", conut + 1);
                mark = float.Parse(Console.ReadLine());
            }
            avg = sum / conut;
            Console.WriteLine(avg);



            int hour;
            int max;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nenter hour");
            hour = int.Parse(Console.ReadLine());
            max = hour;
            while (hour > 0)
            {
                if (hour > max)
                    max = hour;
                Console.WriteLine("\nenter 0 for exit");
                Console.Write("enter hour");
                hour = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("max = {0}", max);


            int s = 1;
            while (s != 6)
                Console.WriteLine("-------console calculator-------");
            Console.WriteLine("1.enter a , b:");
            Console.WriteLine("2.calc a + b=");
            Console.WriteLine("3.calc a * b=");
            Console.WriteLine("4. calc a / b=");
            Console.WriteLine("5. clac a - b=");
            Console.WriteLine("6.exit:");
            Console.WriteLine("----------------");
            Console.WriteLine("a=");
            Console.WriteLine("b=");
            Console.WriteLine("----------------");
            Console.WriteLine("enter number(1-6):");

            s = int.Parse(Console.ReadLine());
            switch (s)
            {
                    case1:
            Console.Write("enter a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("enter b: ");
            b = int.Parse(Console.ReadLine());
            break;

        case2:
            Console.WriteLine("{0}+{1}={2}", a, b, a + b);
            break;
        case3:
            Console.WriteLine("{0}+{1}={2}", a, b, a * b);
            break;
        case4:
            Console.WriteLine("{0}+{1}={2}", a, b, a / b);
            break;
        case5:
            Console.WriteLine("{0}+{1}={2}", a, b, a - b);
            break;

        case6:
            break;

            default : Console.Write("error");
            break;
        }


            for (int i = 1; i <= 5; i++)
            {
                Console.Write("{0,4}", i * 1);
                Console.Write("{0,4}", i * 2);
                Console.Write("{0,4}", i * 3);
                Console.Write("{0,4}", i * 4);
                Console.Write("{0,4}", i * 5);
                Console.WriteLine();
            }


            for (int x = 0; x <= 25; x++)
            {
                for (int y = 0; y <= 10; y++)
                {
                    if (2000 * x + 5000 * y == 50000)
                        Console.WriteLine("x={0}, y={1}", x, y);
                }
            }


            string[] name = new string[10];
            for (int i = 0; i <= 9; i++)

            {
                Console.WriteLine("please enther the name {0} : ", i + 1);
                name[i] = Console.ReadLine();
            }



            string[] computer = new string[5] { "cpu", "mainboard", "ram", "hdd", "dvd" };
            int[] price = new int[5] { 100, 200, 300, 0, 500 };
            computer[3] = "keyboard";
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(computer[i] + "   " + price[i]);

            }
            Console.SetCursorPosition(11, 3);
            price[3] = int.Parse(Console.ReadLine());



            string[] week = { "saturday", "sunday", "monday", "tuesday", "wensday", "friday" };
            Console.Write("enter the number one day of week  (1-6):");
            byte num = byte.Parse(Console.ReadLine());
            Console.WriteLine(week[num]);
            while (num >= 0 && num <= 6)
                //break;
                //Console.WriteLine("error");

                //Console.WriteLine(week[num]);

                while (num >= 0 && num <= 6)
                {
                    Console.WriteLine("error");
                    break;
                }
            if (num >= 0 && num <= 6)
                Console.WriteLine("error");
            .....................................
            
            
             string name = "nima";
            int[] numeber = new int[5] { 10, 20, 30, 40, 50 };
            name = "mmad";
            numeber[3] = 55;
            for (int i = 0; i < 4; i++)
                Console.WriteLine("your name is {0} and your {1}", name[i], numeber[i]);
            ////foreach (char item in numeber)
            {
                Console.WriteLine(item);
            }

            foreach (int item in name)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(numeber[i]);
            }


            int[] price = new int[50];

            for (int i = 0; i < 50; i++)
            {
                Console.Write("enter the price of {0} the product : ", i + 1);
                int temp = int.Parse(Console.ReadLine());
                if (temp > 0)
                    price[i] = temp;
                else
                    break;
            }
            Console.WriteLine("product price plus VAT ");
            Console.Clear();
            for (int j = 0; j < price.Length; j++)
            {

                price[j] = (int)(price[j] * 0.09 + price[j]);

                if
                    (price[j] > 0)


                    Console.WriteLine("product{0} : {1}", j, price[j]);
            }


            string[] car = { "prid", "mazda", "renault", "peugeot", "toyota" };
            long[] price = { 100, 200, 300, 400, 5000 };
            string item = "pride";
            bool found = false;
            Console.Write("please enter car name for liner search : ");
            item = (Console.ReadLine());
            for (int i = 0; i < car.Length; i++)
                if (item == car[i])
                {
                    Console.WriteLine("{0} found in {1}", item, i);
                    break;

                }
            item = "hyundai";


            string[] name = new string[10];
            for (int i = 0; i <= 9; i++)

            {
                Console.WriteLine("please enther the name {0} : ", i + 1);
                name[i] = Console.ReadLine();

            }
            Console.ReadKey();

            string[] computer = new string[5] { "cpu", "mainboard", "ram", "hdd", "dvd" };
            int[] price = new int[5] { 100, 200, 300, 0, 500 };
            computer[3] = "keyboard";
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(computer[i] + "   " + price[i]);

            }
            Console.SetCursorPosition(11, 3);
            price[3] = int.Parse(Console.ReadLine());


            string[] week = { "saturday", "sunday", "monday", "tuesday", "wensday", "friday" };
            Console.Write("enter the number one day of week  (1-7):");
            byte num = byte.Parse(Console.ReadLine());
            if ((num < 1) || (num > 7))
                Console.WriteLine("please enter correct number?");
            else
                Console.WriteLine(week[--num]);
            Console.WriteLine(week[--num]);


            string[] computer = new string[5];
            long[] price = new long[5];
            long sumprice = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("enter the name of computer part:");
                computer[i] = Console.ReadLine());
            Console.Write("enter price of computer part:");
            price[i] = long.Parse(Console.ReadLine());
        }
            for (int i = 0; price.Length; i++)

            {
                sumprice += price[i];
                for (int i = 0; i<5; i++)
            {
    console.writeLine("{0} {1}" , computer[i] , price[i]);
                console.WriteLine(sumprice);
        }
  }

            
             
            int sum = 0;
            int hours;
            int i;
            for (i = 1; i <= 4; i++)
            {
                Console.WriteLine("please rate the week {0} enter in hour =", i);
                hours = int.Parse(Console.ReadLine());
                sum += hours;
            }
            sum /= i - 1;
            Console.WriteLine("avarage hours in month : {0} ", sum);
            */

            
            
            int score = 5;
            int month;
            Console.Write("enter number your month :");
            month = int.Parse(Console.ReadLine());
            Console.Clear();
            for (int i = 1; i <= 5; i++)
            {
                int guess;
                Console.Write("your guess?");
                guess = int.Parse(Console.ReadLine());
                if (guess == month) {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("you win");
                    Console.WriteLine("your score: {0}",score);
                    break;
                }
                else
                {
                    score -= 1;
                    Console.WriteLine("try again  !");
                }
            }
            */

          


Console.ReadKey();

        }
    }
}
