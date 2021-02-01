using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Product.Concrete
{
    class AppleIphone12Pro : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("Apple Iphone 12 Pro mobile is created..");
        }

    }
}
