using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEntity;

namespace ProjectRepository
{
    public class ProductRepo : IProductRepo
    {
        mydbContext context = new mydbContext();

        public List<Product> GetAll()
        {
            return context.Products.ToList();
        }

        public Details Details(int id) {

            Product p = context.Products.SingleOrDefault(i=>i.adid == id);
            Customer c = context.Customers.SingleOrDefault(i=>i.regid==p.pregid);
            Details d = new Details()
            {

                first_name = c.first_name,
                last_name = c.last_name,
                product_name = p.product_name,
                product_category = p.product_category,
                price_per_unit = p.price_per_unit,

                description = p.description,
                phone = p.pphone,
                division = p.pdivision

            };

            return d;
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

    }
}
