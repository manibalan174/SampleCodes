using System;

namespace Abstraction1
{
   abstract class Program
    {
      public  abstract void sayHello();
      public  void danceFun()
      {
          Console.WriteLine("All of as lets dances");
      }
        
    }
    class Test:Program
    {
         public  override void sayHello()
         {
             Console.WriteLine("Hello Ever One");
         }
         public static void Main(string[] args)
         {
             Test T = new Test();
             T.sayHello();
             T.danceFun();
         }
    }
}
