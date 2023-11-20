using Online_Store.Models;

namespace Online_Store.Repository
{
    public interface ICustomer
    {
        List<CustomerMode> GetAllCustomer();

        CustomerMode getCustomerById(int id);
    }
}
