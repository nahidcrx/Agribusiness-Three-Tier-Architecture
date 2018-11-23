using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEntity;

namespace ProjectRepository
{
    public class AdminRepo : IAdminRepo
    {
        mydbContext context = new mydbContext();

        public List<Customer> GetAll()
        {
            return context.Customers.ToList();
        }
        public List<Product> GetAll(int id)
        {
            string nid = id.ToString();
            var pro = from m in context.Products
                      select m;

            if (!String.IsNullOrEmpty(nid))
            {

                pro = pro.Where(m => m.pregid.ToString().Contains(nid));

            }
            return pro.ToList();
        }




        public Product Get(int id)
        {
            return context.Products.SingleOrDefault(i => i.adid == id);
        }

        public int Delete(Product p)
        {
            context.Products.Remove(p);

            return context.SaveChanges();
        }

        public int Insert(Admin a)
        {
            context.Admins.Add(a);
            return context.SaveChanges();

        }

        public List<Customer> GetAll(String s)
        {

            var pro = from m in context.Customers
                      select m;

            // List<Product> em = new List<Product>();




            pro = pro.Where(m => m.phone.Contains(s));


            var p = pro.ToList();
 


                return p;
           

        }



    }
}
