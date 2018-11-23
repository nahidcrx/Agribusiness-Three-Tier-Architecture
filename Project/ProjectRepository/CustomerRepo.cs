using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEntity;

namespace ProjectRepository
{
    public class CustomerRepo:ICustomerRepo
    {
        mydbContext context = new mydbContext();
        public int insert(Customer c) {
            context.Customers.Add(c);
            return context.SaveChanges();
        }

    }
}
