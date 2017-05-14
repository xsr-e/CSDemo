using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfCaseForSwitch
{
    class Program
    {
        static void Main(string[] args)
        {

    //1. if
            DayOfWeek today = DateTime.Today.DayOfWeek;
            if (today == DayOfWeek.Saturday)
            {
                Console.WriteLine("weekend");
            }
            else if (today == DayOfWeek.Sunday)
            {
                Console.WriteLine("weekend");
            }
            else
            {
                Console.WriteLine("workday");
            }

    
    //2. switch            
            //auto-expanding enum types:
            //switch snippet + [Tab], today variable + [RightArrow]
            
            switch (today)
            {
                case DayOfWeek.Friday:
                    break;
                case DayOfWeek.Monday:
                    break;
                case DayOfWeek.Saturday:  //Switch statement fallthrough (intended)
                case DayOfWeek.Sunday:
                    Console.WriteLine("weekend");
                    break;
                case DayOfWeek.Thursday:
                    break;
                case DayOfWeek.Tuesday:
                    break;
                case DayOfWeek.Wednesday:
                    break;
                default:
                    break;
            }
       

    //3. For     

            for (int i = 10; i > 2; i--)
            {
                Console.WriteLine(i);
            }

    //4. for each (requires IEnumerable)            
            foreach (var c in "collection".ToCharArray())
            {
                Console.WriteLine(c);
            }

        }
    }
}
