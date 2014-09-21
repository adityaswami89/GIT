using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamlized.Database;
using System.Data.Linq;



namespace Xamlized.Repositories
{
   public class CustomerRepository : Repository<Product>,ICustomerRepository
    {

        public CustomerRepository(DataContext datacontext) : base(datacontext)
        {


        }

        public IQueryable<Product> FindProductsByCustomer(Customer customer)
        {

            return null;
           // return DataTable.Where(x=>x.OrderItems.Equals(new OrderItemRepository()));
            
        }
    }
}
