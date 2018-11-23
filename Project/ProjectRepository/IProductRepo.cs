using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEntity;

namespace ProjectRepository
{
    interface IProductRepo
    {
        List<Product> GetAll();

        //Product Get(int id);
        Details Details(int id);

        int Delete(Product P);
    }
}
