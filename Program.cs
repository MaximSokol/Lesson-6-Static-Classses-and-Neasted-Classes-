using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6__Static_Classses_and_Neasted_Classes_
{
   // public class Book
    //{
       // public Book() { }

       // public void SearchingAWord(string str)
       // {
       //     Console.WriteLine($"{str}");
       // }

       // public void PrintNotice(string str)
       // {
       //     Console.WriteLine("The saving of a string!\t" + str);
       // }

       //public class Neasted
       // {
       //     public void ToNotice()
       //     {
       //         Console.WriteLine("Enter the string woul'd you like to save ->\t");
       //         string saving = Console.ReadLine();

       //         new Book().SearchingAWord(saving);
       //     }
       // }
   // }

    //static class FindAndReplaceManager
    //{
    //   public static void SearchingAWord(string str)
    //    {
    //        Book book = new Book();
    //        book.SearchingAWord(str);
    //    }
    //}

   static class Program
    {
        public static void ExtendedMethod(this int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Array.Sort(arr);
            }

            foreach(var elem in arr)
            {
                Console.WriteLine($"{elem}");
            }
        }


        static void Main(string[] args)
        {
            // Addiitonal Task


            //double buf = Calculator.Addition(1, 1);
            //Console.WriteLine($"Addition();\t{buf}");

            // buf = Calculator.Devision(5, 10);
            // Console.WriteLine($"Devision();\t{buf}");

            // buf = Calculator.Multiply(2, 2);
            // Console.WriteLine($"Multiply();\t{buf}");

            // buf = Calculator.Substraction(7, 14);
            // Console.WriteLine($"Substraction();\t{buf}");


            // Task 2


            //FindAndReplaceManager.SearchingAWord("hello!");


            // Task 3


            //Book.Neasted neasted = new Book.Neasted();
            //neasted.ToNotice();


            // Task 4

            //int[] arr = new int[10] { 3, 5, 8, 7, 4, 5, 6, 7, 8, 9 };
            //Program.ExtendedMethod(arr);

        }
    }
}
