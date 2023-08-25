namespace Instantiation;

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car();
        myCar.Brand = "Toyota";
        myCar.Model = "Camry";

        myCar.StartEngine();
    }
}