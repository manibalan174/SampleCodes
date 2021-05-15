using System;

namespace Encapslation
{
     class Program
    {
        private string _Name;
        private  int _Mark;
        private int _passMark = 50;
       // private static int counter;  
        // public  Program()
        // {
        //     counter++;
        // }
        // public static int counter
        //   {
        //       get
        //       {
        //           return counter;
        //       }
        //   }
        public string Name 
        {
            set{
            if(string.IsNullOrEmpty(value))
            {
                throw new Exception("Name is NUll Or Empty");
            }
            this._Name = value;
            }
            get
            {
              return  this._Name;
            }
        }
        public int Mark
        {
            set
            {
            if( value < 0 || value > 100)
            {
                throw new Exception("Invalid Mark");
            }
            this._Mark = value;
            }
            get
           {
               return this._Mark;
           }
        }
        public int Passmark
          {
              get{
                  return this._passMark;
              }
          }
    }
    public class TestEmployee{
       static void Main(string[] args)
        {
           
            Program p = new Program();
             // Console.WriteLine("Counts :"+ Program.counter);
            p.Name = "Kokki Kumar";
            p.Mark = 50;
            Console.WriteLine("Student Name : {0}\nStudent Mark : {1}\nPass Mark : {2} ",p.Name,p.Mark,p.Passmark);
          
        }
    }
}
