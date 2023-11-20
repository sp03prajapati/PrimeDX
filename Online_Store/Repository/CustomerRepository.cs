using Online_Store.Models;

namespace Online_Store.Repository
{
    public class CustomerRepository : ICustomer
    {
        public List<CustomerMode> GetAllCustomer()
        {
            return DataSource();
        }

        public CustomerMode getCustomerById(int id)
        {
            return DataSource().Where(x => x.Customer_Id == id).FirstOrDefault();
        }
        private List<CustomerMode> DataSource()
        { 
            return  new List<CustomerMode>
            {
                 new CustomerMode { Customer_Id = 2,Customer_Name = "Santosh",Customer_Age = 29  ,Customer_Description = "Text, a verse or passage from scripture used in expository preaching"},
                 new CustomerMode { Customer_Id = 3,Customer_Name = "Sani",Customer_Age = 22     ,Customer_Description = "Text, a verse or passage from scripture used in expository preaching"},
                 new CustomerMode { Customer_Id = 4,Customer_Name = "Ravi",Customer_Age = 20     ,Customer_Description = "Text, a verse or passage from scripture used in expository preaching"},
                 new CustomerMode { Customer_Id = 1,Customer_Name = "shailesh",Customer_Age = 27 ,Customer_Description = "Text, a verse or passage from scripture used in expository preaching"},
                 new CustomerMode { Customer_Id = 5,Customer_Name = "Gattu",Customer_Age = 18    ,Customer_Description = "Text, a verse or passage from scripture used in expository preaching"},
                 new CustomerMode { Customer_Id = 6,Customer_Name = "Soham",Customer_Age = 9     ,Customer_Description = "Text, a verse or passage from scripture used in expository preaching"}
            };
        }
    }
}
