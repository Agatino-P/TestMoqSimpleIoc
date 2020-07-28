using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestMoqSimpleIoc
{
    public class GetInteger : IGetInteger
    {
        public int GetInt()
        {
            return 1;
        }
    }
}
