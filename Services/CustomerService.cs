using BlazorApp1.Data;
using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace BlazorApp1.Services
{
    public class CustomerService
    {
        private IDbContextFactory<DemoDbContext> _dbContextFactory;

        public CustomerService(IDbContextFactory<DemoDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public void AddCustomer(Customer customer)
        {
            using(var context = _dbContextFactory.CreateDbContext())
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }
        }
        public Customer GetCustomerByName(string name) 
        {
			using (var context = _dbContextFactory.CreateDbContext())
			{
				var customer = context.Customers.SingleOrDefault(x=>x.Name == name);
                return customer;
			}

		}

        public void UpdateCustomerByName(string name, int age)
            
        {
            var customer = GetCustomerByName(name);
            customer.Age = age;

            if (customer == null)
            {
                throw new Exception("Customer does not exist");
            }
            using (var context = _dbContextFactory.CreateDbContext())
            {
                context.Update(customer);
                context.SaveChanges();
            }

        }
    }
}
