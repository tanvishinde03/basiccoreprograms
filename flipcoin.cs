using basicprograms;
using basiccoreprograms;


namespace basicprograms
{
 public  class flipcoin
    {
        public static void FliptheCoin()
        {

            int tailcount = 0;
            int headcount = 0;
            Console.WriteLine("Please enter the value for number of flips");
            int flip = Convert.ToInt32(Console.ReadLine());
            if (flip > 0)
            {
                for (int i = 0; i < flip; i++)

                {
                    Random random = new Random();
                    int number = random.Next();
                    Console.WriteLine(number);

                    if (number == 0)
                    {
                        tailcount++;
                    }
                    else
                    {
                        headcount++;
                    }
                }
            }
            else

            {
                Console.WriteLine("Please enter correct value");



            }
                Console.WriteLine("Headcount is" + headcount);
                Console.WriteLine("tailcount is" + tailcount);

                int headpercentage = headcount * 100 / flip;

                int tailpercentage = tailcount * 100 / flip;

                Console.WriteLine("Tail Percentage is" + tailpercentage);
                Console.WriteLine("Tail Percentage is" + tailpercentage);
            Console.WriteLine("------------------------------");
            }
           
            
            
            
            
            

            




            







            }









        }






            
        




















    

