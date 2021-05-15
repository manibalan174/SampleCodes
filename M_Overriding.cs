using System;

namespace Method_overriding
{
        public class BClass
	{
        public virtual void GetInfo()
    	{
            Console.WriteLine("This is Base Methods");
    	}
	}
    // Derived Class
    public class DClass : BClass
	{
        public override void GetInfo()
    	{
            Console.WriteLine("This is Derived in overridding");
    	}
	}
    class Program
	{
        static void Main(string[] args)
    	{
            DClass d = new DClass();
        	d.GetInfo();
            BClass b = new BClass();
        	b.GetInfo();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
    	}
	}

}
