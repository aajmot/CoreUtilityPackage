using System;
using System.Collections.Generic;
using System.Text;

namespace CoreUtilityPackage
{
    public interface INumberCUP : IBaseCUP
    {
        string NumberInWord(decimal number, string unit = "");
        Int32? IsInt32(object input);
    }
}
