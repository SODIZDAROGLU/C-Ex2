using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isContinue= true;
            while (isContinue)
            {

                int k = 1;
                int c = 1;
                int s = 1;
                int myBox;

                Console.WriteLine("Enter Your Two Numbers : ");

                Console.WriteLine("--------------------------");

                int[] array = new int[2];
                for (int i = 0; i < 2; i++)
                {
                    Console.Write("Enter Your Number-{0} : ", i + 1);
                    string myNumbers = Console.ReadLine();
                    if (myNumbers.ToLower() == "exit")
                                return;
                   
                        if (int.TryParse(myNumbers, out myBox))//Converts the string to int
                        {
                            array[i] = Convert.ToInt32(myBox);
                        }
                        else
                        {
                            Console.Write("NOT A NUMBER :{0} ", myNumbers);

                        }
                        Console.Write("\n");
                    }
                    Console.Write("ELEMENTS : ");
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Write(" {0}, ", array[i]);


                    }
                    Console.Write("\n");
                    Console.WriteLine("[0] : {0}, ", array[0]);
                    Console.WriteLine("[1] : {0}, ", array[1]);
                    Console.Write("\n");
                    Console.WriteLine("MAX : {0}", array.Max());//max number
                    Console.WriteLine("MIN : {0}", array.Min());//min number

                    Console.Write("\n");
                    Console.WriteLine($"{"NUMBER"}{"SQUARE",7}{"CUBE",6}");
                    Console.WriteLine("--------------------");
                    if (array[0] > array[1])
                        s = array[1];
                    {
                        for (int i = array[1]; i < array[0]; i++)
                        {
                            for (int j = array[1]; j <= i; j++)
                            {
                                if (k != array[0] && c != array[0] && s != array[0])
                                {

                                    Console.Write($"{s}");
                                    Console.Write($"{k * k,8}");
                                    Console.Write($"{c * c * c,9}");



                                    Console.Write("\n");
                                    k++;
                                    c++;
                                    s++;
                                }

                            }


                        }
                    }

                    if (array[1] > array[0])
                    {
                        k = array[1];
                        c = array[1];
                        s = array[1];

                        for (int i = array[1]; i >= array[0]; i--)
                        {
                            for (int j = array[1]; j >= i; j--)
                            {
                                if (k != array[0] && c != array[0] && s != array[0])
                                {
                                    Console.Write($"{s}");
                                    Console.Write($"{k * k,8}");
                                    Console.Write($"{c * c * c,9}");
                                    Console.Write("\n");
                                    k--;
                                    s--;
                                    c--;
                                }


                            }


                        }
                    }
                           Console.WriteLine("Do you want to continue(y/n).");
                            var cevap = Console.ReadLine();
                            isContinue = cevap.ToLower() == "y" ? true : false;
                             
                }

                   
            
            

            

         }
    }
}
