using CoffeAppSimulation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeAppSimulation.Business.Abstract
{
    public abstract class BaseCustomerService : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine(customer.FirstName+ "Sisteme Kaydedildi !");
        }
    }
}
