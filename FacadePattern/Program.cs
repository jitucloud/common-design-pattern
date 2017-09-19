using System;

namespace FacadePattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			// Facade
			MortgageFacade mortgage = new MortgageFacade();

			// Evaluate mortgage eligibility for customer
			Customer customer = new Customer("Ann McKinsey");
			bool eligible = mortgage.IsEligible(customer, 125000);

			Console.WriteLine("\n" + customer.Name +
				" has been " + (eligible ? "Approved" : "Rejected"));

			// Wait for user
			Console.ReadKey();
        }
    }
}
