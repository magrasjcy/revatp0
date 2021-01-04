using System;
using static com.pizzaworld.Orders.Order;
namespace com.pizzaworld.Orders {
   class Store {
      public static void Main(string[] arg) {
	  Store store=new Store();
	  store.processOrders(99U);
      }
      public void processOrders(uint unitno) { 
	   Order order=acceptOrder(unitno);
      }
      public Order acceptOrder(uint unitno) {
	   Order order=Order.build(unitno);
	   return order;
      }
   }
}
