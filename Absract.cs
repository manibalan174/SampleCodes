using System;

namespace Abstraction
{
      public class Bike
	{
        private string brand;
        private string model;
        public string Brand
    	{
            get { return brand; }
            set { brand = value; }
    	}
        public string Model
    	{
            get { return model; }
            set { model = value; }
    	}
        public void bikeDetails()
    	{
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Model: " + Model);
    	}
        public void Exlater()
    	{
            Console.WriteLine("Drive the Bike");
    	}
        private void engineFun()
    	{
            Console.WriteLine("Engine Function");
    	}
        private void gearFun()
    	{
            Console.WriteLine("Gear  Function");
    	}
	}
    class Program
	{
        static void Main(string[] args)
    	{
            Bike B = new Bike();
        	B.Brand = "Bajaj";
        	B.Model = "Pulsar";
        	B.bikeDetails();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
    	}
	}

}
