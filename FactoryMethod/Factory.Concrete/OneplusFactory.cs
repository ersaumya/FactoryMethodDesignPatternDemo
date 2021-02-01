using FactoryMethod.Factory.Interface;
using FactoryMethod.Product;
using FactoryMethod.Product.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Factory.Concrete
{
    public class OneplusFactory : IMobileFactory
    {
        public IMobile GetMobile(ModelTypes modelTypes)
        {
            switch (modelTypes)
            {
                case ModelTypes.Onplus8:
                    return new Oneplus8();
                case ModelTypes.OneplusNord:
                    return new OneplusNord();
                default:
                    throw new Exception("Invalid model type");
            }
        }

    }
}
