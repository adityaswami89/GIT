using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamlized.Database;

namespace Xamlized.Repositories
{
    public interface ICustomerRepository
    {

        IQueryable<Product> FindProductsByCustomer(Customer customer);
    }
}
