using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Product.Concrete
{
    public class AppleIphone12:IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("Apple Iphone 12 mobile is created..");
        }
    }
}
