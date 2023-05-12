using CoffeAppSimulation.Business.Abstract;
using CoffeAppSimulation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeAppSimulation.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            Console.WriteLine("Mernis");
            return false;

        }
    }
}
