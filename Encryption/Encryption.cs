﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Projeto1Criptografia
{
    public abstract class Encryption
    {
        public virtual string encrypt(string strToEncrypt)
        {
            throw new NotImplementedException();
        }

        public virtual string decrypt(string strToDecrypt)
        {
            throw new NotImplementedException();
        }
    }
}
