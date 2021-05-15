using System;

namespace ObjecetSample
{
      class Program
    {
        public  int id;
         public string name;
        public void passParameter(int rollNo, string N)
        {
             id=rollNo;
             name=N;
        }
       public  void display()
        {
            Console.WriteLine(id+" "+ name);
        }
    }
    class Tes
    {
        public static void Main(string[] args)
        {
            Program p = new Program();
           Program p1 = new Program();
            p.passParameter(123,"Hello");
            p.display();
            p1.passParameter(123,"Hello");
             p1.display();
        }
    }
}
