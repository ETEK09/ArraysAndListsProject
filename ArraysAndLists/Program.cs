﻿using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] myarray = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            //for (int i = 0; i < myarray.Length; i++) 
            //{
            //    Console.WriteLine(myarray[i]);
            //}
            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            List<int> evens = new List<int>();
            List<int> odd = new List<int>();
            

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            for (int i = 0; i < myarray.Length; i++)
            {
                if (myarray[i] % 2 == 0) 
                {

                    evens.Add(myarray[i]);
                
                }

                else
                {
                    odd.Add(myarray[i]);
                }
            

            }

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            for (int i = 0; i < evens.Count ;i++)
            {

                Console.WriteLine(evens[i]);
               
                
            
            }
            for (int i = 0; i < odd.Count ;i++) 
            {

                Console.WriteLine(odd[i]);
            
            }
        }
    }
}
