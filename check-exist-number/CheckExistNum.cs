﻿using System;


namespace basic4
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = "This is a 3 number 7 8 9  ";
            string check = "";
            char[] n = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int i = 0; i < n.Length; i++)
            {

                if (num.Contains(n[i]))

                    check += n[i];
            }
            if (check.Length == 0)
            {
                Console.WriteLine("There is no number");
            }
            else
            {
                Console.WriteLine("The exist number: " + check);
            }
                
            }

        }
    }

