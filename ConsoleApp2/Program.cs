using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type to year,month,day first date:");
            int firstyear = Convert.ToInt32(Console.ReadLine());
            int firstmonth = Convert.ToInt32(Console.ReadLine());
            if ((firstmonth > 0) && (firstmonth < 13)) {
                int firstday = Convert.ToInt32(Console.ReadLine());
                if ((firstday > 0) && (firstday < 32)) {
                    Console.WriteLine("Type to year,month,day second date:");
                    int secondyear = Convert.ToInt32(Console.ReadLine());
                    int secondmonth = Convert.ToInt32(Console.ReadLine());
                    if ((secondmonth > 0) && (secondmonth < 13))
                    {
                        int secondday = Convert.ToInt32(Console.ReadLine());
                        if (firstyear < secondyear)
                        {
                            Console.WriteLine("Yes");
                        }
                        else if (firstyear == secondyear)
                        {
                            if (firstmonth < secondmonth) 
                            {
                                Console.WriteLine("Yes");
                            }
                            else if (firstmonth == secondmonth)
                            {
                                if (firstday < secondday)
                                {
                                    Console.WriteLine("Yes");
                                }
                                else { Console.WriteLine("No"); }
                            }
                            else { Console.WriteLine("No"); }
                        }
                        else
                        {
                            Console.WriteLine("No");
                        }
                    }
                    else { Console.WriteLine("Error"); }
                }
                else { Console.WriteLine("Error"); }
            }
            else {
                Console.WriteLine("Error");
            }
        }
    }
}
