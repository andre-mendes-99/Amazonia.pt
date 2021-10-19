namespace Amazonia.DAL
{
   public class LivroImpresso : Livro
    {
        public int QuantidadedePaginas { get; set; }
        public Dimensoes Dimensoes { get; set; }
    }
}
