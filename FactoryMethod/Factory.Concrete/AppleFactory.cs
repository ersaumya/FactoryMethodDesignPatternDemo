using FactoryMethod.Factory.Interface;
using FactoryMethod.Product;
using FactoryMethod.Product.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Factory.Concrete
{
    public class AppleFactory : IMobileFactory
    {
        public IMobile GetMobile(ModelTypes modelTypes)
        {
            switch (modelTypes)
            {
                case ModelTypes.AppleIphone12:
                    return new AppleIphone12();
                case ModelTypes.AppleIphone12Pro:
                    return new AppleIphone12Pro();
                default:
                    throw new Exception("Invalid model type");
            }
        }
    }
}
