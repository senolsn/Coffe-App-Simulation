using CoffeAppSimulation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeAppSimulation.Business.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
