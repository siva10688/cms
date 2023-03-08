using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;

namespace CMS.Opps
{
    internal class Arraycollections
    {
        public void Array()
        {
            int[] arr = new int[5];
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void Array2()
        {

            int[,] arr = new int[4, 5];
            //for (int  i = 0; i <arr.GetLength(0); i++)
            //{
            //    for ( int j = 0; j <arr.GetLength(1); j++)


            //    {
            //        Console.WriteLine(arr[i,j]+"");
            //    }
            //}
            foreach (int i in arr)
            {
                Console.Write(i + "");
                Console.WriteLine();
            }
        }
        public void jaggedarray()
        {
            int[][] arr = new int[4][];
            arr[0] = new int[5];
            arr[1] = new int[2];
            arr[2] = new int[1];
            arr[3] = new int[7];
            foreach (int[] iarr in arr)
            {
                foreach (int i in iarr)
                    Console.Write(i + "");
                Console.WriteLine();
            }
        }
        // ----------------------------------------------------
        public void ArrayL()
        {
            ArrayList al = new ArrayList();
            int x = 2;
            string str = "bhavitha";
            al.Add(x);
            al.Add(str);
            foreach (object obj in al)
            {
                Console.Write(obj);
                Console.WriteLine();
            }

        }
        public void Hash()
        {
            Hashtable ht = new Hashtable();
            ht.Add("ora", "oracle");
            ht.Add("Db", "database");
            ht.Add("sq", "sql");
            foreach (DictionaryEntry d in ht)
            {
                Console.Write(d.Key + "" + d.Value);
                Console.WriteLine();
            }
        }
        public void Sorted()
        {
            SortedList sl = new SortedList();
            sl.Add("Vb", "visual basic");
            sl.Add("asp", "asp.net");
            foreach (DictionaryEntry d in sl)
            {
                Console.Write(d.Key + "" + d.Value);
                Console.WriteLine();
            }
        }
        public void Stack()
        {
            Stack s = new Stack();
            s.Push(10);
            s.Push("bhavitha");
            s.Push(2000);
            foreach (object obj in s)
            {
                Console.Write(obj);
                Console.WriteLine();
            }
        }
        public void Queue()
        {
            Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue("bhavitha");
            foreach (object obj in q)
            {
                Console.Write(obj);
                Console.WriteLine();
            }
        }
        //-------------------------------------
        public void List()
        {
            List<string> l = new List<string>();
            l.Add("hello");
            l.Add("marella");
            l.Add("bhavitha");
            foreach (string str in l)
            {
                Console.Write(str);
                Console.WriteLine();
            }
        }
        public void Dict()
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            {
                d.Add(1, "A");
                d.Add(2, "B");
                d.Add(3, "C");
                foreach (KeyValuePair<int, string> kvp in d)
                {
                    Console.Write(kvp.Key + "" + kvp.Value);
                    Console.WriteLine();
                }
            }
        }
        public void SortedList()
        {
            SortedList<string, string> sl = new SortedList<string, string>();
            sl.Add("hi", "hlo");
            sl.Add("everyone", "to");
            foreach (KeyValuePair<string, string> kvp in sl)
            {
                Console.Write(kvp.Key + "" + kvp.Value);
                Console.WriteLine();
            }
        }
        public void Stacks()
        {
            Stack<string> s = new Stack<string>();
            s.Push("Gnt");
            s.Push("hyd");
            foreach (String str in s)
            {
                Console.Write(str);
                Console.WriteLine();
            }
        }
        public void Queues()
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("hi");
            q.Enqueue("hlo");
            foreach (string str in q)
            {
                Console.Write(str);
                Console.WriteLine();
            }
        }
        

}   }
      

    

