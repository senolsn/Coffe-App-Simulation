using CoffeAppSimulation.Adapters;
using CoffeAppSimulation.Business.Abstract;
using CoffeAppSimulation.Business.Concrete;
using CoffeAppSimulation.Entities.Concrete;

namespace CoffeAppSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ICustomerService customerService = new StarbucksCustomerManager(new MernisServiceAdapter());

            //Starbucks'a kayıt işlemi yapalım
            customerService.Save(new Customer() { Id = 1, FirstName = "Şenol", LastName = "Şen", NationalityId = "12345678901", DateOfBirth = new DateTime(1990, 1, 1) });
            Console.ReadLine();
            
        }
    }
}