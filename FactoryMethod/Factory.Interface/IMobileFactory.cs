using FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Factory.Interface
{
    public interface IMobileFactory
    {
        IMobile GetMobile(ModelTypes modelTypes);
    }
}
