using Amazonia.DAL.Infraestrutura;

namespace Amazonia.DAL.Infraestrutura
{
   public class ImpressoraPapel : IImpressora
    {
        public void Imprimir()
        {
            System.Console.WriteLine("Usando impressora Papel");
        }
    }
}