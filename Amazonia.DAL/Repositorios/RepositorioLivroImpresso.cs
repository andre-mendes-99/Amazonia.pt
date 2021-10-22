using System;
using System.Collections.Generic;
using System.Linq;
using Amazonia.DAL;
using Amazonia.DAL.Entidades;
using Amazonia.DAL.Repositorios;

public class RepositorioLivroImpresso : IRepositorio<LivroImpresso>
{
    private List<LivroImpresso> Lista;

    public RepositorioLivroImpresso()
    {
        Lista = new List<LivroImpresso>();
          
                var lotrImp = new LivroImpresso
        {
            Nome = "O Senhor dos Aneis",
            Autor = "J.R.R. Tolkien",
            QuantidadePaginas = 500,
            Dimensoes = new Dimensoes{Largura = 10, Altura = 15, Profundidade = 5, Peso = 5}
        };
        Lista.Add(lotrImp);

        
    }
  public void Apagar(LivroImpresso obj)
    {
        Lista.Remove(obj);
    }

    public LivroImpresso Atualizar(string nomeAntigo, string nomeNovo)
    {
        var temp = ObterPorNome(nomeAntigo);
        temp.Nome = nomeNovo;

        return temp;
    }

    public void Criar(LivroImpresso obj)
    {
        Lista.Add(obj);
    }

    public LivroImpresso ObterPorNome(string Nome)
    {
        Console.WriteLine("ObterPorNome");
        var resultado = Lista
                        .Where(x => x.Nome == Nome)
                        .FirstOrDefault();
        return resultado;
    }

    public List<LivroImpresso> ObterTodos()
    {
        return Lista;
    }
}