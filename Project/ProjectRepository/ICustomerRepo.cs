using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEntity;

namespace ProjectRepository
{
    public interface ICustomerRepo
    {
        int insert(Customer c);
    }
}
