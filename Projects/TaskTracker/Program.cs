using System;
using System.Collections.Generic;
namespace TaskTracker
{
    internal class Program
    {
        static List<string> tasks =new List<string>{};
        static List<string> MarkedTasks = new List<string> { };
        static int index = 0;
        static int markedindex = 0;

        static void Main(string[] args)
        {
            /*
              Task Tracker
            1.add task
            2.remove
            3.view
            4.mark completed
            5.exit
             */

            Console.WriteLine("---------------------- Welcome To Task Tracker ---------------------- ");
            while (true)
            {
                Console.WriteLine("Enter Number From 1 : 7");
                Console.WriteLine("1. Add Task \n 2. Remove Task \n 3. Remove by Id \n 4. View Tasks \n 5. Mark Completed \n 6. Completed Tasks\n7. Exit");
                string choice=Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter Your task");
                        string t=Console.ReadLine();
                        AddTask(t);
                        Console.WriteLine("----------------------");
                        break;
                    case "2":
                        Console.WriteLine("Enter Removed task");
                        string r = Console.ReadLine();
                        RemoveTask(r);
                        Console.WriteLine("----------------------");
                        break;
                    case "3":
                        Console.WriteLine("Enter id of task");
                        int rr = int.Parse(Console.ReadLine());
                        RemoveTask(rr);
                        Console.WriteLine("----------------------");
                        break;
                    case "4":
                        ViewTasks();
                        Console.WriteLine("----------------------");
                        break;
                    case "5":
                        Console.WriteLine("Enter id of task");
                        int m = int.Parse(Console.ReadLine());
                        MarkTask(m);
                        Console.WriteLine("----------------------");
                        break;
                    case "6":
                         ShowMarked();
                        Console.WriteLine("----------------------");
                        break;
                    case "7":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter Correct Num 1 : 7 ");
                        Console.WriteLine("----------------------");
                        break;
                }
            }
        }

        static void AddTask( string task)
        {
            tasks.Add(task);
            index++;
            Console.WriteLine("Task Added Successfully");
        }

        static void RemoveTask(string task)
        {
            tasks.Remove(task);
            index--;
            Console.WriteLine("Task Removed Successfully");
        }
        static void RemoveTask(int task)
        {
            tasks.RemoveAt(task-1);
            index--;
            Console.WriteLine("Task Removed Successfully");
        }

        static void ViewTasks() {
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine($"{i+1}. {tasks[i]}");
            }
        }
        static void MarkTask(int x)
        {
            MarkedTasks.Add(tasks[x - 1]);
            tasks.RemoveAt(x - 1); 
            markedindex++;
            Console.WriteLine("Marked successfully");
        }

        static void ShowMarked()
        {
            for (int i = 0; i <markedindex; i++)
            {
                Console.WriteLine($"{i+1}. {MarkedTasks[i]}");
            }
        }
    }
}
