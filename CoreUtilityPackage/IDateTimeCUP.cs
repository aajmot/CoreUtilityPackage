using System;
using System.Collections.Generic;
using System.Text;

namespace CoreUtilityPackage
{
    public interface IDateTimeCUP: IBaseCUP
    {
        DateTime? ParseDateTime(string inputDateTime);
        bool IsValidDateTime(string inputDateTime);
    }
}
