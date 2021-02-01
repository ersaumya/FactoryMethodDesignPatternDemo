using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Product.Concrete
{
    public class Oneplus8:IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("Oneplus 8 mobile is created..");
        }
    }
}
