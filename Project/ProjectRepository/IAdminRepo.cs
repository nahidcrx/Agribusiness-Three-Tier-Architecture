using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEntity;

namespace ProjectRepository
{
    interface IAdminRepo
    {
        List<Customer> GetAll();
        List<Product> GetAll(int id);
        int Delete(Product P);
        int Insert(Admin a);


    }
}
