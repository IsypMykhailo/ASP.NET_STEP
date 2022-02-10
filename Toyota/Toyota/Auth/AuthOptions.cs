﻿using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toyota.Auth
{
    public class AuthOptions
    {
        public const string ISSUER = "ITStepAuthServer";
        public const string AUDIENCE = "ITStepAuthClient";
        const string KEY = "HjGl5GO50Kgw5kJfecKX98gmpIKasrb1Lu7JthXTvQ168xwLin8fqN2AkjbBScg";
        public const int LIFETIME = 1;
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
