
using Autofac;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestMoqSimpleIoc
{
    public class IntWrapper
    {
        public int GetFromInterface()
        {
            IGetInteger getInteger = ServLocator.IGetInteger;
            int r = getInteger.GetInt();
            return r;
        }
    }
}
