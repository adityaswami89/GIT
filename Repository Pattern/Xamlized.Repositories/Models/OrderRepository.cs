using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamlized.Database;
using System.Data.Linq;



namespace Xamlized.Repositories
{
   public class OrderRepository : Repository<Order>,IOrderRepository
    {

        public OrderRepository(DataContext datacontext) : base(datacontext)
        {


        }

        public IQueryable<Order> FindOrdersByCustomer(Customer customer)
        {

            return DataTable.Where(x => x.Customer.Equals(customer));
            
        }
    }
}
