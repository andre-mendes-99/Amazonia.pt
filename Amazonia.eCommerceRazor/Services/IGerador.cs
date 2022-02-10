using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazonia.eCommerceRazor.Services
{
   public interface IGerador
    {
        void GerarPDF(string path, byte[] data);
    }
}
