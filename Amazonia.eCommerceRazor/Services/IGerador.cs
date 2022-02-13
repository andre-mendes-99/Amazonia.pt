namespace Amazonia.eCommerceRazor.Services
{
    public interface IGerador
    {
        void GerarPDF(string path, byte[] data);
    }
}
