using System;

namespace DelegateAnonymousMethods
{
    delegate void DoAction(string message);
  

    class Program
    {
        static void Main(string[] args)
        {
            var l = new Logger();
            l.OnLineLogged += l_OnLineLogged;
            //anonymous method:
            l.OnLineLogged += delegate(object s, EventArgs e)
            {
                Console.WriteLine("Line has been logged (from anonymous method)");
            };

            
            l.Log("hello");
            
            Console.ReadLine();
        }
        //l_OnLineLogged - method that will handle an event  
        static void l_OnLineLogged(object s, EventArgs e)
        {
            Console.WriteLine("Line has been logged");
        }

    }
    class Logger
    {

        // public event DoAction OnLineLogged;
        public event EventHandler OnLineLogged;

        public void Log(string message)
        {
            //event subscriber existence check
            if (OnLineLogged != null)
            {
                OnLineLogged(this, new EventArgs());
            }
            Console.WriteLine(message);
        }

    }

}
