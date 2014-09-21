using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamlized.Database;

namespace Xamlized.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> FindProductByOrderItems(List<OrderItem> orderitems);
    }
}
