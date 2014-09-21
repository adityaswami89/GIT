using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamlized.Database;
using System.Data.Linq;



namespace Xamlized.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {

        public ProductRepository(DataContext datacontext)
            : base(datacontext)
        {


        }

        public IEnumerable<Product> FindProductByOrderItems(List<OrderItem> orderitems)
        {
            var SE = DataTable.Where(s => orderitems
                            .Select(so => so.ProductID)
                            .Contains(s.ProductID))
            .ToList();
            return SE;

        }
    }
}
