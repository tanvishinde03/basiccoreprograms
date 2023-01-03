using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thepowerof2
{
	public class powerof2
	{
		public static void checkpowerof2()
		{
			int num, mul = 1;


			num = 0;

			
			if (num > 31) {
				Console.WriteLine("value of number should be less than 31");
				return;
			}

		
			else {
				Console.WriteLine(mul);
				for (int j = 1; j <= num; j++) {
					mul = mul * 2;
					Console.WriteLine(mul);
                    Console.Write("----------------------------------------------");
                }
			}

		}

	}


}

    

