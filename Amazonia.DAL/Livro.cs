namespace Amazonia.DAL
{
   public abstract class Livro
   {
      public string Nome { get; set; }
      public string TipodePublicacao { get; set; }
      public decimal Preco { get; set; }
      public string Descricao { get; set; }
      public string Autor { get; set; }   
      private Idioma Idioma { get; set; } //Português, Espanhol , Ingles
   } 
}

