﻿namespace Customers.Models
{
    public class Repository
    {
        private static List<Customer> responses = new();
        public static IEnumerable<Customer> Responses => responses;

        public static void AddResponses(Customer response)
        {
            responses.Add(response);

        }
    }
}
