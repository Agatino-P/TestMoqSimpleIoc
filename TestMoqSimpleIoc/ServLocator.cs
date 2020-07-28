using Autofac;
using Autofac.Extras.CommonServiceLocator;
using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;

namespace TestMoqSimpleIoc
{
    public static class ServLocator
    {
        public static IGetInteger IGetInteger { get; set; }

        static ServLocator()
        {
            SimpleIoc.Default.Register<IGetInteger, GetInteger>();
            IGetInteger = SimpleIoc.Default.GetInstance<IGetInteger>();
        }
    }
}
