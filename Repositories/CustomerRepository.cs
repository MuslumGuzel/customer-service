using CustomerApi.Models;

namespace CustomerApi.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IList<Customer> customers = new List<Customer>();
        public CustomerRepository()
        {
            customers.Add(new Customer(){
                Id = Guid.NewGuid(),
                FirstName = "John",
                LastName = "Doe",
                EmailAddress = "john.doe@mail.com",
            });

            customers.Add(new Customer(){
                Id = Guid.NewGuid(),
                FirstName = "Joey",
                LastName = "Smith",
                EmailAddress = "joey.smith@mail.com",
            });
        }

        public async Task<IList<Customer>> GetAllCustomers()
        {
            return await Task.FromResult(customers).ConfigureAwait(false);
        }
    }
}