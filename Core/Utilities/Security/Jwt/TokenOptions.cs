using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Jwt
{
    public class TokenOptions
    {

        public string Audience { get; set; }//KullaniciKitlesi
        public string Issuer { get; set; }//imzalayan
        public int AccessTokenExpiration { get; set; }//Süre
        public string SecurityKey { get; set; }
    }
}
