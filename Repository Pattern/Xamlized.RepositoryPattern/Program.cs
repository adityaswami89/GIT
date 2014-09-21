using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamlized.Database;
using Xamlized.Repositories;

namespace Xamlized.RepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dataContext = new CustomerDataContext())
            {
                var orderRepository = new Repository<Order>(dataContext);
                Order order = orderRepository.SearchFor(o => o.CustomerID == 38).Single();

                var orderItemsRepository = new Repository<OrderItem>(dataContext);
                var orderitems = orderItemsRepository.SearchFor(ot => ot.Order.Equals(order));

                var productrep = new ProductRepository(dataContext);
                var products = productrep.FindProductByOrderItems(orderitems.ToList());

                Console.WriteLine(" Products for {0} "+Environment.NewLine
                    +"----------------------", order.Customer.Name);

                foreach (var product in products)
                {
                    Console.WriteLine(product.Name);
                }

                Console.ReadKey();



            }
        }
    }
}
