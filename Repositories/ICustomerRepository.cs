using CustomerApi.Models;

namespace CustomerApi.Repositories
{
    public interface ICustomerRepository
    {
        Task<IList<Customer>> GetAllCustomers();
    }
}