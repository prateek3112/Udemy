//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace project.Models
//{
//    public class OrderRepository : IOrderRepository
//    {
//        private readonly AppDbContext _appDbContext;
      


//        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
//        {
//            _appDbContext = appDbContext;
//            _shoppingCart = shoppingCart;
//        }


//        public void CreateOrder(Order order)
//        {
//            order.OrderPlaced = DateTime.Now;

//            _appDbContext.Orders.Add(order);

//            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

//            foreach (var shoppingCartItem in shoppingCartItems)
//            {
//                var orderDetail = new Orderdetails()
//                {
//                    Amount = shoppingCartItem.Amount,
//                    PieId = shoppingCartItem.Pie.PieId,
//                    OrderId = order.OrderId,
//                    Price = shoppingCartItem.Pie.Price
//                };

//                _appDbContext.OrderDetails.Add(orderDetail);
//            }

//            _appDbContext.SaveChanges();
//        }
//    }
//}
