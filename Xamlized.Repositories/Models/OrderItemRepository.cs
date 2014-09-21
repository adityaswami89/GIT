using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamlized.Database;
using System.Data.Linq;



namespace Xamlized.Repositories
{
   public class OrderItemRepository : Repository<OrderItem>, IOrderItemRepository
    {

        public OrderItemRepository(DataContext datacontext)
            : base(datacontext)
        {


        }

        public IQueryable<OrderItem> FindItemsByOrder(Order order)
        {
            return DataTable.Where(x => x.Order.Equals(order));
            
        }
    }
}
