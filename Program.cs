// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)  
 {

            // list of orders placed
            string[] orderIds = { "B123", "C234", "Z999", "A456", "B123", "X111" };
        

        // matching list of user IDs for each order. 
            string[] userIds = { "U100", "U777", "U500", "U100", "U999", "U500" };

        // each person bet
            int[] betAmounts = { 5000, 15000, 200, 10000, 15000, 3000 };

            string[] flaggedUsers = { "U777", "U999" };
            HashSet<string> seenOrderIds = new HashSet<string>();


            for (int i = 0; i < orderIds.Length; i++)
        {
                string order = orderIds[i];
                string user = userIds[i];
                int amount = betAmounts[i];

                List<string> reasons = new List<string>();

                if (order.StartsWith("B") || order.StartsWith("Z") || order.StartsWith("X"))
                    reasons.Add("Suspicious Order ID");

                if (amount > 10000)
                    reasons.Add("High Bet Amount");

                if (flaggedUsers.Contains(user))
                    reasons.Add("Flagged User ID");

                if (seenOrderIds.Contains(order))
                    reasons.Add("Duplicate Order ID");
                else
                    seenOrderIds.Add(order);

                if (reasons.Count > 0)
                {
                    Console.WriteLine($"🚨 Order {order} from User {user} flagged:");
                    foreach (string reason in reasons)
                    {
                        Console.WriteLine($" - {reason}");
                    }
                    Console.WriteLine();
                }
            }
   } 

}
