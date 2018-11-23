using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEntity;

namespace ProjectRepository
{
    interface IProfileRepo
    {
        List<Product> GetAll(int id);

        //Product Get(int id);
        //Details Details(int id);
        Customer Get(int id);
        Details getmyinfo(int id);
        int insert(Product p);
        int Update(Customer c);
       

        List<Product> GetAll(string s);

    }
}
