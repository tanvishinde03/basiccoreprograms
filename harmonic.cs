﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_core_programs
{
    public class harmonic
    {
        public static void checkharmonic()
        {

            {
                int i, n;
                double s = 0.0;

              
                Console.Write("Calculate the harmonic series and their sum:");
                Console.Write("----------------------------------------------");
                

                Console.Write("Input the number of terms : ");
                n = Convert.ToInt32(Console.ReadLine());
                
                for (i = 1; i <= n; i++)
                {
                    Console.Write("1/{0} + ", i);
                    s += 1 / (float)i;
                }
                Console.Write("Sum of Series upto {0} terms : {1} ", n, s);
                Console.Write("----------------------------------------------");
            }
        }

    }
    }












    

