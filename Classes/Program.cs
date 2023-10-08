using Classes;
using System.Net.Cache;
{
    static void Main(string[] args)
    {
        Car myCar = new Car();

        myCar.Make = "BMW";
        myCar.Model = "M2";
        myCar.Year = 2017;

        Console.WriteLine("Car Make: " + myCar.Make);
        Console.WriteLine("Car Model: " + myCar.Model);
        Console.WriteLine("Car Year: " + myCar.Year);
    }
}
