using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class ProductManager : IProduct
    {
        Gamer _gamer;

        public ProductManager(Gamer gamer)
        {
            _gamer = gamer;
        }
        public void Buy(Product product)
        {
            Console.WriteLine("Bu Oyun " + _gamer.FirstName+" Tarafından satın alındı.");
        }

        public void Return(Product product)
        {
            Console.WriteLine("ürün iade edildi.");
        }
    }
}
