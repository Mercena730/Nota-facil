using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace Nota_facil
{
    class crypsenha
    {
        public string encripton(string senhaoriginal)
        {
            byte[] bytsenhaoriginal;
            byte[] codificar;
            MD5 mD;
            mD = new MD5CryptoServiceProvider();
            bytsenhaoriginal = ASCIIEncoding.Default.GetBytes(senhaoriginal);
            codificar = mD.ComputeHash(bytsenhaoriginal);
            return Convert.ToBase64String(codificar);
        }
    }
}
