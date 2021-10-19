namespace Amazonia.DAL
{
    public class LivroDigital : Livro
    {   
        public int TamanhoemMB { get; set; }
        public string Formato { get; set; } //PDF ou DOC
        public string InformacoesdeLicenca { get; set; }
    
    public override decimal ObterPreco()
    {
        return base.ObterPreco() * 0.9M;
    }
    }
}
