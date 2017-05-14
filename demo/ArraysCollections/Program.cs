using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace ArraysCollections
{

    class Program
    {
        static void Main(string[] args)
        {
            ArraysLists();
            DictionaryCollections();

        }

        private static void DictionaryCollections()
        {
            //int key, string value
            Dictionary<int, string> intBased = new Dictionary<int, string>();
            intBased.Add(1, "A");

            //string key, string value
            NameValueCollection nv = new NameValueCollection();
            nv.Add("A", "A");
            Dictionary<string, string> nv2 = new Dictionary<string, string>();
        }

        private static void ArraysLists()
        {
            int[] n1 = { 1, 2, 3 };
            int[] n2 = new int[4];
            n1.CopyTo(n2, 0);
            n2[3] = 4;


            //Object ArrayList implicit boxing and unboxing
            ArrayList l = new ArrayList();
            l.AddRange(n1);
            l.Add(2);
            l.Add("aba2");

            int x = (int)l[2];

            //Generic list without boxing
            List<int> l2 = new List<int>();
            l2.AddRange(n1);
            l2.Add(2);
            //l2.Add("2");

            int y = l2[2];

            Stack s1 = new Stack();
            Stack<int> s2 = new Stack<int>();

            s1.Push(2);
            s2.Push(2);
            var z1 = (int)s1.Pop();
            var z2 = s2.Pop();

        }
    }

}
