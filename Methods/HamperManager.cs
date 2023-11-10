using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class HamperManager
    {
        //naming convention
        //syntax
        public void Add(Product product )
        {
            Console.WriteLine("Tebrikler Sepete Eklendi." + product.Name);

        }
        public void Add2(string productName, string productDescription, int price,int stockQuantity)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi." + productName+ productDescription+ price, stockQuantity);

        }
        public void Delete() 
        {
            Console.WriteLine("Silindi");

        }

    }
}
