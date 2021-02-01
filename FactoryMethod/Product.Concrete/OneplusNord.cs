using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Product.Concrete
{
    public class OneplusNord:IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("Oneplus Nord mobile is created..");
        }
    }
}
