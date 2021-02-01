using FactoryMethod;
using FactoryMethod.Factory.Concrete;
using FactoryMethod.Factory.Interface;
using FactoryMethod.Product;
using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            IMobileFactory mobileFactory = new AppleFactory();
            IMobile mobile = mobileFactory.GetMobile(ModelTypes.AppleIphone12);
            mobile.GetMobile();
            Console.ReadKey();
        }
    }
}
