using System;
using System.Collections.Generic;
using System.Text;

namespace CoreUtilityPackage
{
    public interface ISecurityCUP:IBaseCUP
    {
        string Encrypt(string clearText);
        string Decrypt(string cipherText);
    }
}
