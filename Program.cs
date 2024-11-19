using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> task = new List<int> {1,3,5};
            char character = '\0';
            int mean = 0;
            int sum = 0;
            int max = task[0];
            int min = task[0];

            do
            {
             
                 Console.WriteLine("p - Print numbers");
                 Console.WriteLine("A - Add a number ");
                 Console.WriteLine("M - Display mean of numbers");
                 Console.WriteLine("S - Display the smallest number");
                 Console.WriteLine("L - Display the largest number");
                 Console.WriteLine("C - Clear the list");
                 Console.WriteLine("I - index for number");
                 Console.WriteLine("enter your character");
                 character=char.Parse(Console.ReadLine());

                if (character == 'P' || character == 'p')                                               //Print
                {
                    if (task.Count == 0)
                    {
                        Console.WriteLine("The List is empty []\n");
                    }
                    else
                    {
                        Console.Write("\nThere are number in List :");           // writer عشان الكلام يبقي جنب بعضه
                        Console.Write("[");
                        for (int i = 0; i < task.Count; i++)
                        {
                            Console.Write(task[i]);

                            if (i < task.Count - 1)
                            {
                                Console.Write(",");
                            }
                        }
                        Console.Write("]\n");

                    }
                }
                else if (character == 'A' || character == 'a')                                //Add
                {
                    int number = int.Parse(Console.ReadLine());                               //check duplicate in list
                    if (task.Contains(number)){
                        Console.WriteLine($"The number {number} is already in the list,Where the list is");
                        Console.Write("[");
                        for (int i = 0; i < task.Count; i++)
                        {
                            Console.Write(task[i]);

                            if (i < task.Count - 1)
                            {
                                Console.Write(",");
                            }
                        }
                        Console.Write("]\n");
                        Console.WriteLine("please enter new number");
                }
                    else {
                        task.Add(number);
                        Console.Write("[");
                        for (int a = 0; a < task.Count; a++)
                        {
                            Console.Write(task[a]);

                            if (a < task.Count - 1)
                            {
                                Console.Write(",");                        // السطر ده عشان ميحطش (,) بعد اخر رقم ف الليست
                            }
                        }
                        Console.Write("]\n");
                        Console.WriteLine($"the number is added : {number}");
                    }
                }

                else if (character == 'M' || character == 'm')                                                   //Mean
                {
                    if (task.Count == 0)
                    {
                        Console.WriteLine("Unable the calculate the mean - no data");
                    }
                    for (int j = 0; j < task.Count; j++)
                    {
                        sum += task[j];
                        mean = sum / task.Count;

                    }
                    Console.WriteLine($"Mean : {mean}");
                }
                else if (character == 'L' || character == 'l')                                 //Max
                {
                    if (task.Count == 0)
                    {
                        Console.WriteLine("Unable to determine the Largest number -list is empty");
                    }
                    else
                    {
                        for (int n = 0; n < task.Count; n++)
                        {
                            if (task[n] > max)
                            {
                                max = task[n];
                                Console.WriteLine($"Max :{max}");
                            }
                        }
                    }
                }
                else if (character == 'S' || character == 's')                             //Min
                {
                    if (task.Count == 0)
                    {
                        Console.WriteLine("Unable to determine the smallest number -list is empty");
                    }
                    else
                    {
                        for (int p = 0; p < task.Count; p++)
                        {
                            if (task[p] <= min)
                            {
                                min = task[p];
                                Console.WriteLine($"Min :{min}");
                            }
                        }
                    }
                }

                else if (character == 'C' || character == 'c')
                {
                    task.Clear();
                }
                else if (character == 'I' || character == 'i')
                {
                    Console.WriteLine("enter your number to check lsit");
                    int chechnumber = int.Parse(Console.ReadLine());
                    int index = task.IndexOf(chechnumber);
                    if (task.Contains(chechnumber))
                    {
                        Console.WriteLine($"the number {chechnumber} is in the list and the index is : {index}");
                    }
                    else
                    {
                        Console.WriteLine("the number is not in list");
                    }

                }
                else if (character == 'Q' || character == 'q')
                {
                    Console.WriteLine("Good bye ....");
                }
                else
                {
                    Console.WriteLine("unknowken selection,please try again");
                }

            }while(character != 'Q' || character == 'q');
        }
    }
}
