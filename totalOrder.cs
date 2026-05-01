//You have a list of orders → find total order value.


// using System;
// using System.Linq;
// using System.Collections.Generic;

// public class Order
// {
//     public int orderID { get; set;}
//     public double amount {get; set;}
   
//     public static void Main(string[] args)
//     {
//         var orders = new List<Order>
//         {
//             new Order {orderID=1, amount = 300.56},
//             new Order {orderID=12, amount = 800.56},
//             new Order {orderID=11, amount = 679.56},
//             new Order {orderID=3, amount = 780.56},
//             new Order {orderID=5, amount = 669.56}
//         };       
//         var total = orders.Sum(o => o.amount);
        
//         Console.WriteLine($"Total Order Value = {total}");
//     }
// }