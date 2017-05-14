using System;
using System.Globalization;
using System.Threading;

namespace FormatConvertCultureInfo
{
    class Program
    {
        static void Main(string[] args)
        {


            ExplicitConversion();
            TryParse();

            CultureInfoFormat();


        }

        private static void TryParse()
        {
            int x;
            var result = int.TryParse("123", out x);

            // x = 32-bit signed integer value equivalent to the number contained in string, 
            // if the conversion succeeded, or zero if the conversion failed
            Console.WriteLine("conversion succeeded: {0}, x: {1}", result, x);


        }

        private static void ExplicitConversion()
        {
            //explicit cast
            long x = 2147483647;
            int y = (int)x;
            
            // Convert class
            int z = Convert.ToInt32(x);

            Console.WriteLine("x {0}, y {1}, z {2} ", x, y, z);

        }

        private static void CultureInfoFormat()
        {
            //Get current thread culture
            var cc = Thread.CurrentThread.CurrentCulture;
            Console.WriteLine(cc);
            //Create specific culture
            var pl = new CultureInfo("pl-PL");
            //Set current thread culture
            Thread.CurrentThread.CurrentCulture = pl;


            //Create specific culture
            var enUs = new CultureInfo("en-US");


            WriteLocalTime(pl);
            WriteLocalTime(enUs);

        }

        private static void WriteLocalTime(CultureInfo ci)
        {
            Console.WriteLine(DateTime.Now.ToString(ci.DateTimeFormat));
        }
    }
}
